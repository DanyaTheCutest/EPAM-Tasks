using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Task_3._3._3
{
    public class Pizzeria
    {
        public delegate void CookHandler(string message);
        public event CookHandler Notify;
        public async void Cook(Client client, Pizza? pizza)
        {
            await Task.Run(() =>
            {
                Thread.Sleep(TimeSpan.FromSeconds(5));
                Notify?.Invoke($"{pizza} for {client.Name} is ready!");
            });
        }
    }
}
