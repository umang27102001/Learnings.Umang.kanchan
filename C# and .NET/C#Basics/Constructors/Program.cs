
namespace Constructors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Constructor cs = new Constructor("umang");
            Constructor ds = new Constructor(cs);
            Console.WriteLine(ds.GetName());
        }
    }
}
