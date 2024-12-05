namespace IComparable
{
    public class Program
    {
        static void Main(string[] args)
        {
            Edge[] edges = new Edge[10]
            {
                new Edge{Len=3,Wt=4},
                new Edge{Len=5,Wt=1},
                new Edge{Len=13,Wt=2},
                new Edge{Len=23,Wt=6},
                new Edge{Len=13,Wt=6},
                new Edge{Len=3,Wt=8},
                new Edge{Len=4,Wt=9},
                new Edge{Len=7,Wt=10},
                new Edge{Len=8,Wt=15},
                new Edge{Len=9,Wt=1}
            };
            Array.Sort(edges);
            foreach (Edge edge in edges)
            {
                Console.WriteLine(edge.ToString());
            }
        }
    }
}
