using hotel_app.Data;
using Microsoft.AspNetCore.Mvc;

namespace hotel_app.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SejourController : Controller
    {
        private readonly ApplicationDBContext _db;
        public SejourController(ApplicationDBContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
