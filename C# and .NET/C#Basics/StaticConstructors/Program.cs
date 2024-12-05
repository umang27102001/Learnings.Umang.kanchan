namespace StaticConstructors
{
    public class Program
    {
        static void Main(string[] args)
        {

            StaticBase sc = new StaticBase("Black");
            Console.WriteLine("\n");

            StaticChild scd = new StaticChild();
            Console.WriteLine(StaticChild.s_name);
        }
    }
}
