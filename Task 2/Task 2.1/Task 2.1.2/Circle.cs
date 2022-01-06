using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2._1._2
{
    public class Circle
    {
        private double _centerX;
        private double _centerY;
        private double _radius;
        private const double _pi = Math.PI;
        private double _area;
        private double _roundLength;

        public double Radius
        {
            get { return _radius; }
            set 
            {
                if (value > 0)
                    _radius = value; 
            }
        }
        public double X
        {
            get { return _centerX; }
            set { _centerX = value; }
        }
        public double Y
        {
            get { return _centerY; }
            set { _centerY = value; }
        }


        public Circle(double x, double y, double r)
        {
            X = x;
            Y = y;
            Radius = r;
        }
        public Circle()
        {

        }

        public double GetArea()
        {
            _area = 2 * _pi * (_radius * _radius);
            return _area;
        }

        public double GetLength()
        {
            _roundLength = 2 * _pi * _radius;
            return _roundLength;
        }
        
    }
}
