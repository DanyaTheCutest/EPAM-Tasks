using System;

namespace Rectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GetArea());
        }
        static int ReadPositiveInt()
        {
            int number;
            string input;
            do
            {
                Console.Write("Введите значение переменной больше 0: ");
                input = Console.ReadLine();
            } while (!Int32.TryParse(input, out number) || number <= 0);
            
            return number;
        }
        static string GetArea()
        {
            int a = ReadPositiveInt();
            int b = ReadPositiveInt();
            return $"Ответ: {a * b}";
        }
        
    }
}
