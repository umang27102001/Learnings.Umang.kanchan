namespace Overloading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var ovl = new MethodOverLoading();
            ovl.Print(y: 5, z: 6, x: 0);
            ovl.Print(4, 4);
        }
    }
}
