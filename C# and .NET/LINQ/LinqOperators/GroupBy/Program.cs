namespace GroupBy
{
    public class Program
    {
        static void Main(string[] args)
        {
            var output = Student.GetStudents().GroupBy(e => e.Gender).OrderByDescending(e => e.Key).Select(e => new
            {
                e.Key,
                Students = e.OrderBy(e => e.Name)
            }) ;
            foreach (var studentGrp in output)
            {
                Console.WriteLine($"Gender: {studentGrp.Key} {studentGrp.Students.Count()}");
                foreach (var student in studentGrp.Students)
                {
                    Console.WriteLine($"\t{student.Name}");
                }
            }
        }
    }
}
