using System;

namespace Task_2._1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            var point = new Point(-1, -1);
            var point2 = new Point(1, 1);

            var Line = new Line(point, point2);
            Console.WriteLine(Line.Length);

            var square = new Square(Line);

        }
    }
}
