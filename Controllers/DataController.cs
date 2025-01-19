using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace hotel_app.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DataController : ControllerBase
    {
        [HttpGet("test")]
        public IActionResult GetTestData()
        {
            return Ok(new { message = "Hello from ASP.NET Core API!" });
        }
    }
}
