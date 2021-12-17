using System;

namespace Rectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GetArea());
        }

        static string GetArea()
        {
            int number;
            string input = "";

            //Get A
            do
            {
                Console.Write("Введите значение a: ");
                input = Console.ReadLine();
            } while (!Int32.TryParse(input, out number));
            int a = number;
            if (a <= 0)
               return "Некорректное значение а";


            //Get B
            do
            {
                Console.Write("Введите значение b: ");
                input = Console.ReadLine();
            } while (!Int32.TryParse(input, out number));
            int b = number;
            if (b <= 0)
                return "Некорректное значение b";

            return $"Ответ: {a * b}";
        }
    }
}
