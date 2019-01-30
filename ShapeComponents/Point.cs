using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape.ShapeComponents
{
    class Point
    {
        public double X { get; set; }
        public double Y { get; set; }

        public Point(double x, double y)
        {
            X = x;
            Y = y;
        }

        public override string ToString()
        {
            if (X < 1 || Y<1)
            {
                return string.Format("X:{0} | Y:{1}", this.X, this.Y);
            }
            return string.Format("X:{0:##.##} | Y:{1:##.##}", this.X, this.Y);
        }
    }
}
