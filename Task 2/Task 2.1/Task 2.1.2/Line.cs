using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2._1._2
{
    public class Line : Point
    {
        private Point _startPoint;
        private Point _endPoint;
        private double _length;

        
        
        public Line(Point start, Point end) 
        {
            _startPoint = start;
            _endPoint = end;
            SetLength(start, end);
        }

        
        private void SetLength(Point start, Point end) =>
            _length = end.CoordinateX - start.CoordinateX + end.CoordinateY - start.CoordinateY;




        public double Length
        {
            get => _length;
        }
    }
}
