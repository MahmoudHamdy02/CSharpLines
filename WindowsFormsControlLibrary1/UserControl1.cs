using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsControlLibrary1
{
    public partial class UserControl1: UserControl
    {
        private List<Line> lines = new List<Line>();
        HashSet<Point> intersections = new HashSet<Point>();
        private bool drawIntersections = false;
        private bool clickedOnce;
        private Point clickedPoint1;
        private Point clickedPoint2;
        public UserControl1()
        {
            InitializeComponent();
            Paint += splitContainer1_Panel1_Paint;
            dataGridView1.Rows[0].Cells[4].Style.BackColor = Color.Black;
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {
            Pen pen = new Pen(Color.Black, 2);
            foreach (var line in lines)
            {
                //set the color to draw the line with
                if (line.Color != pen.Color)
                    pen.Color = line.Color;
                e.Graphics.DrawLine(pen, line.Point1, line.Point2);
            }
            //draw intersection if draw intersection was pressed
            if (drawIntersections)
            {
                //reset pen color to default black color
                pen.Color = Color.Black;
                foreach (Point intersection in intersections)
                {
                    e.Graphics.DrawEllipse(pen, intersection.X -  10, intersection.Y - 10, 20, 20);
                }
            }
        }

        //using intersection law of two lines from four points
        private void findIntersectionsButton_Click(object sender, EventArgs e)
        {
            if (!drawIntersections)
                drawIntersections = true;
            //naive o(n^2) solution where we try all combinations to find intersections
            for (int i=0; i<lines.Count; ++i)
            {
                //extract our lines points
                Point point1 = lines.ElementAt(i).Point1;
                Point point2 = lines.ElementAt(i).Point2;
                //check against all others (that weren't checked) if there is an intersection
                for (int j = i+ 1; j < lines.Count; j++)
                {
                    Point point3 = lines.ElementAt(j).Point1;
                    Point point4 = lines.ElementAt(j).Point2;
                    //check if parallel or coincident... denom is zero
                    double denom = ((point1.X - point2.X) * (point3.Y - point4.Y)) - ((point1.Y - point2.Y) * (point3.X - point4.X));
                    if (denom != 0)
                    {
                        //we have an intersection store it but first calc numerator1 and two
                        double numeratorX = (
                                          ((point1.X * point2.Y) - (point1.Y * point2.X)) * (point3.X - point4.X)) -
                                          ((point1.X - point2.X) * ((point3.X * point4.Y) - (point3.Y * point4.X))
                                          );
                        double numeratorY = (
                                          ((point1.X * point2.Y) - (point1.Y * point2.X)) * (point3.Y - point4.Y)) -
                                          ((point1.Y - point2.Y) * ((point3.X * point4.Y) - (point3.Y * point4.X))
                                          );
                        Point intersection = new Point((int)(numeratorX / denom), (int)(numeratorY / denom));
                        // Check if the intersection point lies within the line segments
                        if (intersection.X < Math.Min(point1.X, point2.X) || intersection.X > Math.Max(point1.X, point2.X) ||
                            intersection.X < Math.Min(point3.X, point4.X) || intersection.X > Math.Max(point3.X, point4.X) ||
                            intersection.Y < Math.Min(point1.Y, point2.Y) || intersection.Y > Math.Max(point1.Y, point2.Y) ||
                            intersection.Y < Math.Min(point3.Y, point4.Y) || intersection.Y > Math.Max(point3.Y, point4.Y))
                        {
                            // The intersection point is outside the line segments, no intersection
                            continue;
                        }
                        intersections.Add(intersection);
                    }
                }
            }
            Refresh();
        }

        private void colorButton_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("on color button clicked");
            // Create a new instance of the ColorDialog
            ColorDialog colorDialog = new ColorDialog();

            // Show the color dialog and capture the result
            DialogResult result = colorDialog.ShowDialog();

            // Check if the user clicked the OK button in the dialog
            if (result == DialogResult.OK)
            {
                // Retrieve the selected color
                Color selectedColor = colorDialog.Color;
                colorButton.ForeColor = selectedColor;

                // Do something with the selected color
                Console.WriteLine("Selected color: " + selectedColor);
            }

        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.CurrentRow.Index;
            if (index < lines.Count)
            {
                lines.Remove(lines[index]);
                dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
                //re calculate intersections
                intersections = new HashSet<Point>();
                findIntersectionsButton_Click(sender, e);
                Refresh();
            }
        }

        private void splitContainer1_Panel1_Click(object sender, EventArgs e)
        {
            if (!clickedOnce)
            {
                clickedPoint1 = splitContainer1.Panel1.PointToClient(Cursor.Position);
                System.Diagnostics.Debug.WriteLine("once");
                clickedOnce = true;
            }
            else
            {
                System.Diagnostics.Debug.WriteLine("Added");
                clickedPoint2 = splitContainer1.Panel1.PointToClient(Cursor.Position);
                clickedOnce = false;
                lines.Add(new Line(clickedPoint1, clickedPoint2, colorButton.ForeColor));

                dataGridView1.Rows.Add(clickedPoint1.X, clickedPoint1.Y, clickedPoint2.X, clickedPoint2.Y);
                Refresh();
            }
        }
        private Color onColorCellClick()
        {
            ColorDialog colorDialog = new ColorDialog();

            // Show the color dialog and capture the result
            DialogResult result = colorDialog.ShowDialog();

            // Check if the user clicked the OK button in the dialog
            if (result == DialogResult.OK)
            {
                // Retrieve the selected color
                Color selectedColor = colorDialog.Color;
                return selectedColor;
            }
            return Color.Black;
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Cursor.Current = Cursors.IBeam;
            if (dataGridView1.CurrentCell.ColumnIndex.Equals(4))
            {
                Color c = onColorCellClick();
                dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[dataGridView1.CurrentCell.ColumnIndex].Style.BackColor = c;
                lines[dataGridView1.CurrentCell.RowIndex].Color = c;
                Refresh();
            }
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("Done");
            string x1 = Convert.ToString(dataGridView1.CurrentRow.Cells[0].Value);
            string y1 = Convert.ToString(dataGridView1.CurrentRow.Cells[1].Value);
            string x2 = Convert.ToString(dataGridView1.CurrentRow.Cells[2].Value);
            string y2 = Convert.ToString(dataGridView1.CurrentRow.Cells[3].Value);
            if (string.IsNullOrWhiteSpace(x1) || string.IsNullOrWhiteSpace(y1)
                || string.IsNullOrWhiteSpace(x2) || string.IsNullOrWhiteSpace(y2))
            {
                return;
            }
            else if (!x1.All(Char.IsDigit) || !y1.All(Char.IsDigit)
                || !x2.All(Char.IsDigit) || !y2.All(Char.IsDigit)) 
            {
                return;
            }
           
            int firstX = Convert.ToInt32(x1);
            int firstY = Convert.ToInt32(y1);
            int secondX = Convert.ToInt32(x2);
            int secondY = Convert.ToInt32(y2);

            Point point1 = new Point(firstX, firstY);
            Point point2 = new Point(secondX, secondY);
            Color lineColor = dataGridView1.CurrentRow.Cells[4].Style.BackColor;
            System.Diagnostics.Debug.WriteLine(lineColor);
            if ((e.RowIndex + 1) > lines.Count)
            {
                lines.Add(new Line(point1, point2, lineColor));
            }
            else
            {
                lines[e.RowIndex] = new Line(point1, point2, lineColor);
            }

            Refresh();
        }

        private void dataGridView1_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
        {
            e.Row.Cells["colColor"].Style.BackColor = Color.Black;
            Invalidate();
        }
    }

    public class Line
    {
        private Point point1;
        private Point point2;
        private Color color;

        public Line(Point point1, Point point2)
        {
            this.point1 = point1;
            this.point2 = point2;
            color = Color.Black;
        }

        public Line(Point point1, Point point2, Color color)
        {
            this.point1 = point1;
            this.point2 = point2;
            this.color = color;
        }

        public Color Color { get => color; set => color = value; }
        public Point Point2 { get => point2; set => point2 = value; }
        public Point Point1 { get => point1; set => point1 = value; }

        public override string ToString()
        {
            return "First Point X: " + Point1.X + ", First Point Y: " + Point1.Y + 
                ", Second Point X: " + Point2.X + ", Second Point Y: " + Point2.Y;
        }
    }
}
