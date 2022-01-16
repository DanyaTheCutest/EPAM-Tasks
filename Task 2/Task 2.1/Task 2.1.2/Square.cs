using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2._1._2
{
    public class Square : IAreable
    {
        public Point A { get; protected set; }
        public Point B { get; protected set; }
        public Point C { get; protected set; }
        public Point D { get; protected set; }

        public double Length { get; protected set; }
        public Square(Point a, Point b, Point c, Point d)
        {
            A = a;
            B = b;
            C = c;
            D = d;
            var line = new Line(a, b); 
            if (!Validate(line))
                throw new Exception("Длины сторон неравны");
            Length = line.Length;
        }
        
        private bool Validate(Line line)
        {           
            var lineB = new Line(B, C);
            var lineC = new Line(C, D);
            var lineD = new Line(A, D);
            if (line.Length != lineB.Length || line.Length != lineC.Length || line.Length != lineD.Length)
                return false;
            return true;
        }

        public override double GetArea() => Length * Length;
        
        public override double GetPerimeter() => Length * 4;
             
        public override string ToString()
        {
            return $"Квадрат: {Environment.NewLine}Координаты углов: {A},{B},{C},{D}{Environment.NewLine}" +
                base.ToString();
        }
    }
}
