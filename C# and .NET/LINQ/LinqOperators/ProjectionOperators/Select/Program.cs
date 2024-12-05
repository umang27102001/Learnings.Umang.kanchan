namespace Select
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var employees1 = Employee.GetEmployees().Where(e => e.Salary > 100000).Select(e => e.ID).ToList();
            var employees2 = Employee.GetEmployees().Where(e => e.Salary >= 100000).Select((e, index) => new
            {
                Index = index,
                FirstName = e.FirstName,
                LastName = e.LastName,
                Salary = e.Salary,
            });
            List< EmployeeBasicInfo> employees3 = Employee.GetEmployees().Select(e => new EmployeeBasicInfo
            {
                FirstName = e.FirstName,
                LastName = e.LastName,
                Salary = e.Salary,
            }).ToList();
            foreach (var employee in employees2)
            {
                Console.WriteLine(employee.Index);
            }
        }
    }
}
