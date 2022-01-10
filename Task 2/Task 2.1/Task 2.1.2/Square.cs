using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2._1._2
{
    public class Square 
    {
        private int _side = 0;

        public Square()
        {

        }

        public Square(int side)
        {
            Side = side;
        }
        public int Side
        {
            get => _side;
            set
            {
                if (value > 0)
                    _side = value;
            }
        }
        public int GetArea()
        {
            int area = _side * _side;
            return area;
        }

        public int GetPerimeter()
        {
            int perimeter = _side * 4;
            return perimeter;
        }

    }
}
