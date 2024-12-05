using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionaries
{
    public class Dictionary
    {
        public void Temp(Dictionary<int, int> mp)
        {
            mp.Add(1,0);
        }
        public void Run()
        {
            Dictionary<int, int> mp = new Dictionary<int, int>();
            mp.Add(1, 9);
            //mp.Add(1, 0); //This will throw ArgumentException as we are trying to add a key which already exists.
            //mp.TryAdd(1, 0); // TryAdd does not throw any Argument but will not add this <k,v> as the key already exists and returns false
            //mp[1] = 0; // USing Indexers, we can update the value of a key .
            mp[0] = 1;
            //Console.WriteLine(mp[3]);// This will throw the KeyNotFoundException as the <3,v> does not exist in mp.
            //To fix this, use GetValueOrDefault(key,DefaultValue);
            //Console.WriteLine(mp.GetValueOrDefault(5,0));
            //Console.WriteLine(mp.ContainsKey(6));
            if (!mp.ContainsKey(1))
            {
                mp.Add(1, 0);
            }
            else
            {
                Console.WriteLine("Key already present!");
            }
            mp[0] = 1;
            mp[4] = 5;
            int val;
            mp.TryGetValue(1, out val);
           var d2=new Dictionary<int, int>(mp);
            foreach(var item in d2) Console.Write(item.Key+" "+item.Value);
        }
    }
}
