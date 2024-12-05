namespace IComparable
{
    public class Edge : IComparable<Edge>
    {
        public int Len { get; set; }
        public int Wt { get; set; }
        public int CompareTo(Edge edge)
        {
            return this.Wt-edge.Wt;
        }
        public override string ToString()
        {
            return Len + " " + Wt;
        }
    }
}
