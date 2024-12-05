namespace OrderBy
{
    public class Comparer:IComparer<string>
    {
        public int Compare(string x, string y)
        {
            return string.Compare(x,y,true);
        }
    }
}
