using System;


namespace Task_3._3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = new int[] { 1, 3, 3, 4, 5 };

            Console.WriteLine(arr.FindAverage());
            Console.WriteLine(arr.FindSum());
            Console.WriteLine(arr.FindMostCommon());

            arr = arr.ApplyToMass((x) => x * x);
            Console.WriteLine();
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
        }
    }
}
