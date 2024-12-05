namespace AnonymousMethods
{
    internal class Delegates
    {
        public delegate void Print(string name);
        public void Hello()
        {
            var MyName = "Tarun";
            Print p = delegate (string name)
            {
                Console.WriteLine(MyName+" "+name);
            };

            p("umang");
            Console.WriteLine(p);
        }
        public void Test(Print func,string name)
        {
            func(name);
        }
    }
}
