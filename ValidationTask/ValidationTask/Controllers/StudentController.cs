using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ValidationTask.Models;

namespace ValidationTask.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Student student)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("Index", "Home");
            }
            return View(student);
        }
        public ActionResult Submit(Student student)
        {
            //ViewBag.BookName = Request["Title"];
            //ViewBag.BookName = form["Title"];
            ViewBag.BookName = student.name;

            return View();
        }
    }
}