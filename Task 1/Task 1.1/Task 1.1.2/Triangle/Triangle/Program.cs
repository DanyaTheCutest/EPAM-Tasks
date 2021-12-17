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
            int number;
            string input = "";
            do
            {
               input = Console.ReadLine();
            } while (!Int32.TryParse(input, out number));
            Console.Clear();

            for (int i = 1; i <= number; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                    if (j == i - 1)
                        Console.WriteLine("");
                }
            }

        }
    }
}
