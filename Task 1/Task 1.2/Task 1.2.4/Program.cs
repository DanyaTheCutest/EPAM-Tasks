using System;
using System.Text;
namespace Task_1._2._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите строку: ");
            string input = Console.ReadLine();
            Console.WriteLine($"Результат: {Validate(input)}");
        }
        static string Validate(string input)
        {
            StringBuilder result = new StringBuilder("");
            var arr = input.ToCharArray();
            result.Append(Char.ToUpper(arr[0]));
            result.Append(arr[1]);
            for (int i = 2; i < arr.Length; i++)
            {
                if (IsEndMark(arr[i-2]) && Char.IsLetter(arr[i]))
                    result.Append(Char.ToUpper(arr[i]));
                else result.Append(arr[i]);
            }

            return result.ToString();
        }
        static bool IsEndMark(char c) =>
            c == '.' || c == '?' || c == '!';                           
    }
}
