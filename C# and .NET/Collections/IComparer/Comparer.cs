using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IComparer
{
    public class Comparer:IComparer<Car>
    {
        public int Compare(Car b1,Car b2)
        {
            return b2.Price-b1.Price;
        }
    }
}
