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

            // CHECK IF BOOK EXISTS
            if (book == null)
                return BadRequest("Book not found");

            // CHECK QUANTITY
            if (book.Quantity <= 0)
                return BadRequest("Book not available");

            // CHECK IF USER ALREADY BORROWED THIS BOOK
            var existingBorrow = _context.Borrows.FirstOrDefault(b =>

                b.UserId == borrow.UserId &&

                b.BookId == borrow.BookId &&

                b.Status == "Borrowed"
            );

            if (existingBorrow != null)
                return BadRequest("You already borrowed this book");

            // REDUCE QUANTITY
            book.Quantity--;

            // SET BORROW DETAILS
            borrow.BorrowDate = DateTime.Now;

            // 3 DAYS DUE DATE
            borrow.DueDate = DateTime.Now.AddDays(3);

            borrow.Status = "Borrowed";

            // SAVE
            _context.Borrows.Add(borrow);

            _context.SaveChanges();

            return Ok("Borrowed successfully");
        }
        [HttpGet("user/{userId}")]   
        public IActionResult GetBorrowedByUser(int userId)
        {
            var data = (from b in _context.Borrows

                        join bk in _context.Books
                        on b.BookId equals bk.BookId

                        join u in _context.Users
                        on b.UserId equals u.UserId

                        where b.UserId == userId

                        select new
                        {
                            borrowId = b.BorrowId,

                            userName = u.Name,

                            bookTitle = bk.Title,

                            borrowDate = b.BorrowDate,

                            dueDate = b.DueDate,

                            status = b.Status
                        }).ToList();

            return Ok(data);
        }
        [HttpGet]
        public IActionResult GetAllBorrows()
        {
            var data = (from b in _context.Borrows

                        join bk in _context.Books
                        on b.BookId equals bk.BookId

                        join u in _context.Users
                        on b.UserId equals u.UserId

                        select new
                        {
                            borrowId = b.BorrowId,

                            userName = u.Name,

                            bookTitle = bk.Title,

                            borrowDate = b.BorrowDate,

                            dueDate = b.DueDate,

                            status = b.Status
                        })

                        .ToList();

            return Ok(data);
        }
        [HttpGet("recent/{userId}")]
        public IActionResult GetRecentBorrowed(int userId)
        {
            var recentBooks =

                (from b in _context.Borrows

                 join bk in _context.Books
                 on b.BookId equals bk.BookId

                 where b.UserId == userId
                  && b.Status == "Borrowed"

                 orderby b.BorrowDate descending

                 select new
                 {
                     bk.BookId,
                     bk.Title,
                     bk.Author,
                     bk.ImagePath,
                     b.BorrowDate,
                     b.DueDate,
                     b.Status
                 })

                 .Take(5)

                 .ToList();

            return Ok(recentBooks);
        }
    }
}
