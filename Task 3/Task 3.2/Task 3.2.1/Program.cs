using System;
using System.Collections.Generic;

namespace Task_3._2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = new DynamicArray<int>();
            arr.Add(5);
            arr.Add(7);
            arr.Add(5);
            arr.Add(7);
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            arr.Remove(0);
            arr[1] = 11;
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
        }
    }
}
