using System;

namespace Rectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GetArea());
        }
        static int ReadInt()
        {
            int number;
            string input;
            do
            {
                Console.Write("Введите значение переменной: ");
                input = Console.ReadLine();
            } while (!Int32.TryParse(input, out number));
            return number;
        }
        static string GetArea()
        {
            int a = ReadInt();
            if (a <= 0)
                return "Некорректное значение а";

            int b = ReadInt();
            if (b <= 0)
                return "Некорректное значение b";

            return $"Ответ: {a * b}";
        }
    }
}
