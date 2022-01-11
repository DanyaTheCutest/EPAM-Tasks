using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2._1._2
{
    public class Circle
    {
        private Point _x;
        private Point _y;
        private double _radius;
        private const double _pi = Math.PI;
        

        public double Radius
        {
            get { return _radius; }
            private set
            {
                if (value > 0)
                    _radius = value;
            }
        }
        public double X
        {
            get { return _x.CoordinateX; }
            
        }
        public double Y
        {
            get { return _y.CoordinateY; }
            
        }


        public Circle(Point x, Point y, double r)
        {
            _x = x;
            _y = y;
            Radius = r;
        }       

        public double GetArea()
        {
            double area = 2 * _pi * (_radius * _radius);
            return area;
        }

        public double GetLength()
        {
            double roundLength = 2 * _pi * _radius;
            return roundLength;
        }
    }
}
