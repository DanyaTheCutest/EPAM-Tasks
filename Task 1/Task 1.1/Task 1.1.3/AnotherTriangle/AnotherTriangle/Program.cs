using System;

namespace AnotherTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            DrawTriangle();
        }
        static void DrawTriangle()
        {
            int n;
            string input;
            do
            {
                input = Console.ReadLine();
            } while (!Int32.TryParse(input, out n));
            Console.Clear();
            
            int spaces;
            int stars;
            for (int i = n; i > 0; i--)
            {
                stars = 2 * n - 2 * i + 1;
                spaces = i-2;
                while (spaces >= 0)
                {
                    Console.Write(" ");
                    spaces--;
                }
                while (stars > 0)
                {
                    Console.Write("*");
                    if (stars == 1)
                        Console.WriteLine();
                    stars--;
                }                
            }
        }
    }
}
