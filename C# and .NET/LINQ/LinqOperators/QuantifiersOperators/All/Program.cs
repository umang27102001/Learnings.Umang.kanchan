namespace All
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 11, 13, 15 };
            bool isPositive = list.All(e=>e>0);
            bool isEven = list.All(e => e % 2 == 0);
            Console.WriteLine($"{isPositive} {isEven}");
        }
    }
}
