using NormalMvcApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NormalMvcApplication.Controllers
{
    public class StudentController : Controller
    {
        public StudentContext db = new StudentContext();

        //
        // GET: /Student/

        public ActionResult Index()
        {
            var stud = db.Students.ToList();  // here Students ta okhane dici bole ekhane dici, but keno?
            return View(stud);
        }

        //
        // GET: /Student/Details/5

        public ActionResult Details(int id)
        {
            var stud = db.Students.Find(id);
            return View(stud);
        }

        //
        // GET: /Student/Create

        public ActionResult Create()
        {
            
            return View();
        }

        //
        // POST: /Student/Create

        [HttpPost]
        public ActionResult Create(Student stud)  //  here Student class ta deua hoyece keno parameter hisebe?
        {
            db.Students.Add(stud);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        //
        // GET: /Student/Edit/5

        public ActionResult Edit(int id)
        {
            var stud = db.Students.Find(id);
            return View(stud);
        }

        //
        // POST: /Student/Edit/5

        [HttpPost]
        public ActionResult Edit(Student stud)
        {
            db.Entry(stud).State = System.Data.EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        //
        // GET: /Student/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Student/Delete/5

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
