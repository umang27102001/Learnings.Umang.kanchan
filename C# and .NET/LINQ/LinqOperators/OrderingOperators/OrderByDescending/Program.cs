namespace OrderByDecreasing
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>() { 6, 4, 3, 8, 9, 1, 0, 11, 21, 15 };
            var newList = list.OrderByDescending(e => e);
        }
    }
}
