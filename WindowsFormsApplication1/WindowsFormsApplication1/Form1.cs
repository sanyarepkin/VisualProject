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
        List<Cross> Shapes = new List<Cross>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            this.Text = Convert.ToString(e.Location);
        }
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            Shapes.Add(new Cross(e.X, e.Y));
            this.Refresh();
        }
        
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            foreach (Cross p in Shapes)
            {
                p.DrawWith(e.Graphics);
            }
        }
        public class Cross
        {
            int X, Y;
            Pen p = new Pen(Color.Red);
            public Cross(int _X, int _Y)
            {
                X = _X; Y = _Y;
            }
            public  void DrawWith(Graphics g)
            {
                g.DrawLine(p, X - 4, Y - 4, X + 4, Y + 4);
                g.DrawLine(p, X + 4, Y - 4, X - 4, Y + 4);
            }
        }

        
    }
}
