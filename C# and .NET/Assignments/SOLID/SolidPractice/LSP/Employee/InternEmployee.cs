using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPractice.LSP.Employee
{
    public class InternEmployee : IEmployee
    {
        public double Salary { get; set; }
        public double CalculateBonus()
        {
            return Salary * 0.9;
        }
    }
}
