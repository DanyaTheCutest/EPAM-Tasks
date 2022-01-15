using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2._1._2
{
    public class Line : Figure
    {
        private Point _startPoint;
        private Point _endPoint;
        private double _length;

        public Line(Point start, Point end) 
        {
            ValidateSide(start, end);
            _startPoint = start;
            _endPoint = end;

            SetLength(start, end);
        }

        public double[] StartCoordinates
        {
            get => new double[2] { _startPoint.CoordinateX, _startPoint.CoordinateY };
        }

        public double[] EndCoordinates
        {
            get => new double[2] { _endPoint.CoordinateX, _endPoint.CoordinateY };
        }

        private void SetLength(Point start, Point end) =>
            _length = Math.Sqrt(Math.Pow((end.CoordinateX - start.CoordinateX), 2) +
                      Math.Pow((end.CoordinateY - start.CoordinateY), 2));

        public double Length
        {
            get => _length;
        }
        public override string ToString()
        {
            return $"{{{_startPoint}}},{{{_endPoint}}}";             
        }
        private void ValidateSide(Point start, Point end)
        {
            if (start.CoordinateX == end.CoordinateX && start.CoordinateY == end.CoordinateY)
                throw new Exception("Координаты начала и конца линии не могут быть равны");           
        }
    }
}
