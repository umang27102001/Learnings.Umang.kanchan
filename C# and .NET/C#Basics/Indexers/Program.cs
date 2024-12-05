
namespace Indexers
{

    internal class Program
    {
        static void Main(string[] args)
        {
            Indexers myIndexer = new Indexers();
            myIndexer[0]=new Rectangle() { x=3, y=4 };
            myIndexer[1]=new Rectangle() { x=4, y=5 };
            myIndexer[2]=new Rectangle() { x=6, y=4 };
            myIndexer[3]=new Rectangle() { x=1, y=5 };
            Console.WriteLine("{0} {1} {2} {3}", myIndexer[0].FindArea(), myIndexer[1].FindArea(), myIndexer[2].FindArea(), myIndexer[3].FindArea());
        }
    }
}
