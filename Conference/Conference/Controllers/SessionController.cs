using Conference.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Conference.Controllers
{
    public class SessionController : Controller
    {
        //
        // GET: /Session/

        public ActionResult Index()
        {
            ConferenceContext db = new ConferenceContext();
            List<Session> sessions = db.Sessions.ToList();

            return View(sessions);
        }

        [Authorize(Roles = "Administrator")]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost()]
        public ActionResult Create(Session session)
        {
            if (!ModelState.IsValid)
            {
                return View(session);
            }
            try
            {
                ConferenceContext db = new ConferenceContext();
                db.Sessions.Add(session);
                db.SaveChanges();
            }
            catch(Exception ex)
            {
                ModelState.AddModelError("Error", ex.Message);
                return View(session);
            }

            TempData["Message"] = "Created" + session.Title;
            return RedirectToAction("Index");
        }
    }
}
