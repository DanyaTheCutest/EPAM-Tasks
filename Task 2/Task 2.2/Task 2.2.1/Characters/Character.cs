using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_2._2._1.Field;

namespace Task_2._2._1.Characters
{
    public abstract class Character
    {
        protected abstract Coordinates Coordinates { get; set; }
        protected abstract int Width { get; set; }
        protected abstract int Height { get; set; }
        protected abstract int Health { get; set; }
        protected abstract int Damage { get; set; }
        protected abstract int Speed { get; set; }
        protected abstract void DoDamgage();
        protected abstract void TakeDamage();
        protected abstract void Move();
    }
}
