using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.Question
{
    /* QUESTION:
     * How do we add another shape (say Triangle) and not break OCP in AreaCalculator class? Try refactoring the shape classes by adding appropriate interface or abstract class. You can also come up with different implementation to calculate Area of these shapes.
     * Answer: The code below does not follow OCP as addition of any new functionality to the code will lead to modification of Areacalculator class
     * Solution to this problem is given in OSoln.cs file.
    
     */
    public class Rectangle
    {
        public double Height { get; set; }
        public double Width { get; set; }
    }

    public class Circle
    {
        public double Radius { get; set; }
    }

    public class AreaCalculator
    {
        private readonly Rectangle rectangle;
        private readonly Circle circle;
        public AreaCalculator(Rectangle rectangle, Circle circle)
        {
            this.rectangle = rectangle;
            this.circle = circle;
        }
        public double CalculateTotalArea(object obj)
        {
            double area;
            if (obj is Rectangle)
            {
                area = rectangle.Height * rectangle.Width;
            }
            else
            {
                area = circle.Radius * circle.Radius * Math.PI;
            }
            return area;
        }
    }
}
