using Microsoft.AspNetCore.Mvc;

namespace GroopRunWebApp.Controllers
{
    public class RaceController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
