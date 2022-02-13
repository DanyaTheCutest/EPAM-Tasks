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
            var arr = input.ToCharArray();
            byte[] b = System.Text.Encoding.Default.GetBytes(input);
            int engCount = 0;
            int rusCount = 0;
            int numCount = 0;

            foreach (var item in b)
            {
                if ((item >= 97) && (item <= 122)) engCount++;
                if ((item >= 192) && (item <= 239)) rusCount++;                
            }
            foreach (var item in arr)
            {
                if (Char.IsDigit(item))
                    numCount++;
            }
            if (numCount != 0 && (rusCount != 0 || engCount != 0))
                return "Mixed";
            if (numCount != 0 && rusCount == 0 && engCount == 0)
                return "Numbers";
            if (rusCount != 0 && engCount != 0)
                return "Mixed";
            if (engCount != 0 && rusCount == 0)
                return "English";
            if (rusCount != 0 && engCount == 0)
                return "Russian";
            return "";
        }
    }
}
