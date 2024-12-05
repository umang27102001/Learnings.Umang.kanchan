namespace ThenBy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var students = Student.GetAllStudents();
            var sorted = students.OrderBy(e=>e.FirstName).ThenBy(e=>e.LastName).ThenBy(e=>e.Branch).ToList();
            foreach (var student in sorted)
            {
                Console.WriteLine(student.ToString());
            }
        }
    }
}
