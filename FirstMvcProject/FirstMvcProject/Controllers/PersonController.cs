using FirstMvcProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FirstMvcProject.Controllers
{
    public class PersonController : Controller
    {
        PersonContext db = new PersonContext();
        //
        // GET: /Person/

        public ActionResult Index()
        {
            var people = db.People.ToList();

            return View(people);
        }

        //
        // GET: /Person/Details/5

        public ActionResult Details(int id)
        {
            var person = db.People.Find(id);

            ViewBag.saddam = "isAwesome";

            return View(person);
        }

        //
        // GET: /Person/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /Person/Create

        [HttpPost]
        public ActionResult Create(Person person)
        {
           
            db.People.Add(person);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        
        //
        // GET: /Person/Edit/5
 
        public ActionResult Edit(int id)
        {
            var person = db.People.Find(id);
            return View(person);
        }

        //
        // POST: /Person/Edit/5

        [HttpPost]
        public ActionResult Edit(Person person)
        {
            db.Entry(person).State = System.Data.EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        //
        // GET: /Person/Delete/5
 
        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Person/Delete/5

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
