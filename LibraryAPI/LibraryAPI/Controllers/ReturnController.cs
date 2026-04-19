using LibraryAPI.Data;
using LibraryAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace LibraryAPI.Controllers
{
    [Route("api/return")]
    [ApiController]
    public class ReturnController : ControllerBase
    {
        private readonly AppDbContext _context;

        public ReturnController(AppDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        public IActionResult ReturnBook(ReturnBook returnBook)
        {
            var borrow = _context.Borrows.Find(returnBook.BorrowId);

            if (borrow == null)
                return NotFound();

            borrow.Status = "Returned";

            var book = _context.Books.Find(borrow.BookId);
            book.Quantity++;

            returnBook.ReturnDate = DateTime.Now;

            _context.Returns.Add(returnBook);
            _context.SaveChanges();

            return Ok(returnBook);
        }
    }
}
