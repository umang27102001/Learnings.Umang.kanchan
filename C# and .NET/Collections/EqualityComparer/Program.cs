using System.Text;

namespace EqualityComparer;
internal class Program
{
    static void Main(string[] args)
    {
        HashSet<Box> set = new HashSet<Box>(new Equality()) { 
            new Box { Len = 3, Bred = 5 },
            new Box { Len =5, Bred = 7 },
            new Box { Len = 6, Bred=9},
            new Box { Len = 6, Bred=9},
        };
        IEnumerator<Box> it = set.GetEnumerator();
        while (it.MoveNext())
        {
            Console.WriteLine(it.Current.Len+" "+it.Current.Bred);
        }
        string str1 = "umang";
        string str2 = new string(str1);
        string str3 = String.Intern(str2);
        Console.WriteLine(Object.ReferenceEquals(str3,str2));
    }
}
