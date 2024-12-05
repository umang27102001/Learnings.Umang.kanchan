using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Basics.Inheritance
{
    internal class DerivedClass : BaseClass
    {
        public DerivedClass() : base()
        {
            Console.WriteLine("Inside DerivedClass");
        }
        public void Print()
        {
            base._money = 10;
            Console.WriteLine(base._money);
        }

    }
}
