using System;

namespace AnotherTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите значение N: ");
            DrawTriangle();
        }
        static void DrawTriangle()
        {
            var n = ReadInt();
            Console.Clear();
            
            int spaces;
            int stars;
            for (int i = n; i > 0; i--)
            {
                stars = 2 * n - 2 * i + 1;
                spaces = i;
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
        static int ReadInt()
        {
            int n;
            string input;
            do
            {
                input = Console.ReadLine();
            } while (!Int32.TryParse(input, out n));
            return n;
        }
    }
}
