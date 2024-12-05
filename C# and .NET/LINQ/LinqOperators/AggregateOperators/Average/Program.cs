namespace Average
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
            double evenAv = list.Average(e =>
            {
                if (e % 2 == 0)
                {
                    return e;
                }
                return 0;
            });
            Console.WriteLine(evenAv);

        }
    }
}
