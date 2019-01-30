using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shape.ShapeComponents;

namespace Shape
{
    class Rectangle : AbstractQuadrilateral
    {
        public Rectangle()
        {
            height = new Line(rnd.Next(1, 15));
            width = new Line(rnd.Next(1,15));

            A = new Dote(width, height);
            B = new Dote(height, width);
            C = new Dote(width, height);
            D = new Dote(height, width);
        }

        public override void Display()
        {
            Console.WriteLine("This is an rectangle");
            Console.WriteLine("Height: {0} cm.", this.height.Length);
            Console.WriteLine("Width: {0} cm.", this.height.Length);
            base.Display();
        }

        public override void GetArea()
        {
            Area = height.Length * width.Length;
            base.GetArea();
        }

        public override void GetCoordinates()
        {
            A.Point = new Point(0, 0);
            B.Point = new Point(height.Length, 0);
            C.Point = new Point(width.Length, height.Length);
            D.Point = new Point(0, width.Length);
            base.GetCoordinates();
        }

        public override void GetPerimetr()
        {
            Perimetr = 2*(width.Length + height.Length);
            base.GetPerimetr();
        }
    }
}
