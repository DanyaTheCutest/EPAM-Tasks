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
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
        }
    }
}
