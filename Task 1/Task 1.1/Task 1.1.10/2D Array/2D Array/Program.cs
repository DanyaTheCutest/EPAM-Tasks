using System;

namespace _2D_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = CreateRandomArray(2, 3);
            PrintArray(arr);
            Console.WriteLine();

            Console.WriteLine($"Сумма элементов, стоящих на чётных позициях: {FindEvenSum(arr)}");
        }

        static int FindEvenSum(int[,] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (i + j % 2 == 0)
                        sum += arr[i, j];
                }
            }

            return sum;
        }

        static int[,] CreateRandomArray(int a, int b)
        {
            Random r = new Random();
            var arr = new int[a, b];

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                   arr[i,j] = r.Next(-10, 15);
                }
            }
            return arr;
        }
        static void PrintArray(int [,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(arr[i,j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
