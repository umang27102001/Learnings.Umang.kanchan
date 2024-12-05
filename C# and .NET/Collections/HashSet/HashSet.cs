using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashSets;

public class Box
{
    public int Len { get; set; }
    public int Bred { get; set; }
    
}
public class Equality : EqualityComparer<Box>
{
    public override bool Equals(Box? x, Box? y)
    {
        return x.Len == y.Len && x.Bred == y.Bred;
    }
    public override int GetHashCode(Box box)
    {
        return (box.Len ^ box.Bred).GetHashCode();
    }
}
public class HashSet
{
    public void Run()
    {
        HashSet<Box> Set = new HashSet<Box>(new Equality());
        HashSet<Box> NewSet = new HashSet<Box>(new Equality());
        NewSet.Add(new Box { Len = 4, Bred=5});
        NewSet.Add(new Box { Len = 3, Bred=4});
        NewSet.Add(new Box { Len = 9, Bred=4});
        Set.Add(new Box { Len = 3, Bred = 4 });
        Set.Add(new Box { Len = 3, Bred = 4 });
        foreach (var item in NewSet) Console.WriteLine(item.Len+" "+item.Bred);
        Console.WriteLine(Set.Add(new Box { Len = 4, Bred = 8 }));
        

    }
}
