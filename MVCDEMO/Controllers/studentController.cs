using MVCDEMO.DBCONTEXT;
using MVCDEMO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCDEMO.Controllers
{
    public class studentController : Controller
    {
        studentdb db = new studentdb();

        [HttpGet]
        public ActionResult AddStudent()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddStudent(student s1)
        {
            if (ModelState.IsValid)
            {
                db.ADDSTUDENT(s1);
                //return View();
                Response.Write("Added !!!!");
            }
            return View();
        }
    }
}