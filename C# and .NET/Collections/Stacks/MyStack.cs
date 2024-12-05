using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stacks
{
    public class MyStack
    {
        public void Run()
        {
            Stack<string> st = new();
            st.Push("Umang");
            st.Push("Kanchan");
            st.Push("AM");
            string SPeek;
            st.TryPeek(out SPeek);
            string SPop;
            
            while(st.TryPop(out SPop))
            {
                Console.WriteLine(SPop);
            }
            
        }
    }
}

