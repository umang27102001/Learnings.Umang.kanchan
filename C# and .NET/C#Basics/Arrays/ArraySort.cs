namespace Arrays
{
    class Cmp : IComparer<string>
    {
        public int Compare(string s,string t)
        {
            return t.CompareTo(s);
        }
    }
    internal class ArraySort
    {
        void Swap(ref int a,ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
        public int CompareStr(string s,string t)
        {
            return t[t.Length-1]-s[s.Length-1];
        }
        public void Sort(string[] arr)
        {
            Array.Sort(arr,(a,b)=>b.CompareTo(a));
        }
        public void SortArray()
        {
            string[] arr = { "umang", "aman", "Polish", "Uppa" };
            for (int i = 0; i < arr.Length; i++) Console.Write(arr[i] + " ");

        }
    }
}
