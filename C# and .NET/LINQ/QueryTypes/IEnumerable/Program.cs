namespace IEnumerable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> studentList = new List<Student>()
            {
                new Student(){ID = 1, Name = "James", Marks =100},
                new Student(){ID = 2, Name = "Sara", Marks = 80},
                new Student(){ID = 3, Name = "Steve", Marks = 102},
                new Student(){ID = 4, Name = "Pam", Marks = 89}
            };

            var students = studentList.Where(c => c.Marks > 90).Select(c => new
            {
                Name = c.Name,
                Marks = c.Marks
            });

            foreach (var student in students)
            {
                Console.WriteLine(student.Name + " " + student.Marks);
            }
        }
    }
}
