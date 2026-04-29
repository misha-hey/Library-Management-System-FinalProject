using LibraryAPI.Data;
using LibraryAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace LibraryAPI.Controllers
{
    [Route("api/reports")]
    [ApiController]
    public class ReportsController : ControllerBase
    {
        private readonly AppDbContext _context;

        public ReportsController(AppDbContext context)
        {
            _context = context;
        }

        // 📊 SUMMARY REPORT
        [HttpGet("summary")]
        public IActionResult GetSummary()
        {
            var totalBooks = _context.Books.Count();
            var totalUsers = _context.Users.Count();
            var borrowed = _context.Borrows.Count(b => b.Status == "Borrowed");
            var returned = _context.Borrows.Count(b => b.Status == "Returned");

            return Ok(new
            {
                totalBooks,
                totalUsers,
                borrowed,
                returned
            });
        }

        // 📚 BORROWED BOOKS LIST
        [HttpGet("borrowed")]
        public IActionResult GetBorrowedBooks()
        {
            var data = _context.Borrows
                .Where(b => b.Status == "Borrowed")
                .ToList();

            return Ok(data);
        }

        // 🔄 RETURNED BOOKS LIST
        [HttpGet("returned")]
        public IActionResult GetReturnedBooks()
        {
            var data = _context.Borrows
                .Where(b => b.Status == "Returned")
                .ToList();

            return Ok(data);
        }

        // ⏰ OVERDUE BOOKS
        [HttpGet("overdue")]
        public IActionResult GetOverdueBooks()
        {
            var data = _context.Borrows
                .Where(b => b.DueDate < DateTime.Now && b.Status == "Borrowed")
                .ToList();

            return Ok(data);
        }

        [HttpGet("borrow-per-day")]
        public IActionResult GetBorrowPerDay()
        {
            var data = _context.Borrows
                .AsEnumerable() // force memory processing
                .GroupBy(b => b.BorrowDate.Date)
                .Select(g => new
                {
                    date = g.Key,
                    count = g.Count()
                })
                .OrderBy(x => x.date)
                .ToList();

            return Ok(data);
        }
        // 🏆 MOST BORROWED BOOKS
        [HttpGet("top-books")]
        public IActionResult GetTopBooks()
        {
            var data = _context.Borrows
                .GroupBy(b => b.BookId)
                .Select(g => new
                {
                    bookId = g.Key,
                    total = g.Count()
                })
                .OrderByDescending(x => x.total)
                .Take(5)
                .ToList();

            return Ok(data);
        }
    }
}