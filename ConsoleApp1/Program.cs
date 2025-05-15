using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Program
    {
       
        public static int CompareByTitle(Book b1, Book b2)
        {
            return string.Compare(b1.Title, b2.Title);
        }
        public static int CompareByAuthor(Book b1, Book b2)
        {
            return string.Compare(b1.Author, b2.Author);
        }
        public static int CompareByPublisher(Book b1, Book b2)
        {
            return string.Compare(b1.Publisher, b2.Publisher);
        }

        public static void Main(string[] args)
        {
            var book1 = new Book("C# Programming", "John Doe", "TechBooks");
            var book2 = new Book("Java Programming", "Jane Smith", "TechBooks");
            var book3 = new Book("Python for Beginners", "Alice Johnson", "CodingPress");
            var container = new BookContainer();
            container.Books.Add(book1);
            container.Books.Add(book2);
            container.Books.Add(book3);

            Console.WriteLine("Sort by Title:");
            container.SortBooks(CompareByTitle);
            foreach (var book in container.Books)
            {
                Console.WriteLine(book);
            }

            Console.WriteLine("\nSort by Author:");
            container.SortBooks(CompareByAuthor);
            foreach (var book in container.Books)
            {
                Console.WriteLine(book);
            }

            Console.WriteLine("\nSort by Publisher:");
            container.SortBooks(CompareByPublisher);
            foreach (var book in container.Books)
            {
                Console.WriteLine(book);
            }
        }
    }
}
