

namespace IComparer
{
    public class Car
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public string Type { get; set; }

        public override string ToString()
        {
            return (Name+" "+Price+" "+Type);
        }
    }
}
