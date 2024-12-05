namespace Last
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> ls = new List<int>() { 1, 2, 3, 4, 7 };
            //InvalidOperationException:
            //int item = ls.Last(e=>e*2==11);
            int def1 = ls.LastOrDefault();
            int def2 = ls.LastOrDefault(e => e % 5 == 0);
            Console.WriteLine(def2);
        }
    }
}
