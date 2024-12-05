namespace Count
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] intNumbers = new int[] { 60, 80, 50, 90, 10, 30, 70, 40, 20, 100 };
            //Using Method Syntax
            int MSCount = intNumbers.Count(e =>
            {
                if (e % 3 == 0)
                {
                    return true;
                }
                return false;
            });
            Console.WriteLine(MSCount);
        }
    }
}
