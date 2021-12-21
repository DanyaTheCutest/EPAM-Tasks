using System;

namespace Taskl_1._2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine(); // Результат округлён в большую сторонул
            Console.WriteLine(GetAverage(input));
        }
        static double GetAverage(string str)
        {
            double symbolsNumber = 0;
            double wordsNumber = 0;
            str = str.Trim();
            var arr = str.ToCharArray();
            for (int i = 0; i < arr.Length; i++)
            {
                if (i != arr.Length - 1)
                {
                    if (Char.IsLetterOrDigit(arr[i]))
                        symbolsNumber++;
                    else if (Char.IsWhiteSpace(arr[i]))
                        wordsNumber++;
                }
                else
                {
                    wordsNumber++;
                    symbolsNumber++;
                }
            }

            return Math.Ceiling(symbolsNumber / wordsNumber);
        }
    }
}
