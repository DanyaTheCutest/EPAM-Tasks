using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Task_3._3._3
{
    public enum PizzaType
    {
        Pepperoni,
        Meat,
        Mexican
    }
    public static class Pizzeria
    {
        public static void Cook(PizzaType pizza, string name)
        {
            Thread.Sleep(1000);
            Console.WriteLine($"{pizza} for client {name} is ready"); 
        }
    }
}
