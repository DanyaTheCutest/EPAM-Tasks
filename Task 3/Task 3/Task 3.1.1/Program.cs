using System;
using System.Collections;
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
            int n = N;
            for (int i = 0; i < N ; i++)
            {
                list.Add(i + 1);
            }
            Console.WriteLine($"The group of participants has been generated." +
                $" Starting to remove every {excludeStep} one");


            for (int i = 0; i < N; i++)
            {
                if (n == 0)
                    break;
                if (list.Count < excludeStep)
                    break;
                if (i == N)
                    i = 0;
                if (list.IndexOf(i) % excludeStep == 0)
                {
                    N--;
                    Console.WriteLine($"{list[i]} was removed. {N} participants left.");
                    list.Remove(i);
                }
            }


            //foreach (var item in list)
            //{
            //    if (N <= 0)
            //        break;
            //    if (list.IndexOf(item) % excludeStep == 0)
            //    {
            //        Console.WriteLine($"{item} was removed. {N - 1} participants left.");
            //        list.Remove(item);
            //        N--;
            //    }
            //}
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
