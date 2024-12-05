namespace AnonymousMethods;

internal class Program
{
    static void Main(string[] args)
    {
        Delegates amn = new Delegates();
        amn.Test((name)=>
        {
            Console.WriteLine(name + " Kanchan");
        }, "umang");

    }
}
