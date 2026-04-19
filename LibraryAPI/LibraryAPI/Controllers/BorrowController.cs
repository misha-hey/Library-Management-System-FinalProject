using LibraryAPI.Data;
using LibraryAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace LibraryAPI.Controllers
{
    [Route("api/borrow")]
    [ApiController]
    public class BorrowController : ControllerBase
    {
        private readonly AppDbContext _context;

        public BorrowController(AppDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        public IActionResult BorrowBook(Borrow borrow)
        {
            var book = _context.Books.Find(borrow.BookId);

            if (book == null || book.Quantity <= 0)
                return BadRequest("Book not available");

            book.Quantity--;

            borrow.BorrowDate = DateTime.Now;
            borrow.Status = "Borrowed";

            _context.Borrows.Add(borrow);
            _context.SaveChanges();

            return Ok(borrow);
        }
    }
}
