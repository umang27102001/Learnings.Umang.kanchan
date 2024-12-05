using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Typecasting
{
    public class DerivedClass : BaseClass
    {
        override public void MethodA()
        {
            Console.WriteLine("Derive Class Overridden MethodA");
        }
    }
}
