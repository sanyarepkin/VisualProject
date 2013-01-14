using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        List<Shape> Shapes = new List<Shape>();
        Point ShapeStart;
        bool IsShapeStart = true;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            foreach (Shape p in Shapes)
            {
                p.DrawWith(e.Graphics);
            }
        }
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            this.Text = Convert.ToString(e.Location);
        }
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
           if (rb_Cross.Checked) Shapes.Add(new Cross(e.X, e.Y));
           if (rb_line.Checked)
           {
               if (!IsShapeStart) ShapeStart = e.Location;
               else Shapes.Add(new Line(ShapeStart, e.Location));
               IsShapeStart = !IsShapeStart;
           }
           if (rb_Circle.Checked)
           {
               if (IsShapeStart) ShapeStart = e.Location;
               else Shapes.Add(new Circle(ShapeStart, e.Location));
               IsShapeStart = !IsShapeStart;
           }
           this.Refresh();
        }
        private void rb_CheckedChanged(object sender, EventArgs e)
        {
            IsShapeStart = !IsShapeStart;
        }
    }
}
