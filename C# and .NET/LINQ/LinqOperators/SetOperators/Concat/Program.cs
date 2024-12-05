namespace Concat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> StudentCollection1 = new List<Student>()
            {
                new Student {ID = 101, Name = "Preety" },
                new Student {ID = 102, Name = "Sambit" },
                new Student {ID = 105, Name = "Hina"},
                new Student {ID = 106, Name = "Anurag"},
            };
            List<Student> StudentCollection2 = new List<Student>()
            {
                new Student {ID = 105, Name = "Hina"},
                new Student {ID = 106, Name = "Anurag"},
                new Student {ID = 107, Name = "Pranaya"},
                new Student {ID = 108, Name = "Santosh"},
            };
            var MS = StudentCollection1.Concat(StudentCollection2).ToList();
            foreach(Student student in MS)
            {
                Console.WriteLine(student.ToString());
            }
        }
    }
}
