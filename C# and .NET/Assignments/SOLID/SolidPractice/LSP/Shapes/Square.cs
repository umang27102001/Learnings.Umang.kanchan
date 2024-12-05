using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPractice.LSP.Shapes
{
    internal class Square:IShapes
    {
        public  int side { get; set; }
        public int CalculateArea()
        {
            return side * side;
        }
    }
}
