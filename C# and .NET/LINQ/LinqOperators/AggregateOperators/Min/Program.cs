namespace Min
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>() { 1, 2, 3, 4, 5, 56, 6, 67, 7, 8, 9, 9 };
            int mini = list.Min();
            int? miniSalesSalary = Employee.GetAllEmployees().Min(e =>
            {
                if (e.Department == "Sales")
                {
                    return e.Salary;
                }
                return null;
            });
            Console.WriteLine(miniSalesSalary);
        }
    }
}
