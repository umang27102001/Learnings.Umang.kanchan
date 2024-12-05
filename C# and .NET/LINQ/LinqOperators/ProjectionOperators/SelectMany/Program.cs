namespace SelectMany
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var MethodSyntax = Student.GetStudents()
                                        .SelectMany(e => e.Programming,(student,program)=>new
                                        {
                                            Name=student.Name,
                                            Program=program
                                        }
                                        );
           
            foreach (var item in MethodSyntax)
            {
                Console.WriteLine(item.Name + " => " + item.Program);
            }

            Console.ReadKey();
        }
    }
}


