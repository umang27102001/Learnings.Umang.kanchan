using System.Linq;

namespace FullJoin
{
    public class Program
    {
        static void Main(string[] args)
        {
            var emp = Employee.GetAllEmployees();
            var dept = Department.GetAllDepartments();
            var itemLeft = emp.GroupJoin(dept, e => e.DepartmentId, d => d.ID, (e, d) => new
            {
                emp=e,
                dept=d,
            }).SelectMany(e=>e.dept.DefaultIfEmpty(),(emp,dept)=>new
            {
                EmployeeId=emp?.emp?.ID,
                EmployeName=emp?.emp?.Name,
                DepartmentId = dept?.ID
            });
            var itemRight = dept.GroupJoin(emp, d => d.ID, e => e.DepartmentId, (d, e) => new
            {
                dept=d,
                emp=e
            }).SelectMany(e => e.emp.DefaultIfEmpty(), (d, e) => new
            {
                EmployeeId = e?.ID,
                EmployeName = e?.Name,
                DepartmentId = d?.dept?.ID
            });
            var result = itemLeft.Union(itemRight);
            foreach(var item in result)
            {
                Console.WriteLine($"{item.EmployeeId} {item.EmployeName} {item.DepartmentId}");
            }
        }
    }
}
