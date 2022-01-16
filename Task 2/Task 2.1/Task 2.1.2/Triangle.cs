using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2._1._2
{
    class Triangle : IAreable
    {
        public Point A { get; }
        public Point B { get; }
        public Point C { get; }
        private double _lineA;
        private double _lineB;
        private double _lineC;
        public Triangle(Point a, Point b, Point c)
        {
            _lineA = new Line(a, b).Length;
            _lineB = new Line(b, c).Length;
            _lineC = new Line(c, a).Length;
        }
        public override double GetPerimeter() => new Line(A, B).Length 
            + new Line(B, C).Length + new Line(C, A).Length;

        public override double GetArea()
        {
            var p = GetPerimeter() / 2;
            return Math.Sqrt(p * (p - _lineA) * (p - _lineB) * (p - _lineC)); 
        }
        public override string ToString()
        {
            return string.Join(Environment.NewLine, "Треугольник: ", $"Координаты углов: {A}{B}{C}", base.ToString());
        }
    }
}
