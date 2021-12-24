using System;

namespace Triangle
{
    class Program
    {
        static void Main(string[] args)
        {           
            DrawTriangle();
        }
        static void DrawTriangle()
        {
            var number = ReadInt();
            Console.Clear();

            for (int i = 1; i <= number; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");                   
                }
                Console.WriteLine();
            }

        }
        static int ReadInt()
        {
            int number = 0;
            string input = "";
            do
            {
                Console.Write("Введите число N, большее 0: ");
                input = Console.ReadLine();
            } while (Int32.TryParse(input, out number) == false || number <= 0);
            return number;
        }
    }
}
