using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPractice.OCP.Product
{
    internal interface ITaxCalculator
    {
        public double CalculateTax(Product product);
    }
}
