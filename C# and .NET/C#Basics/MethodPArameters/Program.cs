namespace MethodPArameters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MethodParameters mp = new MethodParameters();
            mp.NamedParams(c: 6, a: 4, b: 9);
            byte a = 10, b = 20;
            Console.WriteLine(a + " " + b);
            mp.RefParams(ref a, ref b);
            Console.WriteLine(a + " " + b);
            mp.OutParams(out a);
            Console.WriteLine(a);
            mp.DynamicParams(true);
            mp.ParamsParams(1, 2, 3, 6, "umang", true);
            var A = 10;
            Console.WriteLine(A.GetType());
        }
    }
}
