namespace OrderBy
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>() { 6, 4, 3, 8, 9, 1, 0, 11, 21, 15 };
            var newList = list.OrderBy(e => e);
            var students=Student.GetAllStudents();
            var sortedStudents = students.Where(e => e.Branch == "CSE").OrderBy(e=>e.FirstName);
            
            string[] Alphabets = { "a", "b", "c", "A", "B", "C" };
            var sorted = Alphabets.OrderBy(e=>e,new Comparer());
            foreach(var item in sorted)
            {
                Console.Write(item+" ");
            }
        }
    }
}
