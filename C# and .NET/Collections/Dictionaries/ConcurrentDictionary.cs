using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionaries
{
    public class ConcurrentDictionary
    {
        public void Run()
        {
            var mp = new ConcurrentDictionary<int, string>();
            //A concurrent Dictionary Represents a Thread safe collection of key value pairs that can be accessed
            //by multiple threads concurrently.

            mp.TryAdd(1, "Umang");
            mp.TryAdd(2, "Shalu");
            mp.TryAdd(3, "Jitu");
            mp.TryAdd(4, "Ashutosh");
            mp.TryAdd(5, "Harsh");
            bool Output=mp.TryUpdate(5,"Rohan","Harsh");
            IEnumerator<KeyValuePair<int, string>> it = mp.GetEnumerator();
            while(it.MoveNext()) { Console.WriteLine(it.Current.Key+" "+it.Current.Value+" "+Output); }

        }
    }
}
