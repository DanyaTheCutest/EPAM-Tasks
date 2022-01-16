using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2._1._2
{
    public class Rectangle : Square
    {
        public double Width {get;}
        public Rectangle(Point a, Point b, Point c, Point d) : base(a,b,c,d)
        {
            A = a;
            B = b;
            C = c;
            D = d;
            var length = new Line(a, d);
            var width = new Line(a, b);
            if (!Validate(length,width))
                throw new Exception("Длины противоположных сторон неравны");
            Length = length.Length;
            Width = width.Length;
        }
        private bool Validate(Line length, Line width)
        {
            var lineC = new Line(C, D);
            var lineD = new Line(A, D);
            if (width.Length != lineC.Length || length.Length != lineD.Length)
                return false;
            return true;            
        }

        public override double GetArea() => Width * Length;

        public override double GetPerimeter() => 2 * (Length + Width);

        public override string ToString() => string.Join(Environment.NewLine,"Прямоугольник: ", base.ToString());
        
    }
}
