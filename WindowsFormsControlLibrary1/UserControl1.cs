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
            //this.Controls.Add(splitContainer1.Panel1);
            //lines.Add(new Line(new Point(30, 20), new Point(10, 40)));
        }

        private void sevenButton_Click(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {
            //Graphics graphics = this.splitContainer1.Panel2.CreateGraphics();
            Pen pen = new Pen(Color.Black, 2);
            foreach (var line in lines)
            {
                System.Diagnostics.Debug.WriteLine("draw");
                System.Diagnostics.Debug.WriteLine(line.Point1);
                System.Diagnostics.Debug.WriteLine(line.Point2);
                //set the color to draw the line with
                if (line.Color != pen.Color)
                    pen.Color = line.Color;
                e.Graphics.DrawLine(pen, line.Point1, line.Point2);
            }
            //draw intersection if draw intersection was pressed
            if (drawIntersections)
            {
                //reset pen color ot default black color
                pen.Color = Color.Black;
                foreach (Point intersection in intersections)
                {
                    //ToDO: maybe make 10 a function in window width
                    e.Graphics.DrawEllipse(pen, intersection.X -  10, intersection.Y - 10, 20, 20);
                }
            }

            //Point p1 = new Point(10, 10);
            //Point p2 = new Point(50, 50);
            //e.Graphics.DrawLine(pen, p1, p2);
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

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
            this.Refresh();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            //To Do: add error handling   
            System.Diagnostics.Debug.WriteLine("Added");
            if (string.IsNullOrWhiteSpace(firstXBox.Text) || string.IsNullOrWhiteSpace(firstYBox.Text) 
                || string.IsNullOrWhiteSpace(secondXBox.Text) || string.IsNullOrWhiteSpace(secondYBox.Text))
            {
                MessageBox.Show("Points cannot be empty", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!firstXBox.Text.All(Char.IsDigit) || !firstXBox.Text.All(Char.IsDigit)
                || !secondXBox.Text.All(Char.IsDigit) || !secondYBox.Text.All(Char.IsDigit))
            {
                MessageBox.Show("Enter digits only", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int firstX = (int)Math.Round(float.Parse(firstXBox.Text));
            int firstY = (int)Math.Round(float.Parse(firstYBox.Text));
            int secondX = (int)Math.Round(float.Parse(secondXBox.Text));
            int secondY = (int)Math.Round(float.Parse(secondYBox.Text));

            Point point1 = new Point(firstX, firstY);
            Point point2 = new Point(secondX, secondY);
            lines.Add(new Line(point1, point2, colorButton.ForeColor));

            //add to list
            ListViewItem item = new ListViewItem();
            item.Text = "First point (x=" + firstX + ",y=" + firstY + ") Second point (x=" + secondX + ",y=" + secondY+")";
            linesView.Items.Add(item);

            //this.Invalidate();
            this.Refresh();
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

        private void linesView_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Get the index of the selected item
            int selectedIndex = linesView.SelectedIndices.Count > 0 ? linesView.SelectedIndices[0] : -1;

            // Check if selected item is in lines list
            if (selectedIndex >= 0 && selectedIndex < lines.Count)
            {
                //update the textboxes and color button color
                firstXBox.Text = lines.ElementAt(selectedIndex).Point1.X.ToString();
                firstYBox.Text = lines.ElementAt(selectedIndex).Point1.Y.ToString();
                secondXBox.Text = lines.ElementAt(selectedIndex).Point2.X.ToString();
                secondYBox.Text = lines.ElementAt(selectedIndex).Point2.Y.ToString();
                colorButton.ForeColor = lines.ElementAt(selectedIndex).Color;
            }
            //ToDo add error handling code in this case the else should never be reached
        }

        //the implementation is based on keeping the list in the same order as our internal line list
        //To Do: add error messages
        private void removeButton_Click(object sender, EventArgs e)
        {
            // Get the index of the selected item
            int selectedIndex = linesView.SelectedIndices.Count > 0 ? linesView.SelectedIndices[0] : -1;

            // Check if an item is selected and if so remove it from both our lists
            if (selectedIndex != -1)
            {
                System.Diagnostics.Debug.WriteLine("Selected index: " + selectedIndex);
                linesView.Items.RemoveAt(selectedIndex);
                // Check if the target index exists if not check the one before it
                if (selectedIndex >= 0 && selectedIndex < linesView.Items.Count)
                {
                    // Select the item at the target index
                    linesView.Items[selectedIndex].Selected = true;
                    linesView.Select(); // set focus to it
                } else if (selectedIndex - 1 >=0 && selectedIndex < linesView.Items.Count)
                {
                    linesView.Items[selectedIndex - 1].Selected = true;
                    linesView.Select(); // set focus to it
                }
                lines.RemoveAt(selectedIndex);
                //call intersection calculations but first remove all intersections
                intersections.Clear();
                findIntersectionsButton_Click(sender, e);
                //update the drawing
                this.Refresh();
            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            //update the coordinates with current coordinates and update color with current color
            int selectedIndex = linesView.SelectedIndices.Count > 0 ? linesView.SelectedIndices[0] : -1;
            if (selectedIndex >= 0 && selectedIndex < lines.Count)
            {
                lines.ElementAt(selectedIndex).Point1 = new Point(int.Parse(firstXBox.Text), int.Parse(firstYBox.Text));
                lines.ElementAt(selectedIndex).Point2 = new Point(int.Parse(secondXBox.Text), int.Parse(secondYBox.Text));
                if (colorButton.ForeColor != lines.ElementAt(selectedIndex).Color)
                    lines.ElementAt(selectedIndex).Color = colorButton.ForeColor;
            }
            //update the drawing
            this.Refresh();
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

                //add to list
                ListViewItem item = new ListViewItem();
                item.Text = "First point (x=" + clickedPoint1.X + ",y=" + clickedPoint1.Y + ") Second point (x=" + clickedPoint2.X + ",y=" + clickedPoint2.Y + ")";
                linesView.Items.Add(item);

                //this.Invalidate();
                this.Refresh();
            }
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
