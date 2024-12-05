namespace Sum
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 8, 9 };
            int sum = list.Sum();
            int evenSum = list.Sum(e =>
            {
                if (e % 2 == 0)
                {
                    return e;
                }
                return 0;
            });
            List<int?> l2 = new List<int?>() { 1, 2, 3, 4, null, 9 };
            int nullSum = l2.Sum().GetValueOrDefault();
            Console.WriteLine(nullSum);

            var employees = Employee.GetAllEmployees();
            int empSum = employees.Sum(e=>e.Salary);

            int itSum = Employee.GetAllEmployees().Sum(e =>
            {
                if (e.Department == "IT")
                {
                    return e.Salary;
                }
                return 0;
            });
            Console.WriteLine(itSum);

        }
    }
}
