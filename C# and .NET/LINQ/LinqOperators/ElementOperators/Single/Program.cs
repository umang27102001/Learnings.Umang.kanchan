namespace Single
{
    public class Program
    {
        static void Main(string[] args)
        {
            //List<int> ls = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            //int item = ls.Single(e => e == 1);
            ////exceptions
            ////More than one elements matched
            ////item = ls.Single(e=>e%2==0);
            ////Empty List
            ////ls=new List<int>();
            ////item = ls.Single();
            ////More than one elements
            ////item = ls.SingleOrDefault();
            //item = ls.SingleOrDefault(e=>e==1);
            //Console.WriteLine(item);
            ITemp temp = new ITemp(3);
            Temp x = (Temp)temp; 
            Console.WriteLine(x.a);
        }
    }
}
