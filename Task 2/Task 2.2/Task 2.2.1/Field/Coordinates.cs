using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2._2._1.Field
{
    public class Coordinates
    {
        public double CoordinateX { get; protected set; }
        public double CoordinateY { get; protected set; }
        public double[] GetCoordinates
        {
            get => new double[2] { CoordinateX, CoordinateY };           
        }
        public Coordinates(double x, double y)
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
