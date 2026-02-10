using Microsoft.AspNetCore.Mvc;
using mvc_core.database;
using mvc_core.Models;

namespace mvc_core.Controllers
{
    public class StudentController : Controller
    {
        private readonly student_db _db;

        public StudentController(student_db db)
        {
            _db = db;
        }

        // GET: Student
        public IActionResult Index()
        {
            var students = _db.studentable.ToList();
            return View(students);
        }

        // GET: Student/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Student/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(student_model obj)
        {
            if (ModelState.IsValid)
            {
                _db.studentable.Add(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj);
        }

        // GET: Student/Edit/5
        public IActionResult Edit(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var studentFromDb = _db.studentable.Find(id);

            if (studentFromDb == null)
            {
                return NotFound();
            }

            return View(studentFromDb);
        }

        // POST: Student/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(student_model obj)
        {
            if (ModelState.IsValid)
            {
                _db.studentable.Update(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj);
        }

        // GET: Student/Delete/5
        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var studentFromDb = _db.studentable.Find(id);

            if (studentFromDb == null)
            {
                return NotFound();
            }

            return View(studentFromDb);
        }

        // POST: Student/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeletePOST(int? id)
        {
            var obj = _db.studentable.Find(id);
            if (obj == null)
            {
                return NotFound();
            }

            _db.studentable.Remove(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
