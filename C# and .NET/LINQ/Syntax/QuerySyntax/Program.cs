namespace QuerySyntax
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            var query = from c in list
                        where c % 2 == 1
                        select c * 3;
            list.Add(12);
            list.Add(13);
            foreach (var item in query)
            {
                Console.Write(item + " ");
            }
            Console.ReadKey();
        }
    }
}
