namespace ElementAt
{
    public class ElementAtOrDefault
    {
        public static void Run()
        {
            List<int> item = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int elem = item.ElementAtOrDefault(10);
            Console.WriteLine(elem);
        }
    }
}
