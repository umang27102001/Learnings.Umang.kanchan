namespace MixedSyntax
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            var immediateQuery = (from c in list
                                  where c % 2 == 1
                                  select c).ToList();
            var delayedQuery = from c in list
                               where c % 2 == 0
                               select c;
            list.Add(12);
            list.Add(13);
            foreach (var item in immediateQuery)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine("\n");
            foreach (var item in delayedQuery)
            {
                Console.Write(item + " ");
            }
            Console.ReadKey();
        }
    }
}
