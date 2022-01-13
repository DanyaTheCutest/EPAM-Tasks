﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2._1._2
{
    public class Point
    {
        private double _coordinateX;
        private double _coordinateY;

        public double CoordinateX
        {
            get => _coordinateX;
            private set
            {
                _coordinateX = value;
            }
        }
        public double CoordinateY
        {
            get => _coordinateY;
            private set
            {               
                 _coordinateY = value;
            }
        }

        public Point(double x, double y)
        {
            CoordinateX = x;
            CoordinateY = y;
        }
        public override string ToString()
        {
            return $"[{_coordinateX}; {_coordinateY}]";
        }

    }
}
