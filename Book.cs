using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment20
{
    internal class Book
    {
        public int BookId { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Genre { get; set; }
        public bool IsAvailable { get; set; }

        public Book(int bookId, string title, string author, string genre, bool isAvailable)
        {
            BookId = bookId;
            Title = title;
            Author = author;
            Genre = genre;
            IsAvailable = isAvailable;
        }

        public override string ToString()
        {
            return $"Book ID: {BookId}, Title: {Title}, Author: {Author}, Genre: {Genre}, Available: {(IsAvailable ? "Yes" : "No")}";
        }
    }
}
