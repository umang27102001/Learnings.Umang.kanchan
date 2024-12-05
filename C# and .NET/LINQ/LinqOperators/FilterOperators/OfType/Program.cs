namespace OfType
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<object> dataSource = new List<object>()
            {
                "Tom", "Mary", 50, "Prince", "Jack", 10, 20, 30, 40, "James"
            };
            
            var strData=dataSource.OfType<string>().ToList();
       
            foreach (string number in strData)
            {
                Console.Write(number + " ");
            }
            Console.ReadKey();
        }
    }
}
