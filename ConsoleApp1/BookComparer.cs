using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class BookContainer
    {
        public List<Book> Books { get; set; }

        public BookContainer()
        {
            Books = new List<Book>();
        }

        public void SortBooks(BookComparer comparer)
        {
            Books.Sort((b1, b2) => comparer(b1, b2));
        }
    }
}
