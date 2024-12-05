namespace Where
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var emp= Employee.GetEmployees().Select((e,i)=>new { elem=e,ind=i}).Where(e=>e.elem.Gender=="Male"&&e.elem.Salary>= 500000).Select(e=>e).ToList();
            foreach(var e in emp)
            {
                Console.WriteLine(e.elem.Name+" "+e.elem.Salary);
            }
            Console.ReadKey();
        }
    }
}

