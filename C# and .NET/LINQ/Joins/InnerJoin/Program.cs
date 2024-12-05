namespace InnerJoin
{
    public class Program
    {
        static void Main(string[] args)
        {
            var employees = Employee.GetAllEmployees();
            var address = Address.GetAllAddresses();
            var joinedList = employees.Join(address,e=>e.AddressId,e=>e.ID,(e,a)=>new
            {
                e.Name,
                a.AddressLine
            });
            foreach (var employee in joinedList)
            {
                Console.WriteLine(employee.Name+" "+employee.AddressLine);
            }
        }
    }
}
