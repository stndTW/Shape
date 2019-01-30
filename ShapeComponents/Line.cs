using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape.ShapeComponents
{
    class Line : IShapeComponents
    {
        protected double _length;
        public double Length { get { return _length; } }

        public Line(double length)
        {
            _length = length;
        }
        
        public Line(Line line)
        {
            this._length = line._length;
        }
    }
}
