using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionaries;

public class Comparer : IComparer<string>
{
    public int Compare(string s,string t)
    {
        return t.CompareTo(s);
    }
}
public class SortedDictionary
{
    public void Run()
    {
        SortedDictionary<string,int>dict= new(new Comparer());

        dict.TryAdd("Umang",3);
        dict.TryAdd("Shalu",4);
        dict.TryAdd("Rohit",6);
        dict.TryAdd("Mohan",1);
        dict.TryAdd("Mansi",8);
        int val;
        bool flag = dict.TryGetValue("Mohn",out val);
        Console.WriteLine(flag+" "+val);
        
    }
}
