using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Single
{
    internal class Temp:ITemp
    {
        public Temp():base(5)
        {
            a = 10;
        }
       public new static int sum()
        {
            return 3;
        }
        public void temp()
        {
            Console.WriteLine("No hello");
        }
        public int Print()
        {
            return 5;
        }
    }
}
