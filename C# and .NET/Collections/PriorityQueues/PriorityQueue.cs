using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PriorityQueues
{
    
    public class PriorityQueue
    {
        public void Run()
        {
            PriorityQueue<string, int> pq = new();
            pq.Enqueue("Umang",1);
            pq.Enqueue("Shalu",2);
            pq.Enqueue("Tarun",3);
            pq.Enqueue("Rohan",3);
            pq.Enqueue("Mahak",4);
            string Element; int Priority;
            while (pq.TryDequeue(out Element,out Priority))
            {
                Console.WriteLine(Element+" "+Priority);
            }
        }
    }
}
