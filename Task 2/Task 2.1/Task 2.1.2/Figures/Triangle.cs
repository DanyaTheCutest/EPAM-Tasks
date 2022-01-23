using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2._1._2.Figures
{
    class Triangle : FigureWithArea
    {
        public Point A { get; }
        public Point B { get; }
        public Point C { get; }
        public double _lineA { get; }
        public double _lineB { get; }
        public double _lineC { get; }
        public Triangle(Point a, Point b, Point c)
        {
            A = a;
            B = b;
            C = c;
            _lineA = new Line(a, b).Length;
            _lineB = new Line(b, c).Length;
            _lineC = new Line(c, a).Length;
        }
        public override double GetPerimeter() => _lineA
            + _lineB + _lineC;

        public override double GetArea()
        {
            var p = GetPerimeter() / 2;           
            return Math.Sqrt(p * (p - _lineA) * (p - _lineB) * (p - _lineC)); 
        }
        public override string ToString()
        {
            return string.Join(Environment.NewLine, "Треугольник: ", $"Координаты вершин: {A}{B}{C}", base.ToString());
        }
    }
}
