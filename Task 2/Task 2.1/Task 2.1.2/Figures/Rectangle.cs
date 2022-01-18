using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2._1._2.Figures
{
    public class Rectangle : Square
    {
        public double Width { get; private set; }
        public Rectangle(Point a, Point b, Point c, Point d) : base(a,b,c,d)
        {
            
        }
        protected override void Validate()
        {
            Length = new Line(A, B).Length;
            Width = new Line(B, C).Length;
            if (Length != new Line(C, D).Length)
                throw new Exception("Стороны AB и CD неравны");
            if (Width != new Line(A, D).Length)
                throw new Exception("Стороны BC и AD неравны");
                
        }

        public override double GetArea() => Width * Length;

        public override double GetPerimeter() => 2 * (Length + Width);

        public override string ToString() => string.Join(Environment.NewLine,"Прямоугольник: ", base.ToString().Remove(0,8));
        
    }
}
