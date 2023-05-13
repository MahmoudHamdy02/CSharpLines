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
        public UserControl1()
        {
            InitializeComponent();
            Paint += splitContainer1_Panel1_Paint;
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
            Pen pen = new Pen(Color.Black, 3);
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

            //Point p1 = new Point(10, 10);
            //Point p2 = new Point(50, 50);
            //e.Graphics.DrawLine(pen, p1, p2);
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void findIntersectionsButton_Click(object sender, EventArgs e)
        {

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            //To Do: add error handling   
            System.Diagnostics.Debug.WriteLine("Added");
            int firstX = int.Parse(firstXBox.Text);
            int firstY = int.Parse(firstYBox.Text);
            int secondX = int.Parse(secondXBox.Text);
            int secondY = int.Parse(secondYBox.Text);
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
                //update the drawing
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

        //override tostring
    }
}
