namespace Max
{
    public class Program
    {
        static void Main(string[] args)
        {
            int maxSalary = Employee.GetAllEmployees().Max(e=>e.Salary);
            int itMaxSalary = Employee.GetAllEmployees().Max(e =>
            {
                if (e.Department == "IT")
                {
                    return e.Salary;
                }
                return 0;
            });
            Console.WriteLine(maxSalary);
        }
    }
}
