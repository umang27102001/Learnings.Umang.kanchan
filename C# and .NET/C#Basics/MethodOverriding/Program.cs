namespace MethodOverriding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            OverRidingBaseClass obj1 = new OverRidingBaseClass();
            OverRidingBaseClass obj2 = new ChildClass();
            ChildClass obj3 = new ChildClass();
            OverRidingBaseClass obj4 = new GrandChildClass();
            ChildClass obj5 = new ChildClass();
            ChildClass obj6 = new GrandChildClass();
            GrandChildClass obj7 = new GrandChildClass();
            obj1.Print();
            obj2.Print(); // Child Override
            obj3.Print(); // Child Override
            obj4.Print(); // 
            obj5.Print(); // Child Override
            obj6.Print(); // Child Override
            obj7.Print(); //GrandChild
        }
    }
}
