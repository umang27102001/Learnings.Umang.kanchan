namespace GroupJoin
{
    public class Program
    {
        static void Main(string[] args)
        {
            var employees = Employee.GetAllEmployees();
            var departments = Department.GetAllDepartments();
           
            var groupJoined = departments.GroupJoin(employees, d => d.ID, e => e.DepartmentId, (d, e) => new
            {
                dept=d, 
                emp= e
            });
            foreach (var employee in groupJoined)
            {
                Console.WriteLine($"Department {employee.dept.Name}");
                foreach(var  employeess in employee.emp)
                {
                    Console.WriteLine(employeess.ID + " "+employeess.Name);
                }
            }
        }
    }
}
