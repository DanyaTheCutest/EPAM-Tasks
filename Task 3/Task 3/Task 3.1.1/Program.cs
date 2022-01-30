using System;

namespace Task_3._1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число участников: ");
            int N = ReadInt();
            Console.Write("Введите порядок удаления участников: ");
            int excludeStep = ReadInt();

            while(N >= excludeStep)
            {

            }
        }   
        
        static int ReadInt()
        {
            int res;
            string input;
            do
            {
                input = Console.ReadLine();
            } while (!int.TryParse(input, out res) && res > 0);
            return res;
        }
    }
}
