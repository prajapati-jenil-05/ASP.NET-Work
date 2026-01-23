using StudentRegistration.DBCONTEXT;
using StudentRegistration.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StudentRegistration.Controllers
{
    public class StudentController : Controller
    {
        studentdb db = new studentdb();

        [HttpGet]
        public ActionResult AddStudent()
        {
            return View(new student_model());
        }

        [HttpPost]
        public ActionResult AddStudent(student_model s1)
        {
            if (ModelState.IsValid)
            {
                db.ADDSTUDENT(s1);
                ViewBag.Message = "Student Added Successfully!";
                ModelState.Clear();
                return View(new student_model());
            }
            return View(s1);
        }
        [HttpGet]
        public ActionResult DeleteStudent()
        {
            return View(new student_model());
        }
        [HttpPost]
        public ActionResult DeleteStudent(student_model s1)
        {
            if (ModelState.IsValid)
            {
                db.DELETESTUDENT(s1);
                ViewBag.Message = "Student Deleted Successfully!";
                ModelState.Clear();
                return View(new student_model());
            }
            return View(s1);
        }
    }
}