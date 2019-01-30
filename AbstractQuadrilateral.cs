using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shape.ShapeComponents;

namespace Shape
{
    abstract class AbstractQuadrilateral : IShape
    {
        protected Random rnd = new Random();
        protected Line height;
        protected Line width;

        internal Dote A;
        internal Dote B;
        internal Dote C;
        internal Dote D;

        protected double Area { get; set; }
        protected double Perimetr { get; set; }

        public virtual void Display()
        {
            GetArea();
            GetPerimetr();
            GetCoordinates();
        }

        public virtual void GetCoordinates()
        {
            Console.WriteLine("The shape has 4 vertices with the following coordinates:\nA:{0:#.##}\nB:{1:#.##}\nC:{2:#.##}\nD:{3:#.##}", A.Point.ToString(), B.Point.ToString(), C.Point.ToString(), D.Point.ToString());
        }
            
        public virtual void GetArea()
        {
            Console.WriteLine("Area:{0}", this.Area);
        }
        public virtual void GetPerimetr()
        {
            Console.WriteLine("Perimetr:{0}", this.Perimetr);
        }
    }
}
