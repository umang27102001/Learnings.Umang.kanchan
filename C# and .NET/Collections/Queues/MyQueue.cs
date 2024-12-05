using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queues;
public class MyQueue
{
    public void Run()
    {
        Queue<string>q=new Queue<string>();
        q.Enqueue("Umang Kanchan");
        q.Enqueue("Shalu Rawat");
        q.Enqueue("Ashutosh Jangid");
        q.Enqueue("Jitu Soni");
        IEnumerator<string> it = q.GetEnumerator();
        while (it.MoveNext())
        {
            Console.WriteLine(it.Current);
        }
    }
}
