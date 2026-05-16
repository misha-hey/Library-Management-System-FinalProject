using LibraryAPI.Data;
using LibraryAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace LibraryAPI.Controllers
{
    [Route("api/auth")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly AppDbContext _context;

        public AuthController(AppDbContext context)
        {
            _context = context;
        }

        // ================= REGISTER =================
        [HttpPost("register")]
        public IActionResult Register(User user)
        {
            if (user == null)
                return BadRequest("Invalid data");

            bool exists = _context.Users
                .Any(u => u.Email == user.Email);

            if (exists)
                return BadRequest("Email already exists");

            string hashedPassword =
                BCrypt.Net.BCrypt.HashPassword(user.Password);

            User newUser = new User()
            {
                Name = user.Name,
                Email = user.Email,
                Password = hashedPassword,

                // AUTO BORROWER
                Role = "Borrower"
            };

            _context.Users.Add(newUser);
            _context.SaveChanges();

            return Ok("Borrower registered successfully");
        }
        [HttpPost("register-admin")]
        public IActionResult RegisterAdmin(User user)
        {
            bool exists = _context.Users
                .Any(u => u.Email == user.Email);

            if (exists)
                return BadRequest("Email already exists");

            string hashedPassword =
                BCrypt.Net.BCrypt.HashPassword(user.Password);

            User newUser = new User()
            {
                Name = user.Name,
                Email = user.Email,
                Password = hashedPassword,

                // AUTO ADMIN
                Role = "Admin"
            };

            _context.Users.Add(newUser);
            _context.SaveChanges();

            return Ok("Admin registered successfully");
        }
        // ================= LOGIN =================
        [HttpPost("login")]
        public IActionResult Login(LoginDTO dto)
        {
            var user = _context.Users
                .FirstOrDefault(u => u.Email == dto.Email);

            if (user == null)
            {
                return Unauthorized("Invalid Email");
            }

            // VERIFY HASHED PASSWORD
            bool validPassword =
                BCrypt.Net.BCrypt.Verify(
                    dto.Password,
                    user.Password
                );

            if (!validPassword)
            {
                return Unauthorized("Invalid Password");
            }

            return Ok(new
            {
                user.UserId,
                user.Name,
                user.Email,
                user.Role
            });
        }
    }
}