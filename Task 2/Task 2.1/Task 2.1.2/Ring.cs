using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2._1._2
{
    public class Ring : Circle
    {
        Circle InnerCircle = new Circle();
        Circle OuterCircle = new Circle();
        private double _ringArea;
        private double _ringLength;

        public Ring(double x, double y, double innerRadius, double outerRadius)
        {
            InnerCircle.X = x;
            OuterCircle.X = x;
            InnerCircle.Y = y;
            OuterCircle.Y = y;
            InnerCircle.Radius = innerRadius;
            OuterCircle.Radius = outerRadius;
        }
        public double GetRingArea()
        {
            _ringArea = Math.PI *
                (OuterCircle.Radius * OuterCircle.Radius - InnerCircle.Radius * InnerCircle.Radius);

            return _ringArea;
        }

        public double GetRingLength()
        {
            _ringLength = OuterCircle.GetLength() + InnerCircle.GetLength();

            return _ringLength;
        }
    }
}
