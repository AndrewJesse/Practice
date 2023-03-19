using System;
using System.Linq;
using System.Collections.Generic;

namespace Lambdas
{
    class Program
    {
        public class Book
        {
            public long? ID { get; set; } 
            public string Author { get; set; }
            public int Pages { get; set; }
            public string Genre { get; set; }
            public string Title { get; set; }
            public decimal Price { get; set; }
        }
        public interface IBookRepository
        {
            List<Book> GetAllBooks();
        }
        public class BookRepository : IBookRepository
        {
            private List<Book> allBooks = new List<Book>
            {
                new Book { ID = 1, Author = "Neal Stephenson", Pages = 480, Genre = "Science Fiction", Title = "Snow Crash", Price = 9.99m },
                new Book { ID = 2, Author = "Stephen King", Pages = 659, Genre = "Horror", Title = "The Shining", Price = 12.99m },
                new Book { ID = 3, Author = "Frank Herbert", Pages = 412, Genre = "Science Fiction", Title = "Dune", Price = 15.99m },
                new Book { ID = 4, Author = "George Orwell", Pages = 328, Genre = "Dystopian", Title = "1984", Price = 10.99m },
                new Book { ID = 5, Author = "Harper Lee", Pages = 281, Genre = "Fiction", Title = "To Kill a Mockingbird", Price = 11.99m },
                new Book { ID = 6, Author = "J.D. Salinger", Pages = 277, Genre = "Fiction", Title = "The Catcher in the Rye", Price = 10.49m },
                new Book { ID = 7, Author = "J.R.R. Tolkien", Pages = 423, Genre = "Fantasy", Title = "The Hobbit", Price = 14.99m },
                new Book { ID = 8, Author = "F. Scott Fitzgerald", Pages = 180, Genre = "Fiction", Title = "The Great Gatsby", Price = 10.29m },
                new Book { ID = 9, Author = "Jane Austen", Pages = 480, Genre = "Romance", Title = "Pride and Prejudice", Price = 9.49m },
                new Book { ID = 10, Author = "Margaret Atwood", Pages = 311, Genre = "Dystopian", Title = "The Handmaid's Tale", Price = 14.99m },
                new Book { ID = 11, Author = "Ray Bradbury", Pages = 158, Genre = "Science Fiction", Title = "Fahrenheit 451", Price = 9.79m },
                new Book { ID = 12, Author = "Ernest Hemingway", Pages = 251, Genre = "Fiction", Title = "The Old Man and the Sea", Price = 11.29m },
                new Book { ID = 13, Author = "Aldous Huxley", Pages = 268, Genre = "Dystopian", Title = "Brave New World", Price = 10.19m },
                new Book { ID = 14, Author = "Joseph Heller", Pages = 453, Genre = "Satire", Title = "Catch-22", Price = 12.49m },
                new Book { ID = 15, Author = "Emily Brontë", Pages = 326, Genre = "Gothic Fiction", Title = "Wuthering Heights", Price = 9.99m },
                new Book { ID = 16, Author = "Louisa May Alcott", Pages = 449, Genre = "Fiction", Title = "Little Women", Price = 12.99m },
                new Book { ID = 17, Author = "J.K. Rowling", Pages = 309, Genre = "Fantasy", Title = "Harry Potter and the Philosopher's Stone", Price = 14.99m }

            };
            public List<Book> GetAllBooks() => allBooks;
        }


        public class BookService
        {
            private readonly IBookRepository _bookRepository;
            public BookService(IBookRepository bookRepository) => _bookRepository = bookRepository;
            
            public void PrintAllBooks()
            {
                var allBooks = _bookRepository.GetAllBooks();
                allBooks.ForEach(n => Console.WriteLine($"Title: {n.Title}, Author: {n.Author}, Genre: {n.Genre}, Pages: {n.Pages}, Price: {n.Price:C}"));
            }
        }

        static void Main(string[] args)
        {
            IBookRepository bookRepository = new BookRepository();
            BookService bookService = new BookService(bookRepository);
            
            // This is basically Index.cshtml
            bookService.PrintAllBooks();
        }
    }
}
