using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Distinct
{
    public class Box
    {
        public int len {  get; set; }
        public int bred { get; set; }
        public string ToString()
        {
            return len + " " + bred;
        }
        public override bool Equals(object? obj)

        {
            Box other = obj as Box;
            return other.len==len&&other.bred==bred;
        }
        public override int GetHashCode()
        {
            return (len^bred).GetHashCode();
        }
    }
}
