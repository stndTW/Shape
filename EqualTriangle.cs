using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shape.ShapeComponents;

namespace Shape
{
    class EqualTriangle : AbstractTriangle
    {        
        //Так как это равносторонний треугольник то лини a/b/c буду равны.       
        public EqualTriangle()
        {
            AB = new Line(rnd.Next(1, 15));
            rnd = null;
            BC = new Line(AB);
            CA = new Line(BC);

            A = new Dote(AB, CA);
            B = new Dote(AB, BC);
            C = new Dote(BC, CA);
        }

        public override void Display()
        {
            Console.WriteLine("This is an equilateral triangle");
            Console.WriteLine("All sides are {0} cm.", this.AB.Length);
            base.Display();
        }

        public override void GetArea()
        {
            Area = (Math.Sqrt(3) * Math.Pow(AB.Length, 2)) / 4;
            base.GetArea();
        }

        public override void GetCoordinates()
        {
            A.Point = new Point(0, 0);
            C.Point = new Point(0, CA.Length);
            B.Point = new Point(Math.Sqrt(3) / 2 * CA.Length, AB.Length / 2);
            base.GetCoordinates();
        }

        public override void GetPerimetr()
        {
            Perimetr = 3 * AB.Length;
            base.GetPerimetr();
        }
    }
}
