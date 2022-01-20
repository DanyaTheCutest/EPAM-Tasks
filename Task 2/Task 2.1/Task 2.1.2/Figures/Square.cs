using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_2._1._2.Exceptions;

namespace Task_2._1._2.Figures
{
    public class Square : FigureWithArea
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
            Validate();
        }
        
        protected virtual void Validate()
        {
            Length = new Line(A, B).Length;
            var lineB = new Line(B, C).Length;
            var lineC = new Line(C, D).Length;
            var lineD = new Line(A, D).Length;
            if (Length != lineB || Length != lineC || Length != lineD)
                throw new LineException("Стороны неравны");
            if (Math.Abs((C.CoordinateX - B.CoordinateX) * (A.CoordinateX - B.CoordinateX) +
                (C.CoordinateY - B.CoordinateY) * (A.CoordinateY - B.CoordinateY)) > Math.E &&
                Math.Abs((C.CoordinateX - D.CoordinateX)*(A.CoordinateX-D.CoordinateX))+
                (C.CoordinateY - D.CoordinateY)*(A.CoordinateY-D.CoordinateY) > Math.E)
                throw new CornerException("Углы квадрата должны быть прямыми");
        }

        public override double GetArea() => Length * Length;
        
        public override double GetPerimeter() => Length * 4;
             
        public override string ToString()
        {
            return string.Join(Environment.NewLine, $"Квадрат:", $"Координаты углов: {A},{B},{C},{D}",
                 base.ToString());              
        }
    }
}
