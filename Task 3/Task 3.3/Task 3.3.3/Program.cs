using System;
using System.Threading.Tasks;

namespace Task_3._3._3
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var pizzeria = new Pizzeria();
            pizzeria.Notify += DisplayMessage;
            while (true)
            {
                var name = GetName();
                var pizza = GetPizzaType();
                await pizzeria.Cook(new Client(name), pizza);
            }
        }


        static void DisplayMessage(string message)
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(message);
            Console.ResetColor();
            Console.WriteLine();
        }
        static string GetName()
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            return name;
        }
        static Pizza? GetPizzaType()
        {
            Console.Write(string.Join(Environment.NewLine, "Choose pizza: ",
                "1: Pepperoni", "2: Meat", "3: Mexican", ""));
            int type = ReadInt();
            return type switch
            {
                1 => Pizza.Pepperoni,
                2 => Pizza.Meat,
                3 => Pizza.Mexican,
                _ => null,
            };
        }

        static int ReadInt()
        {
            string input;
            while (true)
            {
                input = Console.ReadLine();
                if (!int.TryParse(input, out int res) || res < 1 || res > 3)
                    Console.WriteLine("Dude, enter the number from 1 to 3");
                else return res;
            }
        }
    }
}
