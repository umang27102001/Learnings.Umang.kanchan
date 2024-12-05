using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.Solution
{
    /*Answer: Here we can create a contract Ishape, now every shape has its own implementation 
     * of CalculateArea() which is not affected by others, addition of any new shape will not affect 
     * the existing system as it will have its own implementation of CalculateArea().*/
    public interface IShape
    {
        public double CalculateArea();
    }
    public class Rectangle : IShape
    {
        public double Height { get; set; }
        public double Width { get; set; }
        public double CalculateArea()
        {
            return Height * Width;
        }
    }

    public class Circle : IShape
    {
        public double Radius { get; set; }

        public double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }
    }
    public class Triangle : IShape
    {
        public double Base { get; set; }
        public double Height { get; set; }

        public double CalculateArea()
        {
            return 0.5 * Base * Height;
        }
    }

    public class AreaCalculator
    {
        public double CalculateTotalArea(IShape obj)
        {
            double area = obj.CalculateArea();
            return area;
        }
    }
}
