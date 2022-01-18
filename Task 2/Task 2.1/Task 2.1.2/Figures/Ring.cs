using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2._1._2.Figures
{
    public class Ring : FigureWithArea
    {
        private Circle _innerCircle;
        private Circle _outerCircle;
        

        public Ring(Circle inner, Circle outer)
        {
            if (inner.Center.CoordinateX != outer.Center.CoordinateX)
                throw new Exception("Координаты центров не совпадают");
            _innerCircle = inner;
            _outerCircle = outer;
        }
        public override double GetArea() => Math.PI *
                (_outerCircle.Radius * _outerCircle.Radius - _innerCircle.Radius * _innerCircle.Radius);
        

        public override double GetPerimeter()
        {
            double ringLength = _outerCircle.GetPerimeter() + _innerCircle.GetPerimeter();
            return ringLength;
        }
        public override string ToString()
        {
            return $"Координаты центров: {_innerCircle.Center}\n" +
                $"Сумма длин окружностей: {GetPerimeter()}\n" +
                $"Площадь кольца: {GetArea()}";
        }
    }
}
