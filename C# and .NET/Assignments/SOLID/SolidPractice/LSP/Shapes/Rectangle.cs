using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPractice.LSP.Shapes
{ 
    internal class Rectangle:IShapes
    {
        public int height {  get; set; }
        public  int width { get; set; }
        public  int CalculateArea()
        {
            return height * width;
        }
    }
}
