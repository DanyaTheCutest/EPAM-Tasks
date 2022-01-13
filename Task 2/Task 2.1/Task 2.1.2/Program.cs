using System;

namespace Task_2._1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            var point1 = new Point(1, 1);
            var point2 = new Point(1, 1);

            var circle1 = new Circle(point1,5);
            var circle2 = new Circle(point2, 3);

            var ring = new Ring(circle2, circle1);
        }
    }
}
