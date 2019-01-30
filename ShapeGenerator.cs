using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape
{
    class ShapeGenerator
    {
        dynamic shape;
        public ShapeGenerator(Shapes sh)
        {
            string name = GetType().Namespace + "." + sh;
            shape = Activator.CreateInstance(Type.GetType(name));
        }

        public void Display()
        {
            Console.WriteLine(new string('-', 50));
            shape.Display();
            Console.WriteLine(new string('-', 50));
        }
    }
}
