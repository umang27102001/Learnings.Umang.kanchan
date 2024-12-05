namespace StringBuilders
{
    using System.Text;
    internal class StringBuilders
    {
        public void Print()
        {
            //Create StringBuilder Object
            StringBuilder sb = new StringBuilder("umang");
            sb.Append(" Kanchan");
            sb.Insert(4, "oppo");
            sb.Replace('u', 'U');
            sb.Remove(4, 4);
            int length = sb.Length;
            sb.AppendLine("automotiveMastermind");
            sb.Replace("a", " hello ");
            Console.WriteLine(sb);
        }
    }
}
