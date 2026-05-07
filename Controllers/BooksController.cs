using Microsoft.AspNetCore.Mvc;
using BooksApi.Models;

namespace BooksApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BooksController : ControllerBase
    {
        private static List<Book> books = new List<Book>
        {
            new Book { Id = 1, Title = "Vadachennai", Author = "Vetrimaaran" },
            new Book { Id = 2, Title = "Madras", Author = "Pa.Ranjith" }
        };


        // GET: api/books
        [HttpGet]
        public ActionResult<IEnumerable<Book>> GetBooks()
        {
            return Ok(books);
        }

        // GET: api/books/1
        [HttpGet("{id}")]
        public ActionResult<Book> GetBook(int id)
        {
            var book = books.FirstOrDefault(b => b.Id == id);

            if (book == null)
            {
                return NotFound();
            }

            return Ok(book);
        }

        // POST: api/books
        [HttpPost]
        public ActionResult<Book> CreateBook(Book book)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            book.Id = books.Max(b => b.Id) + 1;

            books.Add(book);

            return CreatedAtAction(nameof(GetBook), new { id = book.Id }, book);
        }

        // PUT: api/books/1
        [HttpPut("{id}")]
        public IActionResult UpdateBook(int id, Book updatedBook)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var existingBook = books.FirstOrDefault(b => b.Id == id);

            if (existingBook == null)
            {
                return NotFound();
            }

            existingBook.Title = updatedBook.Title;
            existingBook.Author = updatedBook.Author;

            return NoContent();
        }

        // DELETE: api/books/1
        [HttpDelete("{id}")]
        public IActionResult DeleteBook(int id)
        {
            var book = books.FirstOrDefault(b => b.Id == id);

            if (book == null)
            {
                return NotFound();
            }

            books.Remove(book);

            return NoContent();
        }
    }
}