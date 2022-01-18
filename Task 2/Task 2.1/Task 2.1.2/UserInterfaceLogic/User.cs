using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_2._1._2.Figures;

namespace Task_2._1._2
{
    public class User
    {
        private Repository _repository = new Repository();
        public string Name { get; }       

        public User(string name)
        {
            Name = name;
        }
        
        
    }
}
