using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2._1._2.Exceptions
{
    public class LineException : Exception
    {
        public LineException(string message) : base(message) { }
    }
}
