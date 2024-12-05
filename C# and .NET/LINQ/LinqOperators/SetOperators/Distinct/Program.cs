namespace Distinct
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Box> intCollection = new List<Box>()
            {
               new Box {len=3,bred=4},
               new Box {len=3,bred=4},
               new Box {len=4,bred=5},
               new Box {len=3,bred=7},
            };
         
            var MS = intCollection.Distinct();
         
            var QS = (from num in intCollection
                      select num).Distinct();
            foreach (var item in MS)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}
