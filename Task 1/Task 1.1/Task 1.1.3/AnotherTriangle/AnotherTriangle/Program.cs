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
            int n = 0;
            string input;
            do
            {
                Console.Write("Введите значение N, большее 0: ");
                input = Console.ReadLine();
            } while (!Int32.TryParse(input, out n) || n <= 0);
            return n;
        }
    }
}
