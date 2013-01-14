using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace WindowsFormsApplication1
{
    public abstract class Shape
    {
        public abstract void DrawWith(Graphics g);
    }
    public class Cross : Shape
    {
        int X, Y;
        Pen p = new Pen(Color.Red);
        public Cross(int _X, int _Y)
        {
            X = _X; Y = _Y;
        }
        public override void DrawWith(Graphics g)
        {
            g.DrawLine(p, X - 4, Y - 4, X + 4, Y + 4);
            g.DrawLine(p, X + 4, Y - 4, X - 4, Y + 4);
        }
    }
    public class Line : Shape
    {
        Point C, F;
        Pen p = new Pen(Color.Blue);
        public Line(Point _C, Point _F)
        {
            this.C = _C; this.F = _F;
        }
        public override void DrawWith(Graphics g)
        {
            g.DrawLine(p, C, F);
        }
    }
    public class Circle : Shape
    {
        Point C, P;
        Pen p = new Pen(Color.Blue);
        int r;
        public Circle(Point _C, Point _P)
        {
            C = _C;
            P = _P;
            r = Convert.ToInt32(Math.Sqrt(Math.Pow(C.X - P.X, 2) + Math.Pow(C.Y - P.Y, 2)));
        }
        public override void DrawWith(Graphics g)
        {
            g.DrawEllipse(p, C.X - r, C.Y - r, 2 * r, 2 * r);
        }
    }
   
}
