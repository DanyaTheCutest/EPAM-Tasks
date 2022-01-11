using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2._1._2
{
    public class Ring 
    {
        private Circle _innerCircle;
        private Circle _outerCircle;
        

        public Ring(Circle inner, Circle outer)
        {
            if (inner.Center != outer.Center)
                throw new Exception("Координаты центров не совпадают");
            _innerCircle = inner;
            _outerCircle = outer;
        }
        public double GetRingArea()
        {
           double ringArea = Math.PI *
                (_outerCircle.Radius * _outerCircle.Radius - _innerCircle.Radius * _innerCircle.Radius);

            return ringArea;
        }

        public double GetRingLength()
        {
            double ringLength = _outerCircle.GetLength() + _innerCircle.GetLength();

            return ringLength;
        }
    }
}
