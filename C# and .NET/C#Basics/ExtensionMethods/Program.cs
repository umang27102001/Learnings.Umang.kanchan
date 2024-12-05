namespace ExtensionMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Book> books = new List<Book>()
           {
               new Book() {AuthorName="Robert Kiyosaki and Sharon Lechter" , Title="Rich Dad Poor Dad", Price=350, Rating=4.5f},
               new Book() {AuthorName="Francesc Miralles and Hector Garcia" , Title="Ikigai", Price=400, Rating=4.5f},
               new Book() {AuthorName="Robert Kiyosaki and Sharon Lechter" , Title="Atomic Habits", Price=450, Rating=4.8f},
               new Book() {AuthorName="Charles Duhigg" , Title="The Power of Habit", Price=350, Rating=4.3f},
               new Book() {AuthorName="Daniel Kahneman" , Title="Thinking, Fast and Slow", Price=250, Rating=4.4f},
               new Book() {AuthorName="Jonathan Swift" , Title="Gulliver`s Travels", Price=500, Rating=3.8f}
           };
            Book bestRatedBook = books.GetBestRatedBook();
            Book leastRatedBook = books.GetLeastRatedBook();
            Console.WriteLine(bestRatedBook.Publish());
            Console.WriteLine(leastRatedBook.Publish());
            Console.WriteLine(bestRatedBook.CompareWith(leastRatedBook));
            books.Sort();
          
            Console.WriteLine("\n");
            foreach(Book book in books)
            {
                Console.WriteLine(book.Publish()+"\n");
            }
        }
    }
}
