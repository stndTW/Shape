using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape.ShapeComponents
{
    class Dote : IShapeComponents
    {
        private Line firstLine;
        private Line secondLine;

        public Point Point { get; set; }

        public Line FirstLine { get { return firstLine; } }
        public Line SecondLine { get { return secondLine; } }

        public Dote(Line firstLine, Line secondLine)
        {
            this.firstLine = firstLine;
            this.secondLine = secondLine;
        }        
    }
}
