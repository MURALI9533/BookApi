using BookApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace BookApi.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {

        private Book[] _books = new Book[]
        {
            new Book { Id = 1, Author = "Murali", Title = "Life" },
            new Book { Id = 2, Author = "Jane Austen", Title = "Pride and Prejudice" },
            new Book { Id = 3, Author = "George Orwell", Title = "1984" },
            new Book { Id = 4, Author = "Harper Lee", Title = "To Kill a Mockingbird" },
            new Book { Id = 5, Author = "F. Scott Fitzgerald", Title = "The Great Gatsby" },
            new Book { Id = 6, Author = "J.K. Rowling", Title = "Harry Potter and the Sorcerer's Stone" },
            new Book { Id = 7, Author = "J.R.R. Tolkien", Title = "The Hobbit" },
            new Book { Id = 8, Author = "Mark Twain", Title = "The Adventures of Tom Sawyer" },
            new Book { Id = 9, Author = "Isaac Asimov", Title = "Foundation" },
            new Book { Id = 10, Author = "Gabriel Garcia Marquez", Title = "One Hundred Years of Solitude" }
        };


        [HttpGet]
        public ActionResult<IEnumerable<Book>> GetBooks()
        {
            return this._books;
            //return Ok(this._books);
        }
    }
}
