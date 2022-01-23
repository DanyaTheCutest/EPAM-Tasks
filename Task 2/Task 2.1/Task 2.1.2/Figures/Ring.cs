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
            if (inner.Radius > outer.Radius)
                throw new Exception("Внутренний радиус больше внешнего");
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
            return string.Join(Environment.NewLine, $"Координаты центров: {_innerCircle.Center}" +
                $"Сумма длин окружностей: {GetPerimeter()}" +
                $"Площадь кольца: {GetArea()}");
        }
    }
}
