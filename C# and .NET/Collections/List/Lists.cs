using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection.List;

public class Comparer : IComparer<string>
{
    string Str = "qwertyuiopasdfghjklzxcvbnm";
    string STR = "QWERTYUIOPASDFGHJKLZXCVBNM";
    public int Compare(string x, string y)
    {
        if (Str.Contains(x[0]))
        {
            if (STR.Contains(y[0]))
            {
                return -1;
            }
            else return x.CompareTo(y);    
        }
        else 
        { 
            if (Str.Contains(y[0]))
            {
                return 1;
            }
            else return x.CompareTo(y);

        }
    }
}
public class Galaxy : IComparable<Galaxy> 
{
    public string Name { get; set; }
    public int MegaLightYears { get; set; }
    public int CompareTo(Galaxy obj)
    {
        return this.MegaLightYears-obj.MegaLightYears;
    }
}
public class Lists
{
    public void PrintList(List<int> ls)
    {
        foreach(var val in ls)
        {
            Console.Write(val+" ");
        }
    }
    public void Print()
    {
        # region Task is to group strings starting with small and large alphabet together, for two strings in a group, maintain lexicographic order.
        //List<string> list = [ "Vipul", "Mohit","Aseem","kavita","Ashutosh","Jitendra","shalu","umang","harsh" ];
        //list.Sort(new Comparer());
        //foreach(var g in list)
        //{
        //    Console.Write($"{g} ");
        //}
        #endregion
        var NumList = new List<int>() { 1,2,3,4,5,6,7,8,9,0};
        NumList.Remove(3);
        NumList.RemoveAt(3);
        var Galaxies = new List<Galaxy>()
        {
            new (){ Name="Tadpole", MegaLightYears=400},
            new (){ Name="Pinwheel", MegaLightYears=25},
            new (){ Name="Milky Way", MegaLightYears=0},
            new (){ Name="Andromeda", MegaLightYears=3}
        };
        Galaxies.Sort();
        foreach (var cal in Galaxies)
        {
            Console.Write(cal.Name+" ");
        }
    }
}
