using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shape.ShapeComponents;

namespace Shape
{
    class IsoscelesTriangle : AbstractTriangle
    {
        //Равнобедренный треугольник, в котором стороны А и В равны

        Line height;
        public IsoscelesTriangle()
        {
            AB = new Line(rnd.Next(5, 15));
            BC = new Line(AB);
            CA = new Line(rnd.Next(5, 15));

            if (CA.Length == BC.Length)
                CA = new Line(rnd.Next(1, 15));
            height = new Line(Math.Sqrt(AB.Length * BC.Length - Math.Pow(CA.Length / 2,2)));

            A = new Dote(CA, AB);
            B = new Dote(AB, BC);
            C = new Dote(BC, CA);
        }

        public override void Display()
        {
            Console.WriteLine("This is an isosceles triangle");
            Console.WriteLine("sides AB and BC: {0} cm.", this.AB.Length);            
            Console.WriteLine("side CA: {0:#.##} cm.", this.CA.Length);
            base.Display();
        }

        public override void GetArea()
        {
            Area = (height.Length * CA.Length)/2;
            base.GetArea();
        }

        public override void GetCoordinates()
        {
            A.Point = new Point(0, 0);
            C.Point = new Point(0, CA.Length);
            B.Point = new Point(height.Length, CA.Length / 2);
            base.GetCoordinates();
        }

        public override void GetPerimetr()
        {
            Perimetr = AB.Length * 2 + CA.Length;
            base.GetPerimetr();
        }
    }
}
