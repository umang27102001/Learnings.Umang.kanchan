
namespace DefaultIfNull
{
    public class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public int Salary { get; set; }
        public static List<Employee> GetAllEmployees()
        {
            return new List<Employee>()
            {
                new Employee { ID = 1, Name = "Preety", Salary = 10000, Gender = "Female"},
                new Employee { ID = 2, Name = "Priyanka", Salary =20000, Gender = "Female"},
                new Employee { ID = 3, Name = "Anurag", Salary = 35000, Gender = "Male"},
                new Employee { ID = 4, Name = "Pranaya", Salary = 45000, Gender = "Male"}
            };
        }
    }
}
