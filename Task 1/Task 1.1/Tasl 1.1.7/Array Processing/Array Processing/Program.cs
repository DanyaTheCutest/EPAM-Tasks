using System;

namespace Array_Processing
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = CreateRandomArray();
            var sortedArray = SortArray(array);
            //Or "array = SortArray(array);"

            foreach (var item in sortedArray)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            Console.WriteLine($"Элемент с максимальным значением: {FindMax(sortedArray)}");
            Console.WriteLine($"Элемент с минимальным значением: {FindMin(sortedArray)}");
        }

        static int FindMax(int[] arr)
        {
            int max = arr[0];

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max)
                    max = arr[i];
            }
            return max;
        }

        static int FindMin(int[] arr)
        {
            int min = arr[0];

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < min)
                    min = arr[i];
            }
            return min;
        }

        static int[] SortArray(int[] arr)
        {
            int b;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length-1; j++)
                {
                    if (arr[j] > arr[j+1])
                    {
                        b = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = b;
                    }
                }
            }
            return arr;
        }

        static int[] CreateRandomArray()
        {
            Random r = new Random();
            var arr = new int[10];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = r.Next(100);
            }
            return arr;
        }
    }
}
