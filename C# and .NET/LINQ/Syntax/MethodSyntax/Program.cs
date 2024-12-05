namespace MethodSyntax
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            var immediateQuery = list.Where(c => c % 2 == 0).Select(c =>c*5).ToList();
            var delayedQuery = list.Where(c => c % 2 == 1).Select(c => c * 5);
            list.Add(12);
            list.Add(13);
            foreach(var item in immediateQuery)
            {
                Console.Write(item+" ");
            }
            Console.WriteLine("\n");
            foreach(var item in delayedQuery)
            {
                Console.Write(item+" ");
            }
            Console.ReadKey();
        }
    }
}
