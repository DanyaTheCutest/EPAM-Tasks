using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2._1._2
{
    class Repository
    {
        private List<Figure> figures = new List<Figure>();

        public void AddFigure(Figure figure) => figures.Add(figure);       
        public string GetAll() => figures.ToString();        
        public void Clear() => figures.Clear();
        
    }
}
