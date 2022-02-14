using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3._3._3
{
    public class Client
    {
        public string Name { get; }
        public PizzaType Pizza { get; }
       
        public Client(string name, PizzaType pizza)
        {
            Name = name;
            Pizza = pizza;
            PlaceOrder();
        }

        public void PlaceOrder()
        {
            Pizzeria.Cook(Pizza, Name);
        }
    }
}
