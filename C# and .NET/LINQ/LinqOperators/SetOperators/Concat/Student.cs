namespace Concat
{
    public class Student
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string ToString()
        {
            return ID + " " + Name;
        }
    }
}
