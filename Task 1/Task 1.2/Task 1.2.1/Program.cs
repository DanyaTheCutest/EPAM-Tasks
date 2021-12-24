using System;

namespace Task_1._2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите строку: ");
            string input = Console.ReadLine(); //Результат округлён в большую сторону
            Console.WriteLine($"Средняя длина слова: {GetAverage(input)}");
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
