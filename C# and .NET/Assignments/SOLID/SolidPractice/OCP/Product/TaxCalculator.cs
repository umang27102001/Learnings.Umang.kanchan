using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPractice.OCP.Product
{
    internal class TaxCalculator
    {
        private readonly ITaxCalculator _taxCalculator;
        public TaxCalculator(ITaxCalculator taxCalculator)
        {
            _taxCalculator = taxCalculator;
        }
        public double CalculateTax(Product product)
        {
            return _taxCalculator.CalculateTax(product);
        }
    }
}
