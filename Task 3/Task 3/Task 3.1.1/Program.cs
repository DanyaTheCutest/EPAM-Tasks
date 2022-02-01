using System;
using System.Collections.Generic;

namespace Task_3._1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Type in the number of participants: ");
            int N = ReadInt();
            Console.Write("Type in the order of removal step: ");
            int excludeStep = ReadInt();

            var list = new List<int>();
            for (int i = 0; i < N ; i++)
            {
                list.Add(i + 1);
            }
            Console.WriteLine($"The group of participants has been generated." +
                $" Starting to remove every {excludeStep} one");
            while(N >= excludeStep)
            {              
                list.Remove(excludeStep);
                N -= 1;
                Console.WriteLine($"One out. {N} people remaining");
            }
            Console.WriteLine("The game is over." +
                " Can not remove any more participants with the given step.");
        }   
        
        static int ReadInt()
        {
            int res;
            string input;
            do
            {
                input = Console.ReadLine();
            } while (!int.TryParse(input, out res) && res > 0);
            return res;
        }
    }
}
