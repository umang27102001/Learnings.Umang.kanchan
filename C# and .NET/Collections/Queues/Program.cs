namespace Queues
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //MyQueue Mq=new MyQueue();
            //Mq.Run();
            var Cq =new CustomQueue<char>();
            Cq.Enqueue('a');
            Cq.Enqueue('b');
            Cq.Enqueue('c');
            Cq.Enqueue('d');
            Cq.Dequeue();
            Cq.Print();
        }
    }
}
