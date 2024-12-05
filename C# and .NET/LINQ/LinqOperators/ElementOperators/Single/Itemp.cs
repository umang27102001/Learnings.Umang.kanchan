using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Single
{
    public class ITemp
    {
        public int a {  get; set; }

        public ITemp(int a)
        {
            this.a = a;
        }
        public static int sum()
        {
            return 5;
        }
        public void temp()
        {
            Console.WriteLine("Hello");
        }
        public virtual int Print()
        {
            return 4;
        }

    }
}
