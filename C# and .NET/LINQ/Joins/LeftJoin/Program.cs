namespace LeftJoin
{
    public class Program
    {
        static void Main(string[] args)
        {
            var employees = Employee.GetAllEmployees();
            var dept = Department.GetAllDepartments();
            var items = dept.GroupJoin(employees, d => d.ID, e => e.DepartmentId, (d, e) => new
            {
                d,
                e,
            }).SelectMany(e => e.e.DefaultIfEmpty(), (a, b) => new
            {
                a.d,
                b
            }) ;
            foreach(var item in items)
            {
                if (item.b == null)
                {
                    Console.WriteLine($"{ item.d.Name} null");
                }
                else Console.WriteLine($"{item.d.Name} {item.b.Name}");
            }
        }
    }
}
