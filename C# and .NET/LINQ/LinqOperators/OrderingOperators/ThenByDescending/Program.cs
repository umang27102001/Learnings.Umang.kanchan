namespace ThenByDescending
{
    public class Program
    {
        static void Main(string[] args)
        {
            var students = Student.GetAllStudents();
            var sorted = students.OrderBy(e => e.FirstName).ThenByDescending(e => e.LastName).ThenByDescending(e => e.Branch).ToList();
            foreach (var student in sorted)
            {
                Console.WriteLine(student.ToString());
            }
        }
    }
}
