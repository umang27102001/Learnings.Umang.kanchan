namespace Aggregate
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<String> ls = new List<string> { "Umang","Kanchan","is","innocent"};
            List<int> numList = new List<int> { 1, 2, 3, 4, 5, 66, 7, 8 };
            string str = ls.Aggregate((a,b)=>a+" "+b);
            int sum = numList.Aggregate((a,b)=>a+b);
            Console.WriteLine(sum);
        }
    }
}
