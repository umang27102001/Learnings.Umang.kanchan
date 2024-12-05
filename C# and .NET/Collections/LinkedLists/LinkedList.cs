using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedLists
{
    public class LinkedList
    {
        public void Run()
        {
            LinkedList<string> ll = new();
            ll.AddFirst("umang");
            ll.AddFirst("kanchan");
            ll.AddFirst("Shalu");
            ll.AddFirst("Rawat");
            ll.AddFirst("Ashish");
            ll.AddLast("Sinha");
            ll.Remove("Rawat");
            ll.RemoveFirst();
            
            Console.WriteLine(ll);
            ll.AddBefore(ll.Find("Shalu").Next, "Lokesh");
           ll.
            IEnumerator<string>it=ll.GetEnumerator();
            while (it.MoveNext()) { Console.Write(it.Current+" "); }
        }
    }
}
