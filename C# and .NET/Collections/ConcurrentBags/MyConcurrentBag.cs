namespace ConcurrentBags
{
    using System.Collections.Concurrent;

    public class MyConcurrentBag
    {
        public void Run()
        {
            ConcurrentBag<char> cb = new();
            //Add element to cb
            cb.Add('a');
            cb.Add('b');
            cb.Add('c');
            cb.Add('d');
            cb.Add('o');
            //TryPeek() returns true and assigns value to ch if cb is non empty else it returns false;
            char ch;
            cb.TryPeek(out ch);
            //TryRemove() removes top element from cb if present and returns true else returns false.
            char Remove;
            cb.TryTake(out Remove);
            char[] Arr = cb.ToArray();
            foreach (var item in cb) Console.Write("{0} ", item);
            Console.WriteLine("\n");
            cb.Add('u');
            //This does not appends 'u' to the cb instead it returns a new IEnumerable<char> that has 'u' appended
            cb.Append('u');
            // This also does not reverse the original cb instead it returns IEmumerable to enumerate in reverse order
            cb.Reverse();
            // Any method returns true if cb is non-empty rlse returns false;
            Console.WriteLine(cb.Any());
            foreach (var item in cb) Console.Write("{0} ", item);
        }
    }
}