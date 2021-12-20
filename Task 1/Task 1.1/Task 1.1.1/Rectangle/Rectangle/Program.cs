using System;

namespace Rectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GetArea());
        }
        static int ReadInt()
        {
            int number;
            string input;
            do
            {
                Console.Write("Введите значение переменной: ");
                input = Console.ReadLine();
            } while (!Int32.TryParse(input, out number) || number <= 0);
            
            return number;
        }
        static string GetArea()
        {
            int a = ReadInt();
            int b = ReadInt();

            




            return $"Ответ: {a * b}";
        }
        
    }
}
