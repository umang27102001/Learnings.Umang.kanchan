namespace DependencyInjection
{
    public class FindArea
    {
        private readonly IShape _shape;
        public FindArea(IShape shape)
        {
            _shape = shape;
        }
        public void PrintArea()
        {
            _shape.PrintArea();
        }
    }
}
