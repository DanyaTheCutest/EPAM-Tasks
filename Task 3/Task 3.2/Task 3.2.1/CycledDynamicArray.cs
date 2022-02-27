using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3._2._1
{
    public class CycledDynamicArray<T> : DynamicArray<T>, IEnumerator
    {
        int position = -1;
        
        public object Current
        {
            get
            {
                if (position == -1 || position >= Length)
                    throw new ArgumentException();
                return array[position];
            }

        }

        public bool MoveNext()
        {
            if (position == Length)
                Reset();
            position++;
            return true;
        }

        public void Reset()
        {
            position = -1;
        }
    }
}
