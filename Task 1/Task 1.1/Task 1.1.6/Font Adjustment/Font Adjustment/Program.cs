using System;
using System.Collections.Generic;

namespace Font_Adjustment
{
    class Program
    {
        static void Main(string[] args)
        {
            var styles = new List<string>();

            Console.ForegroundColor = ConsoleColor.Green;
            while (true)
            {
                Console.WriteLine($"Параметры надписи: {GetStyles(styles)}");
                Console.WriteLine("Введите: ");
                Console.WriteLine("       1: bold");
                Console.WriteLine("       2: italic");
                Console.WriteLine("       3: underline");
                int input = ReadInt();

                if (input >= 1 && input <= 3)
                {
                    if (styles.Contains(ChooseStyle(input)))
                        styles.Remove(ChooseStyle(input));
                    else styles.Add(ChooseStyle(input));
                }
                else break;
            }

        }

        static string GetStyles(List<string> styles)
        {
            return styles.Count == 0 ? "None" : string.Join(" ", styles.ToArray());
        }
        static string ChooseStyle(int style) => style switch
        {
            1 => "bold",
            2 => "italic",
            3 => "underline",
            _ => null
        };
        static int ReadInt()
        {
            string input;
            int n;
            do
                input = Console.ReadLine();
            while (!Int32.TryParse(input, out n));
            return n;
        }




    }
}
