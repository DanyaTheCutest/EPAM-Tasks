using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2._1._2
{
    public class Rectangle : Square
    {
        public Point A { get; }
        public Point B { get; }
        public Point C { get; }
        public Point D { get; }
        public Line Length { get; }
        public Line Width { get; }
        public Rectangle(Point a, Point b, Point c, Point d) : base(a,b,c,d)
        {
            A = a;
            B = b;
            C = c;
            D = d;
            if (new Line(a, b).Length != new Line(c, d).Length || new Line(b,c).Length != new Line(a,d).Length)
                throw new Exception("Длины противоположных сторон неравны");
            Length = new Line(a, d);
            Width = new Line(a, b);
        }

        public override double GetArea() => Width.Length * Length.Length;

        public new double GetPerimeter() => 2 * (Length.Length + Width.Length);

        public override string ToString() => base.ToString();
        
    }
}
