using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2._1._2.Figures
{
    public class Rectangle : Square
    {
        public double Width {get;}
        public Rectangle(Point a, Point b, Point c, Point d) : base(a,b,c,d)
        {
            
        }
        protected override void SetSides()
        {
            var lineC = new Line(C, D);
            var lineD = new Line(A, D);
            if (width.Length != lineC.Length || length.Length != lineD.Length)
                           
        }

        public override double GetArea() => Width * Length;

        public override double GetPerimeter() => 2 * (Length + Width);

        public override string ToString() => string.Join(Environment.NewLine,"Прямоугольник: ", base.ToString());
        
    }
}
