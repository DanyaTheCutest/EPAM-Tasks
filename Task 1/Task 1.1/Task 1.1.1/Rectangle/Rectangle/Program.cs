using System;

namespace Rectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            GetArea();
        }

        static void GetArea()
        {
            int number;
            string input = "";

            do
            {
                Console.Write("Введите значение a: ");
                input = Console.ReadLine();
            } while (!Int32.TryParse(input, out number));
            int a = number;
            do
            {
                Console.Write("Введите значение b: ");
                input = Console.ReadLine();
            } while (!Int32.TryParse(input, out number));
            int b = number;
            Console.WriteLine($"Ответ: {a * b}");
        }
    }
}
