namespace DependencyInjection
{
    public class Square : IShape
    {
        public void PrintArea()
        {
            Console.WriteLine("Area = side*side");
        }
    }
}
