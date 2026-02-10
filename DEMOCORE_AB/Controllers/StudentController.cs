using Microsoft.AspNetCore.Mvc;

namespace DEMOCORE_AB.Controllers
{
    public class StudentController : Controller
    {
        private readonly database.AppDbContext _context;

        public StudentController(database.AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View(_context.students.ToList());
        }

        public IActionResult add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult add(Models.Student student)
        {
            if (ModelState.IsValid)
            {
                _context.students.Add(student);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(student);
        }
    }
}
