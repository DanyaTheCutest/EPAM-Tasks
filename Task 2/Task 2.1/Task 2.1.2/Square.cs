using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2._1._2
{
    public class Square : CornerFigure
    {
        public Point A { get; }
        public Point B { get; }
        public Point C { get; }
        public Point D { get; }

        public double Length { get; }
        public Square(Point a, Point b, Point c, Point d)
        {
            A = a;
            B = b;
            C = c;
            D = d;
            var line = new Line(a, b);
            if (line.Length != new Line(C, D).Length)
                throw new Exception("Длины сторон неравны");
            Length = line.Length;
        }
       
        public override double GetArea() => Length * Length;
        
        public override double GetPerimeter() => Length * 4;
             
        public override string ToString()
        {
            return $"Координаты углов: {A},{B},{C},{D}{Environment.NewLine}" +
                base.ToString();
        }
    }
}
