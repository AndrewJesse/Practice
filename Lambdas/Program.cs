using System;
using System.Linq;
using System.Collections.Generic;


namespace Lambdas
{
    class Program
    {
        // This is a data model
        class Book
        {
            public string Author { get; set; }
            public int Pages { get; set; }
            public string Genre { get; set; }
            public string Title { get; set; }
            public decimal Price { get; set; }
        }
        // This class holds the list of books
        class BookRepository
        {
            private List<Book> allBooks = new List<Book>
            {
                new Book { Author = "Neal Stephensen", Pages = 322, Genre = "Fiction", Title = "Snow Crash", Price = 9.99m },
                new Book { Author = "Stephen King", Pages = 249, Genre = "Mystery", Title = "The Shining", Price = 12.99m },
                new Book { Author = "Frank Herber", Pages = 405, Genre = "Sci-Fi", Title = "Dune", Price = 15.99m },
            };

            public List<Book> GetAllBooks() => allBooks;
        }
        static void Main(string[] args)
        {
            // Create an instance of the BookRepository class
            BookRepository bookRepository = new BookRepository();

            // Get the list of books from the BookRepository instance
            List<Book> allBooks = bookRepository.GetAllBooks();

            // Assign the List of books to an IEnumerable<Book> variable
            IEnumerable<Book> bookEnumerable = allBooks;

            // Print the details of each book
            allBooks.ForEach(n => Console.WriteLine($"Title: {n.Title}, Author: {n.Author}, Genre: {n.Genre}, Pages: {n.Pages}, Price: {n.Price:C}"));

        }



    }
}
