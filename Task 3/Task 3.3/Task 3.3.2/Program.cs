using System;

namespace Task_3._3._2
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            Console.WriteLine(str.GetLanguage()); 
        }        
    }
    public static class StringExtension
    {
        public static string GetLanguage(this string input)
        {
            input = input.ToLower();
            bool eng = false;
            bool rus = false;
            bool num = false;

            foreach (var item in input)
            {
                if (item >= 'a' && item <= 'z')
                    eng = true;
                if (item >= 'а' && item <= 'я')
                    rus = true;
                if (item >= '0' && item <= '9')
                    num = true;
            }

            switch (eng, rus, num)
            {
                case (true, false, false):
                    return "English";
                case (false, true, false):
                    return "Russian";
                case (false, false, true):
                    return "Numbers";
                default:
                    return "Mixed";
            }
        }
    }
}
