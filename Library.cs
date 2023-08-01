using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment20
{
    internal class Library
    {
        private List<Book> books;

        public Library()
        {
            books = new List<Book>();
        }

        public void AddBook(Book book)
        {
            books.Add(book);
            Console.WriteLine("Book added successfully.");
        }

        public void ViewAllBooks()
        {
            foreach (Book book in books)
            {
                Console.WriteLine(book);
            }
        }

        public void SearchBookById(int bookId)
        {
            Book book = books.Find(b => b.BookId == bookId);
            if (book != null)
            {
                Console.WriteLine("Book found:");
                Console.WriteLine(book);
            }
            else
            {
                Console.WriteLine("Book not found.");
            }
        }

        public void SearchBookByTitle(string title)
        {
            Book book = books.Find(b => b.Title.ToLower().Contains(title.ToLower()));
            if (book != null)
            {
                Console.WriteLine("Book found:");
                Console.WriteLine(book);
            }
            else
            {
                Console.WriteLine("Book not found.");
            }
        }
    }
}
