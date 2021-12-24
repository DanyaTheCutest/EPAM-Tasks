using System;

namespace Task_1._2._3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Со *
            Console.Write("Введите строку: ");
            string input = Console.ReadLine();
            Console.WriteLine($"Количество слов, начинающихся с маленькой буквы: {CountLower(input)}");
        }
        static int CountLower(string input)
        {
            int count = 0;
            var arr = input.ToCharArray();
            if (Char.IsLower(arr[0]))
                count++;
            for (int i = 1; i < arr.Length; i++)
            {
                if (Char.IsLower(arr[i]) && Char.IsLetterOrDigit(arr[i-1]) == false)
                    count++;
            }

            return count;
        }
    }
}
