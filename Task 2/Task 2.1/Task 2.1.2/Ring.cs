using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2._1._2
{
    public class Ring : Figure
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
        public double GetRingArea() => Math.PI *
                (_outerCircle.Radius * _outerCircle.Radius - _innerCircle.Radius * _innerCircle.Radius);
        

        public double GetRingLength()
        {
            double ringLength = _outerCircle.GetLength() + _innerCircle.GetLength();
            return ringLength;
        }
        public override string ToString()
        {
            return $"Координаты центров: {_innerCircle.Center}\n" +
                $"Сумма длин окружностей: {GetRingLength()}\n" +
                $"Площадь кольца: {GetRingArea()}";
        }
    }
}
