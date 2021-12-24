using System;

namespace X_MAS_Tree
{
    class Program
    {
        static void Main(string[] args)
        {
            DrawTree();          
        }
        
        static void DrawTree()
        {
            int n = ReadInt();
            for (int i = 1; i <= n; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    string branch = new String('*', j);
                    Console.WriteLine(branch.PadLeft(n + 3) + "*" + branch);
                }
            }
        }
        static int ReadInt()
        {
            int n;
            string input;
            do
            {
                Console.Write("Введите число N, большее 0: ");
                input = Console.ReadLine();
            } while (!Int32.TryParse(input, out n) || n <= 0);
            return n;
        }
    }
}
