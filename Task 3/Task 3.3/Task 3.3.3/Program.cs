using System;
using System.Threading.Tasks;

namespace Task_3._3._3
{
    class Program
    {
        static void Main(string[] args)
        {
            var pizzeria = new Pizzeria();
            pizzeria.Notify += DisplayMessage;
            while (true)
            {
                var t = Task.Run(() =>
                {
                    var name = GetName();
                    var pizza = GetPizzaType();
                    pizzeria.Cook(new Client(name), pizza);
                });
                t.Wait();               
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
            Console.Write(string.Join(Environment.NewLine,"Choose pizza: ","1: Pepperoni","2: Meat", "3: Mexican",""));
            int type = ReadInt();
            switch (type)
            {
                case 1: return Pizza.Pepperoni;
                case 2: return Pizza.Meat;
                case 3: return Pizza.Mexican;
                default: return null;
            }
        }
        
        static int ReadInt()
        {
            int res;
            string input;
            while (true)
            {
                input = Console.ReadLine();
                if (!int.TryParse(input, out res) || res < 1 || res > 3)
                    Console.WriteLine("Dude, enter the number from 1 to 3");
                else return res;
            }
        }
    }
}
