

namespace SingletonClass
{
    public class Program
    {
        static void Main(string[] args)
        {
            Singleton sc = Singleton.CreateObj("Umang kanchan");
            Singleton dc = Singleton.CreateObj("Mathur Bhai!!");
            Console.WriteLine(dc.Name);
        }
    }
}
