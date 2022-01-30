using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3._1._2
{
    public class Word
    {
        public string Value { get; init; }
        public int Count { get; private set; }
        public Word(string value)
        {
            Value = value;
            Count = 1;
        }
        public void incrementCount()
        {
            Count++;
        }
    }
}
