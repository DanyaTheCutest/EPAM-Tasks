using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2._1._1
{
    public class MyOwnString
    {
        public char[] superString;
        

        public MyOwnString(char[] superString)
        {
            this.superString = superString;
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

        public void ConcatStrings(char c)
        {
            char[] result = new char[superString.Length + 1];
            superString.CopyTo(result, 0);
            result[result.Length - 1] = c;
            superString = result;
        }
        public void ConcatStrings(MyOwnString anotherString)
        {
            char[] result = new char[superString.Length + anotherString.superString.Length];
            superString.CopyTo(result, 0);
            anotherString.superString.CopyTo(result, superString.Length);
            superString = result;
            
        }

        public int FindSymbolIndex(char c)
        {
             if (superString.Contains(c))
             {
                for (int i = 0; i < superString.Length; i++)
                {
                    if (superString[i] == c)
                        return i;
                }
             }
            return -1;
        }
        public string GetString()
        {
            return superString.ToString();         
        }

        public char[] ConvertToString(string input) => input.ToCharArray();
        
            
        

        public int ConvertFromString(MyOwnString convert) => 
            Convert.ToInt32(convert.superString.ToString());
    }
}
