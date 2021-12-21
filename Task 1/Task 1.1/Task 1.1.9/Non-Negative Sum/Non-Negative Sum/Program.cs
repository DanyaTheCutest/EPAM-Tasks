using System;

namespace Non_Negative_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = CreateRandomArray();
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            Console.WriteLine($"Сумма неотрицательных элементов: {NonNegativeSum(arr)}");
        }

        static int NonNegativeSum(int[] arr)
        {
            int sum = 0;
            foreach (var item in arr)
            {
                if (item >= 0)
                    sum += item;
            }

            return sum;
        }

        static int[] CreateRandomArray()
        {
            Random r = new Random();
            var arr = new int[10];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = r.Next(-100, 100);
            }
            return arr;
        }
    }
}
