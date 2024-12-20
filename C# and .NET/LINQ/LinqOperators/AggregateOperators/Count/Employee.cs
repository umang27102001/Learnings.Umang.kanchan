﻿namespace Count;
public class Employee
{
    public int ID { get; set; }
    public string Name { get; set; }
    public int Salary { get; set; }
    public string Department { get; set; }

    public static List<Employee> GetAllEmployees()
    {
        List<Employee> listStudents = new List<Employee>()
        {
            new Employee{ID= 101,Name = "Preety", Salary = 10000, Department = "IT"},
            new Employee{ID= 102,Name = "Priyanka", Salary = 15000, Department = "Sales"},
            new Employee{ID= 103,Name = "James", Salary = 50000, Department = "Sales"},
            new Employee{ID= 104,Name = "Hina", Salary = 20000, Department = "IT"},
            new Employee{ID= 105,Name = "Anurag", Salary = 30000, Department = "IT"},
            new Employee{ID= 106,Name = "Sara", Salary = 25000, Department = "IT"},
            new Employee{ID= 107,Name = "Pranaya", Salary = 35000, Department = "IT"},
            new Employee{ID= 108,Name = "Manoj", Salary = 11000, Department = "Sales"},
            new Employee{ID= 109,Name = "Sam", Salary = 45000, Department = "Sales"},
            new Employee{ID= 110,Name = "Saurav", Salary = 25000, Department = "Sales"}
        };

        return listStudents;
    }
}