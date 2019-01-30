using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape
{
    class Program
    {
        static void Main(string[] args)
        {
            Shapes[] namesArr = { Shapes.Circle, Shapes.EqualTriangle, Shapes.IsoscelesTriangle, Shapes.Rectangle, Shapes.RigthTriangle, Shapes.Square };
            ShapeGenerator generator;
            foreach(Shapes sh in namesArr)
            {
                generator = new ShapeGenerator(sh);
                generator.Display();
            }

            //Delay
            Console.ReadKey();
        }
    }

    enum Shapes
    {
        Circle,
        EqualTriangle,
        IsoscelesTriangle,
        Rectangle,
        RigthTriangle,
        Square
    }
}
