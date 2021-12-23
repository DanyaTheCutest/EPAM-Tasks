using System;

namespace Task_1._2._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите строку: ");
            string input = Console.ReadLine();
            Console.WriteLine(Validator(input));
        }
        static string Validator(string input)
        {
            string result = "";
            var arr = input.ToCharArray();
            result += Char.ToUpper(arr[0]).ToString();
            result += arr[1].ToString();
            for (int i = 2; i < arr.Length; i++)
            {
                if (isEndMark(arr[i-2]) && Char.IsLetter(arr[i]))
                    result += Char.ToUpper(arr[i]).ToString();
                else result += arr[i].ToString();
            }

            return result;
        }
        static bool isEndMark(char c) =>
            c == '.' || c == '?' || c == '!';
        
            
                
    }
}
