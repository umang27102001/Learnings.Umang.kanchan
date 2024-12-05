using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Distinct
{
    public class Equality:IEqualityComparer<Box>
    {
        public bool Equals(Box x, Box y)
        {
            return x.len == y.len&&y.len==x.len;
        }
        public int GetHashCode(Box obj)
        {
            return (obj.len^obj.bred).GetHashCode();
        }
    }
}
