namespace Union
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IList<Student> studentsA = new List<Student>()
            {
                new Student {Id = 1, Name = "Umang" , Marks = 100 },
                new Student {Id = 2, Name = "Shalu" , Marks = 110 },
                new Student {Id = 3, Name = "Mohan" , Marks = 80 },
                new Student {Id = 4, Name = "Roshni" , Marks = 70 },
                new Student {Id = 5, Name = "Deepak" , Marks = 90 },
                new Student {Id = 6, Name = "Vikas" , Marks = 50 },
                new Student {Id = 7, Name = "Kamal" , Marks = 10 }
            };
            IList<Student> studentsB = new List<Student>()
            {
                new Student {Id = 5, Name = "Deepak" , Marks = 90 },
                new Student {Id = 6, Name = "Vikas" , Marks = 50 },
                new Student {Id = 7, Name = "Kamal" , Marks = 10 }
            };
            
            var newStudents = studentsA.Union(studentsB).ToList();
            foreach (var student in newStudents)
            {
                Console.WriteLine(student.ToString());
            }
        }
    }
}
