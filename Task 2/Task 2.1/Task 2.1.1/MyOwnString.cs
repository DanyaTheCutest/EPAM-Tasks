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

        public char[] Mystring 
        {
            get
            {
                return _superString;
            }
            set
            {
                _superString = value;
            } 
        }

        public MyOwnString(char[] superString)
        {
            Mystring = superString;
        }
        
        public bool IsEqual(char[] string_1, char[] string_2)
        {
            if (string_1.Length != string_2.Length)
                return false;
            for (int i = 0; i < string_1.Length; i++)
            {
                if (string_1[i] != string_2[i])
                    return false;
            }
            return true;
        }

        public char[] ConcatStrings(char c)
        {
            var result = new char[Mystring.Length + 1];
            Mystring.CopyTo(result, 0);
            result[result.Length - 1] = c;
            return result;
        }
        public char[] ConcatStrings(MyOwnString anotherString)
        {
            var result = new char[Mystring.Length + anotherString.Mystring.Length];
            Mystring.CopyTo(result, 0);
            anotherString.Mystring.CopyTo(result, Mystring.Length);
            return result;
            
        }

        public int FindSymbolIndex(char c)
        {
             if (Mystring.Contains(c))
             {
                for (int i = 0; i < Mystring.Length; i++)
                {
                    if (Mystring[i] == c)
                        return i;
                }
             }
            return -1;
        }
        public char[] GetString() => Mystring;

        public char[] ConvertToString(string input) => input.ToCharArray();


        public override string ToString()
        {
            string output = "";
            for (int i = 0; i < Mystring.Length; i++)
            {
                output += Mystring[i];
            }
            return output;
        }

        public static int ConvertToInt(MyOwnString convertString) => 
            Convert.ToInt32(convertString.Mystring.ToString());
        public static double ConvertToDouble(MyOwnString convertString) =>
            Convert.ToDouble(convertString.Mystring.ToString());
    }
}
