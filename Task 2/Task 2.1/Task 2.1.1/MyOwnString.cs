using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2._1._1
{
    public class MyOwnString
    {
        private char[] _superString;

        

        public MyOwnString(char[] superString)
        {
            _superString = superString;
        }
        
        public bool IsEqual(char[] firstString, char[] secondString)
        {
            if (firstString.Length != secondString.Length)
                return false;
            for (int i = 0; i < firstString.Length; i++)
            {
                if (firstString[i] != secondString[i])
                    return false;
            }
            return true;
        }

        public char[] ConcatStrings(char c)
        {
            var result = new char[_superString.Length + 1];
            _superString.CopyTo(result, 0);
            result[result.Length - 1] = c;
            return result;
        }
        public char[] ConcatStrings(MyOwnString anotherString)
        {
            var result = new char[_superString.Length + anotherString._superString.Length];
            _superString.CopyTo(result, 0);
            anotherString._superString.CopyTo(result, _superString.Length);
            return result;
            
        }

        public int FindSymbolIndex(char c)
        {
                for (int i = 0; i < _superString.Length; i++)
                {
                    if (_superString[i] == c)
                        return i;
                }
             
            return -1;
        }

        public char[] ToCharArray()
        {
            var copy = new char[_superString.Length];
            _superString.CopyTo(copy, 0);
            return copy;
        }

        public override string ToString()
        {
            return new string(_superString);
        }

        public static int ConvertToInt(MyOwnString convertString) => 
            Convert.ToInt32(convertString.ToString());
        public static double ConvertToDouble(MyOwnString convertString) =>
            Convert.ToDouble(convertString.ToString());

        public char this[int index]
        {
            get => _superString[index];
            private set => _superString[index] = value;
        }
    }
}
