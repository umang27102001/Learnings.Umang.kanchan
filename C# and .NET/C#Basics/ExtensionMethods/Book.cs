using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods
{
    public class Book:IComparable<Book>
    {
        public string AuthorName {  get; set; }
        public string Title { get; set; }
        public int Price { get; set; }
        public float Rating { get; set; }
        public int CompareTo(Book book)
        {
            if (Rating < book.Rating)
            {
                return -1;
            }
            else if(Rating > book.Rating)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
    }
}
