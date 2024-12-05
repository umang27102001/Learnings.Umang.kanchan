
namespace Intersection
{
    public class EqualityComparer:IEqualityComparer<Student>
    {
        public bool Equals(Student a,Student b)
        {
            return a.Id == b.Id;
        }
        public int GetHashCode(Student std)
        {
            return (std.Id^std.Marks).GetHashCode();
        }
    }
}
