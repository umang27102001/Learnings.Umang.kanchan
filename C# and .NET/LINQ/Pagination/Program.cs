namespace Pagination
{
    using System;
    using System.Threading;
    public class Program
    {
        static void Temp()
        {
            Thread.Sleep(5000);
            Console.WriteLine("@");
        }
        static async void Print()
        {
            Console.WriteLine("First");
            await Task.Run(()=>Temp());
            Console.WriteLine("Hello");
        }
        public static void Main(string[] args)
        {
            //int pageNumber;
            //int employeePerPage = 4;
            //Console.WriteLine("Enter the page Number!");
            //int.TryParse(Console.ReadLine(), out pageNumber);
            //if (pageNumber > 0 && pageNumber < 5)
            //{
            //    var emp = Employee.GetAllEmployees().Take(pageNumber * employeePerPage).Skip((pageNumber - 1) * employeePerPage);
            //    foreach (var employee in emp)
            //    {
            //        Console.WriteLine(employee.Name);
            //    }
            //}
            Print();
        }
    }
}
