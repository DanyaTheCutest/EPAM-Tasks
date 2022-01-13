using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2._1._2
{
    public class Rectangle : Square
    {
        private Line _sideA;
        private Line _sideB;
        private Line _bottomSide;
        private Line _rightSide;

        public Rectangle(Line sideA, Line sideB) : base(sideA)
        {
            if (sideA.EndCoordinates != sideB.StartCoordinates)
                throw new Exception("Линии не соприкасаются");
            SideA = sideA;
            SideB = sideB;
        }

        public Line SideA
        {
            get => _sideA;
            private set
            {
                _sideA = value;
            }
        }
        public Line SideB
        {
            get => _sideB;
            private set
            {
                _sideB = value;
            }
        }

        public new double GetArea()
        {
            return _sideA.Length * _sideB.Length;
        }

        public new double GetPerimeter()
        {
            return 2 * (_sideA.Length + _sideB.Length);
        }

        private void DrawRectangle(Line sideA, Line sideB)
        {
            _bottomSide = new Line(new Point(sideA.StartCoordinates[0],
                sideA.StartCoordinates[1]), new Point(sideB.EndCoordinates[0], sideA.StartCoordinates[1]));
            _rightSide = new Line(new Point(sideA.StartCoordinates[0],
                sideA.StartCoordinates[1]), new Point(sideB.EndCoordinates[0], sideA.StartCoordinates[1]));
        }

        public override string ToString()
        {
            return $"Координаты углов: {_sideA},{_rightSide}\n" +
                $"Площадь: {GetArea()}\nПериметр: {GetPerimeter()}";
        }
    }
}
