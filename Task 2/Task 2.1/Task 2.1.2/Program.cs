using System;

namespace Task_2._1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            var circle = new Circle(2.0, 1.0, 3);
            Console.WriteLine(circle.GetArea()); 
        }
    }
}
