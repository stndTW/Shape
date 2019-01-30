using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shape.ShapeComponents;

namespace Shape
{
    class RigthTriangle : AbstractTriangle
    {
        //Стороны А и С - катангенсы, В - гипотенуза

        public RigthTriangle()
        {
            AB = new Line(rnd.Next(1, 15));
            CA = new Line(rnd.Next(1, 15));
            double SumPowAC = Math.Pow(AB.Length, 2) + Math.Pow(CA.Length, 2);
            BC = new Line(Math.Sqrt(SumPowAC));

            A = new Dote(AB, CA);
            B = new Dote(AB, BC);
            C = new Dote(BC, CA);
        }

        public override void Display()
        {
            Console.WriteLine("This is an right triangle");
            Console.WriteLine("Cotangent AB: {0} cm.", this.AB.Length);
            Console.WriteLine("Cotangent CA: {0} cm.", this.CA.Length);
            Console.WriteLine("Hypotenuse BC: {0:#.##} cm.", this.BC.Length);
            base.Display();
        }

        public override void GetArea()
        {
            Area = AB.Length * BC.Length / 2;
            base.GetArea();
        }

        public override void GetCoordinates()
        {
            A.Point = new Point(0, 0);
            B.Point = new Point(AB.Length, 0);
            C.Point = new Point(0, CA.Length);
            base.GetCoordinates();
        }

        public override void GetPerimetr()
        {
            Perimetr = AB.Length + BC.Length + CA.Length;
            base.GetPerimetr();
        }
    }
}
