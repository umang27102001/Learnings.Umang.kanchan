using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List
{
    public class ArrayLists
    {
        public void Run()
        {
            ArrayList Al = new ArrayList() { 1, 2, "umang", true };
            foreach(var val in Al)
            {
                Console.Write(val+" ");
            }
                                    
        }
    }
}
