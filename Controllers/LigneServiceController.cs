using hotel_app.Data;
using Microsoft.AspNetCore.Mvc;

namespace hotel_app.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LigneServiceController : Controller
    {
        private readonly ApplicationDBContext _db;
        public LigneServiceController(ApplicationDBContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
