using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shape.ShapeComponents;

namespace Shape
{
    class Square : AbstractQuadrilateral
    {
        //in Square height = width. also all 4 sides equal;
        public Square()
        {
            height = new Line(rnd.Next(1, 15));
            width = new Line(height);

            A = new Dote(width, height);
            B = new Dote(height, width);
            C = new Dote(width, height);
            D = new Dote(height, width);
        }

        public override void Display()
        {
            Console.WriteLine("This is an square");
            Console.WriteLine("All sides are {0} cm.", this.height.Length);
            base.Display();
        }

        public override void GetArea()
        {
            Area = Math.Pow(height.Length, 2);
            base.GetArea();
        }

        public override void GetCoordinates()
        {
            A.Point = new Point(0, 0);
            B.Point = new Point(height.Length, 0);
            C.Point = new Point(height.Length, width.Length);
            D.Point = new Point(0, width.Length);
            base.GetCoordinates();
        }

        public override void GetPerimetr()
        {
            Perimetr = 4 * height.Length;
            base.GetPerimetr();
        }
    }
}
