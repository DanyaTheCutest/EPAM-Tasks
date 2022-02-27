using System;

namespace Task_3._1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            Analysis yo = new Analysis(input);
            Console.WriteLine(yo.Analyze());
            Console.ReadLine();
        }
    }
}
