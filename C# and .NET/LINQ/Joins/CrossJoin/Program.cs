namespace CrossJoin
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var emp = Employee.GetAllEmployees();
            var dept = Department.GetAllDepartments();
            var items = emp.SelectMany(e=>dept,(e,d)=>new
            {
                e.Name,
                DName=d.Name
            });
            var itemss = emp.Join(dept, e => true, e => true, (a, b) => new
            {
                a.Name,
                dname = b.Name
            }) ;
            foreach(var item in itemss)
            {
                Console.WriteLine(item.Name+" "+item.dname);
            }
        }
    }
}
