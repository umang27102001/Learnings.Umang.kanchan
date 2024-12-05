using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods
{
    public static class BookExtensions
    {
        public static int GetPrine(this Book book)
        {
            return book.Price;
        }
        public static Book GetBestRatedBook(this List<Book> books)
        {
            float rating = 0;
            Book ans = null;
            foreach(Book book in books)
            {
                if (rating < book.Rating)
                {
                    rating= book.Rating;
                    ans= book;
                }
            }
            return ans;
        }
        public static Book GetLeastRatedBook(this List<Book> books)
        {
            float rating = 5.1f;
            Book? ans = null;
            foreach(Book book in books)
            {
                if (rating > book.Rating)
                {
                    rating= book.Rating;
                    ans= book;
                }
            }
            return ans;

        }
        public static int CompareWith(this Book book,Book other)
        {
            return (int)(book.Rating - other.Rating);
        }
        public static string Publish(this Book book)
        {
            return $"{book.Title} was written by {book.AuthorName}, rated {book.Rating} is available at INR {book.Price}";
        }
    }
}
