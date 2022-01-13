using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2._1._2
{
    public class Circle
    {
        private Point _center;       
        private double _radius;
        private const double _pi = Math.PI;
        

        public double Radius
        {
            get { return _radius; }
            private set
            {
                if (value <= 0)
                    throw new Exception("Радиус не может быть меньше или равен 0");
                _radius = value;
            }
        }

        public double[] Center { get =>
                new double[2] { _center.CoordinateX, _center.CoordinateY };}

        public Circle(Point center, double r)
        {
            _center = center;
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
        public override string ToString()
        {
            return $"Координаты центра: {Center}\nДлина окружности: {GetLength()}\n" +
                $"Радиус: {Radius}\nПлощадь: {GetArea()}";
        }
    }
}
