using System;

namespace No_Positive
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = CreateRandomArray();
            arr = ReplacePositives(arr);

            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
        }

        static int[,,] ReplacePositives(int[,,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    for (int k = 0; k < arr.GetLength(2); k++)
                    {
                        if (arr[i, j, k] > 0)
                            arr[i, j, k] = 0;
                    }
                }
            }

            return arr;
        }

        static int[,,] CreateRandomArray()
        {
            Random r = new Random();
            var arr = new int[5, 5, 5];
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    for (int k = 0; k < arr.GetLength(2); k++)
                    {
                        arr[i, j, k] = r.Next(-100, 100);
                    }
                }
            }
            return arr;
        }
    }
}
