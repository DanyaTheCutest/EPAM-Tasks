using System;

namespace Task_3._3._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Client client1 = new Client("Sam", PizzaType.Pepperoni);
            var client2 = new Client("Fred", PizzaType.Mexican);
        }
    }
}
