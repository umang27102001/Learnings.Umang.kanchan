namespace DockerAssignment
{
    internal class Program
    {
        delegate int Func(int a, int b);
        static void Main(string[] args)
        {
           Func fun = (a,b)=> a + b;
            Console.WriteLine(fun(4,5));

        }
    }
}
