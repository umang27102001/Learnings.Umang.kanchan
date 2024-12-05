using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queues
{
    internal class ConcurrentQueue
    {
        public void Run()
        {
            ConcurrentQueue<string> Cq = new();
            Cq.Enqueue("Umang Kanchan");
            Cq.Enqueue("Shalu Rawat");
            Cq.Enqueue("Ashutosh Jangid");
            Cq.Enqueue("Jitu Soni");
            string deq;
            Cq.TryDequeue(out deq);
            string result;
            Cq.TryPeek(out result);
            ConcurrentQueue<string> Cq2 = new ();
            Cq2.Enqueue("Tarun Sharma");
            Cq2.Enqueue("Rohan Dan");
            Cq2.Enqueue("Rahul Singh");
            string NewTemp;
            Cq2.TryPeek(out NewTemp);
            Console.WriteLine(Cq.ToString());
            
        }
    }
}
