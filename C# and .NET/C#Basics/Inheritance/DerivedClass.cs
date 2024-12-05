namespace Inheritance
{
    public class DerivedClass : BaseClass
    {
        public DerivedClass() : base()
        {
            Console.WriteLine("Inside DerivedClass");
        }
        public void Print()
        {
            base._money = 10;
            Console.WriteLine(base._money);
        }

    }
}
