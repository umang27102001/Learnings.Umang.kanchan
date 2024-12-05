
namespace SealedClass
{
    public class SealedClass
    {
       
        public class A
        {
            public A()
            {
                Console.WriteLine("Default!!");
            }
            public A(byte a) {
                Console.WriteLine("Params");
            }
            public void Print()
            {
                Console.WriteLine("HEllo bharat!");
            }
        }
        public class B:A
        {
            public B(byte a):base(a)
            {
                Console.WriteLine("Hillo");
            }
            public B():this(9)
            {
                Console.WriteLine("B");
            }
            public virtual void Print()
            {
                Console.WriteLine("Overridden");
            } 
        }
        public class C : B
        {
            public sealed override void Print()
            {
                Console.WriteLine("C");
            }
        }
        public class D : C
        {
            public new void Print()
            {
                Console.WriteLine("D");
            }

        }
        public void Show()
        {
            A b = new D();
            b.Print();
        }
    }
}
