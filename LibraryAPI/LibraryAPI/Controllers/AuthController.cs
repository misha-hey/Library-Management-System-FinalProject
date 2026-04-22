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
        public IActionResult Register(User newUser)
        {
            if (newUser == null)
                return BadRequest("Invalid data");

            var existing = _context.Users
                .FirstOrDefault(u => u.Email == newUser.Email);

            if (existing != null)
                return BadRequest("Email already exists");

            var user = new User
            {
                Name = newUser.Name,
                Email = newUser.Email,
                Password = newUser.Password,
                Role = newUser.Role
            };

            _context.Users.Add(user);
            _context.SaveChanges();

            return Ok("Registered successfully");
        }

        // ================= LOGIN =================
        [HttpPost("login")]
        public IActionResult Login(User login)
        {
            if (login == null)
                return BadRequest("Invalid data");

            var user = _context.Users.FirstOrDefault(u =>
                u.Email == login.Email &&
                u.Password == login.Password);

            if (user == null)
                return BadRequest("Invalid credentials");

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