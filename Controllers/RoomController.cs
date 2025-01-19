using hotel_app.Data;
using Microsoft.AspNetCore.Mvc;

namespace hotel_app.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RoomController : Controller
    {
        private readonly ApplicationDBContext _db;
        public RoomController(ApplicationDBContext db)
        {
            _db = db;
        }
        [HttpGet]
        public IActionResult GetRooms()
        {
            var rooms = _db.Rooms.ToList(); // Ensure it's materialized

            if (rooms == null || rooms.Count == 0)
            {
                return NoContent(); // Return 204 if no rooms found
            }

            return Ok(rooms); // Return 200 with the rooms
        }
    }
}
