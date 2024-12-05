namespace StaticConstructors
{

    public class StaticChild : StaticBase
    {
        static StaticChild()
        {
            Console.WriteLine("StaticChild1!!");
            s_name = "Varun Saxena";
            Console.WriteLine("StaticChild3!!");
        }
        public StaticChild() : base()
        {
            marks = 10;
            Console.WriteLine("Default StaticChild {0}", s_name);
        }
        public StaticChild(string n) : base(n)
        {
            Console.WriteLine("Params StaticChild");
        }
    }
}