using System;
using System.Text;
namespace Task_1._2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите начальную строку: ");
            string inputString = Console.ReadLine();
            Console.Write("Введите строку с символами для удвоения: ");
            string doublerString = Console.ReadLine();

            Console.WriteLine($"Результат: {Doubler(inputString, doublerString)}");
        }
        static string Doubler(string inputString, string doublerString)
        {
            StringBuilder resultString = new StringBuilder("");
            var arr = inputString.ToCharArray();

            for (int i = 0; i < inputString.Length; i++)
            {
                if (doublerString.Contains(arr[i]) && Char.IsLetterOrDigit(arr[i]))
                {
                    resultString.Append(arr[i]);
                    resultString.Append(arr[i]);
                }
                else resultString.Append(arr[i]);
            }

            return resultString.ToString();
        }
    }
}
