namespace Typecasting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //BaseClass a = new BaseClass();
            //a.MethodA();
            //DerivedClass b = new DerivedClass();
            //b.MethodA();
            //BaseClass a1 = new DerivedClass();
            //a1.MethodA();
            //DerivedClass b1 = new BaseClass();
            //b1.MethodA();
            //BaseClass a2 = (BaseClass)new DerivedClass();
            //a2.MethodA();
            BaseClass b2 = (DerivedClass)new BaseClass();
            //b2.MethodA();
        }
    }
}
