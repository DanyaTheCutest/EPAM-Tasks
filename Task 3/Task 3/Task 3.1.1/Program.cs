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
            var list = new List<int>(N);
            bool flag = true;

            for (int i = 0; i < N; i++)
            {
                list.Add(i + 1);
            }

            Console.WriteLine($"The group of participants has been generated." +
                $" Starting to remove every {excludeStep} one");
          
            while (flag)
            {               
                for (int i = 0; i < list.Count; i++)
                {
                    if (list.IndexOf(list[i]) % excludeStep == 0)
                    {
                        Console.WriteLine($"{list[i]} was removed. {list.Count - 1} participants left.");
                        list.RemoveAt(i);
                    }
                    if (list.Count < excludeStep)
                    {
                        flag = false;
                        break;
                    }
                }
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
