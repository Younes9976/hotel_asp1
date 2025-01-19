using hotel_app.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace hotel_app.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DashboardController : Controller
    {
        private readonly ApplicationDBContext _db;

        public DashboardController(ApplicationDBContext db)
        {
            _db = db;
        }

        [HttpGet("statistics")]
        public async Task<IActionResult> GetStatistics()
        {
            var today = DateTime.Today;

            var stats = new
            {
                checkIns = await _db.Reservations.CountAsync(r => r.Date_Check_in.Date == today),
                checkOuts = await _db.Reservations.CountAsync(r => r.Date_Check_out.Date == today),
                availableRooms = await _db.Rooms.CountAsync(r => r.Statut == 0),
                totalReservations = await _db.Reservations.CountAsync(r => r.Statut == 0)
            };

            return Ok(stats);
        }

        [HttpGet("reservations/latest")]
        public async Task<IActionResult> GetLatestReservations()
        {
            var reservations = await _db.Reservations
        .Include(r => r.Client)
        .OrderByDescending(r => r.Date_Check_in)
        .Take(6)
        .ToListAsync(); // Get the full objects first

            // Debug logging
            foreach (var res in reservations)
            {
                Console.WriteLine($"Reservation ID: {res.Id}");
                Console.WriteLine($"Status (Statut): {res.Statut}");
                Console.WriteLine($"Status Type: {res.Statut.GetType().FullName}");
            }

            // Then map to anonymous type
            var result = reservations.Select(r => new
            {
                checkInDate = r.Date_Check_in,
                clientName = r.Client != null ? $"{r.Client.Nom} {r.Client.Prenom}" : "Unknown Client",
                status = r.Statut
            });

            return Ok(result);
        }

        [HttpGet("roomtypes")]
        public async Task<IActionResult> GetRoomTypes()
        {
            var totalRooms = await _db.Rooms.CountAsync();

            var roomTypes = await _db.Rooms
                .Include(r => r.TypeChambre)
                .GroupBy(r => new { r.TypeChambreId, r.TypeChambre.Nom })
                .Select(g => new
                {
                    typeName = g.Key.Nom ?? "Unknown Type",
                    percentage = (double)g.Count() / totalRooms * 100
                })
                .ToListAsync();

            return Ok(roomTypes);
        }
    }
}