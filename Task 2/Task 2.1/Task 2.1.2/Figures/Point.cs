using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2._1._2.Figures
{
    public class Point : Figure
    {
        public double CoordinateX { get; private set; } 
        public double CoordinateY { get; private set; }       

        public Point(double x, double y)
        {
            CoordinateX = x;
            CoordinateY = y;
        }
        public override string ToString()
        {
            return $"[{CoordinateX}; {CoordinateY}]";
        }
    }
}
