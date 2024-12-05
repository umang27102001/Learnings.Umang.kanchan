using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortedList;

public class Comparer : IComparer<int>
{
    public int Compare(int a,int b)
    {
        return b - a;
    }
}
public class SortedList
{
    public void Run()
    {
        SortedList<int, int> sorted = new SortedList<int, int>(new Comparer());
        sorted.Add(1,0);
        sorted.Add(2,1);
        sorted.Add(3,2);
        sorted.Add(4,3);
        IEnumerable<int> it = sorted.Keys;
        foreach(int val in it) 
        {
            Console.WriteLine(val+" " + sorted[val]);
        }
    }
}
