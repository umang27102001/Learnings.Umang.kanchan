using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPractice.OCP.Product
{
    internal class ElectronicsTax : ITaxCalculator
    {
        public double CalculateTax(Product product)
        {
            return product.Price * 0.15;
        }
    }
}
