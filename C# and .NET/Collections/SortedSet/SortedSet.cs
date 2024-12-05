using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortedSet;

public class Comparer : IComparer<int>
{
    public int Compare(int a,int b)
    {
        return b - a; 
    }
}
public class SortedSet
{
    public void Run()
    {
        SortedSet<int> Set = new SortedSet<int>(new Comparer());
        Set.Add(1);
        Set.Add(2);
        Set.Add(1);
        Set.Add(3);
        Set.Add(4);
        Set.Add(6);
        IEnumerable<int> emu= Set.Reverse();
        IEnumerator<int>it=Set.GetEnumerator();
        while (it.MoveNext())
        {
            Console.WriteLine(it.Current);
        }
    }
}
