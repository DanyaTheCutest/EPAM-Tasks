﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2._1._2
{
    public abstract class CornerFigure : Figure
    {
        public abstract double GetArea();
        public abstract double GetPerimeter();

        public override string ToString()
        {
            return $"Площадь: {GetArea()}\nПериметр: {GetPerimeter()}";
        }
    }    
}
