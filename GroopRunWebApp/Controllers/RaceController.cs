using GroopRunWebApp.Data;
using GroopRunWebApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace GroopRunWebApp.Controllers
{
    public class RaceController : Controller
    {
        private readonly ApplicationDbContext _context;

        public RaceController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            List<Race> Races = _context.Races.ToList();
            return View(Races);
        }
    }
}
