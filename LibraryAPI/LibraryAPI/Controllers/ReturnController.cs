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
        [HttpGet]
        public IActionResult GetReturnedBooks()
        {
            var data = (from r in _context.Returns
                        join br in _context.Borrows
                        on r.BorrowId equals br.BorrowId
                        join b in _context.Books
                        on br.BookId equals b.BookId
                        join u in _context.Users
                        on br.UserId equals u.UserId
                        select new
                        {
                            returnId = r.ReturnBookId,
                            bookTitle = b.Title,
                            userName = u.Name,
                            returnDate = r.ReturnDate.ToString("yyyy-MM-dd"),
                            fine = r.FineAmount
                        }).ToList();

            return Ok(data);
        }
    }
}
