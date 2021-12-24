using System;

namespace SumOfNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            for (int i = 1; i < 1000; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                    sum += i;
            }
            Console.WriteLine($"Сумма чисел от 1 до 1000, кратных 3 или 5 равна {sum}");                       
        }
    }
}
