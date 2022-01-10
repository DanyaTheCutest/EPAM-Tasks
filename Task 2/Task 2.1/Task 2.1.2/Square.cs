using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2._1._2
{
    public class Square 
    {
        private Line _leftLine;
        private Line _topLine;
        private Line _bottomLine;
        private Line _rightLine;

        public Square(Line side)
        {
            if (side.StartCoordinates[0] != side.EndCoordinates[0])
                throw new Exception("Это не квадрат! У квадрата сторона должна быть прямой!");
            else
            {
                _leftLine = side;
                DrawSquare(side);
            }
        }

        private void DrawSquare(Line side)
        {
             _topLine = new Line(new Point(side.EndCoordinates[0], side.EndCoordinates[1]),
                new Point(side.StartCoordinates[0] + side.Length, side.EndCoordinates[1]));

             _bottomLine = new Line(new Point(_leftLine.StartCoordinates[0], side.StartCoordinates[1]),
                new Point(side.StartCoordinates[0] + side.Length, side.StartCoordinates[1]));

             _rightLine = new Line(new Point(_leftLine.StartCoordinates[0] + side.Length, side.StartCoordinates[1]),
                new Point(side.StartCoordinates[0] + side.Length, side.EndCoordinates[1]));
                        
        }

        public double GetArea()
        {
            double area = _leftLine.Length * _leftLine.Length;
            return area;
        }

        public double GetPerimeter()
        {
            double perimeter = _leftLine.Length * 4;
            return perimeter;
        }

    }
}
