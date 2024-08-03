using C_BookStoreBackEndAPI.Data;
using Microsoft.AspNetCore.Mvc;

namespace C_BookStoreBackEndAPI.Controllers
{
    [ApiController]
    [Route("api/book")]
    public class BookController : ControllerBase
    {
        private readonly BookStoreDBContext _context;
        public BookController(BookStoreDBContext context) 
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var books = _context.Books.ToList();

            return Ok(books);
        }

        [HttpGet("{id}")]
        public IActionResult GetById([FromRoute] int id)
        {
            var book = _context.Books.Find(id);

            if (book == null)
            {
                return NotFound();
            }
            return Ok(book);
        }
    }
}
