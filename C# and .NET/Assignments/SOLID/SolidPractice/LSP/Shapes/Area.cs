using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPractice.LSP.Shapes
{
    internal class Area
    {
        private readonly IShapes _shape;
        public Area(IShapes shape)
        {
            _shape = shape;
        }
        public int FindArea()
        {
            return _shape.CalculateArea();
        }
    }
}
