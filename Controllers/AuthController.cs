using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using hotel_app.Models;
using hotel_app.Data;
using System.Text.Json;

namespace hotel_app.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly ApplicationDBContext _db;

        public AuthController(ApplicationDBContext db)
        {
            _db = db;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(new { message = "API is working" });
        }

        [HttpGet("test")]
        public IActionResult Test()
        {
            return Ok(new { message = "Test endpoint is working" });
        }

        [HttpPost("login")]
        public async Task<ActionResult> Login([FromBody] LoginModel model)
        {
            // Basic validation
            if (model == null)
            {
                return BadRequest("Model is null");
            }

            try
            {
                // Find user without tracking
                var user = await _db.Users
                    .AsNoTracking()
                    .Where(u => u.Email == model.Email && u.Password == model.Password)
                    .FirstOrDefaultAsync();

                if (user == null)
                {
                    return Unauthorized(new { message = "Invalid credentials" });
                }

                // Basic success response
                return Ok(new
                {
                    message = "Login successful",
                    role = "Receptionniste",
                    userName = "Sophie Martin"
                });
            }
            catch
            {
                return StatusCode(500, new { message = "Internal server error" });
            }
        }

    }
    public class LoginModel
    {
        public string Email { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
    }
}