using System;

namespace Task_1._2._4
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Console.WriteLine(Validator(input));
        }
        static string Validator(string input)
        {
            string result = "";
            var arr = input.ToCharArray();
            result += Char.ToUpper(arr[0]).ToString() + " ";

            for (int i = 2; i < arr.Length; i++)
            {
                if (isEndMark(arr[i-2]) && Char.IsLetter(arr[i]))
                    result += Char.ToUpper(arr[i]).ToString();
                else result += arr[i].ToString();
            }

            return result;
        }
        static bool isEndMark(char c)
        {
            if ((int)c == 33 || (int)c == 46 || (int)c == 63)
                return true;           
            return false;
        }
    }
}
