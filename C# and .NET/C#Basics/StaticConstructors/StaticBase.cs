namespace StaticConstructors
{
    public class StaticBase
    {
        public static string s_name;
        protected int marks;
        static StaticBase()
        {
            Console.WriteLine("Static Base1");
            s_name = "Umang Kanchan!!";
            Console.WriteLine("Static Base2");
        }
        public StaticBase()
        {
            Console.WriteLine("Default StaticBase");
        }
        public StaticBase(string n)
        {
            s_name = n;
            Console.WriteLine("Params StaticBase");
        }
    }

}
