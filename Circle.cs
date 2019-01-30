using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shape.ShapeComponents;

namespace Shape
{
    class Circle : IShape
    {
        //Создано 2 радиуса для передачи в Dote, а так они эквивалентны 
        Line Radius1;
        Line Radius2;
        Dote Center;
        Random rnd = new Random();

        public Circle()
        {
            Radius1 = new Line(rnd.Next(1, 25));
            Radius2 = new Line(Radius1);
            Center = new Dote(Radius1, Radius2);
        }

        public void Display()
        {
            Console.WriteLine("This is circle");
            Console.WriteLine("Circle radius:" + Radius1.Length + "cm.");
            GetArea();
            GetPerimetr();
            GetCoordinates();
        }

        public void GetArea()
        {
            Console.WriteLine("Area:{0:#.##}", (Math.PI * Math.Pow(Radius1.Length, 2)));
        }

        public void GetCoordinates()
        {
            Center.Point = new Point(Radius2.Length, Radius1.Length);
            Console.WriteLine("The shape has 1 center coordinat:" + Center.Point.ToString());
        }

        public void GetPerimetr()
        {
            Console.WriteLine("Perimetr:{0:#.##}", 2 * Math.PI * Radius1.Length);
        }
    }
}
