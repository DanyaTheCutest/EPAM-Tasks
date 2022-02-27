using System;


namespace Task_3._3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = new int[] { 1, 3, 5, 5, 5 };

            Console.WriteLine($"Average is {arr.FindAverage()}");
            Console.WriteLine($"Sum of elements is {arr.FindSum()}");
            Console.WriteLine($"Most common is {arr.FindMostCommon()}");

            arr = arr.ApplyToMass((x) => x * x);
            Console.WriteLine();
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
        }
    }
}
