using System;

namespace X_MAS_Tree
{
    class Program
    {
        static void Main(string[] args)
        {

            int n;
            string input;
            do
            {
                input = Console.ReadLine();
            } while (!Int32.TryParse(input, out n));


            for (int i = 1; i <= n; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    string branch = new String('*', j);
                    Console.WriteLine(branch.PadLeft(n + 3) + "*" + branch);
                }
            }
        }                                 
    }
}
