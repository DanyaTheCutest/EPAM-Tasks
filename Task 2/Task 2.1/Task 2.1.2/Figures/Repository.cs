﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2._1._2.Figures
{
    public class Repository
    {
        protected List<Figure> figures = new List<Figure>();

        public void AddFigure(Figure figure) => figures.Add(figure);
        public List<Figure> GetAll()
        {
            var copy = new List<Figure>(figures);
            return copy;
        }
        
        
        public void Clear() => figures.Clear();

        
    }
}
