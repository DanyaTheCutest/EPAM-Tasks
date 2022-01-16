using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2._1._2
{
    public class Circle : IAreable
    {
        public Point Center { get; }
        public double Radius { get; }

        public Circle(Point center, double r)
        {
            if (r <= 0)
                throw new Exception("Радиус не может быть меньше или равен 0");
            Center = center;
            Radius = r;
        }

        public Circle(double x, double y, double r) : this(new Point(x, y), r){ }
       
        public override double GetArea() => 2 * Math.PI * (Radius * Radius);
        
        public override double GetPerimeter() => 2 * Math.PI * Radius;
       
        public override string ToString()
        {
            return string.Join(Environment.NewLine, "Круг: ", $"Координаты центра {Center}",
                $"Длина окружности: {GetPerimeter()}",
                $"Радиус {Radius}", $"Площадь: {GetArea()}");
        }
    }
}
