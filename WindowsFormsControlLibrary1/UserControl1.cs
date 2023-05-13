using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            Pen blackPen = new Pen(Color.Black, 3);
            foreach (var line in lines)
            {
                System.Diagnostics.Debug.WriteLine("draw");
                System.Diagnostics.Debug.WriteLine(line.Point1);
                System.Diagnostics.Debug.WriteLine(line.Point2);

                e.Graphics.DrawLine(blackPen, line.Point1, line.Point2);
            }

            //Point p1 = new Point(10, 10);
            //Point p2 = new Point(50, 50);
            //e.Graphics.DrawLine(blackPen, p1, p2);
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void findIntersectionsButton_Click(object sender, EventArgs e)
        {

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("Added");
            int firstX = int.Parse(firstXBox.Text);
            int firstY = int.Parse(firstYBox.Text);
            int secondX = int.Parse(secondXBox.Text);
            int secondY = int.Parse(secondYBox.Text);
            Point point1 = new Point(firstX, firstY);
            Point point2 = new Point(secondX, secondY);
            lines.Add(new Line(point1, point2));
            //this.Invalidate();
            this.Refresh();
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
    }
}
