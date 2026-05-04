using LibraryAPI.Data;
using LibraryAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace LibraryAPI.Controllers
{
    [Route("api/books")]
    [ApiController]
    public class BooksController: ControllerBase
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _env;

        public BooksController(AppDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }
        private string SaveImage(string base64)
        {
            if (base64.Contains(","))
                base64 = base64.Split(',')[1];

            byte[] bytes = Convert.FromBase64String(base64);

            string fileName = Guid.NewGuid().ToString() + ".jpg";
            string folderPath = Path.Combine(_env.WebRootPath, "images");

            if (!Directory.Exists(folderPath))
                Directory.CreateDirectory(folderPath);

            string filePath = Path.Combine(folderPath, fileName);

            System.IO.File.WriteAllBytes(filePath, bytes);

            return fileName;
        }

        // ================= HELPER: DELETE IMAGE =================
        private void DeleteImage(string imagePath)
        {
            string fullPath = Path.Combine(_env.WebRootPath, imagePath.TrimStart('/'));

            if (System.IO.File.Exists(fullPath))
            {
                System.IO.File.Delete(fullPath);
            }
        }
    
        [HttpGet]
        public IActionResult GetBooks()
        {
            return Ok(_context.Books.ToList());
        }

        [HttpPost]
        public IActionResult AddBook(Book book)
        {
            if (!string.IsNullOrEmpty(book.ImagePath))
            {
                string fileName = SaveImage(book.ImagePath);
                book.ImagePath = "/images/" + fileName;
            }

            _context.Books.Add(book);
            _context.SaveChanges();
            return Ok(book);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateBook(int id, Book updated)
        {
            var book = _context.Books.Find(id);
            if (book == null) return NotFound();

            book.Title = updated.Title;
            book.Author = updated.Author;
            book.Category = updated.Category;
            book.Quantity = updated.Quantity;

            // If naay new image
            if (!string.IsNullOrEmpty(updated.ImagePath))
            {
                // delete old image
                if (!string.IsNullOrEmpty(book.ImagePath))
                {
                    DeleteImage(book.ImagePath);
                }

                string fileName = SaveImage(updated.ImagePath);
                book.ImagePath = "/images/" + fileName;
            }

            _context.SaveChanges();
            return Ok(book);
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteBook(int id)
        {
            var book = _context.Books.Find(id);
            if (book == null) return NotFound();

            // delete image file
            if (!string.IsNullOrEmpty(book.ImagePath))
            {
                DeleteImage(book.ImagePath);
            }

            _context.Books.Remove(book);
            _context.SaveChanges();
            return Ok();
        }

    }
}
