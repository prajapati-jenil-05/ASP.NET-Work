using Microsoft.AspNetCore.Mvc;

namespace CMS2026.Controllers
{
    public class LoanController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ViewAll()
        {
            return View();
        }

        public IActionResult NewApplication()
        {
            return View();
        }
        public IActionResult UpdateApplication()
        {
            return View();
        }
        public IActionResult DiscardApplication()
        {
            return View();
        }
    }
}
