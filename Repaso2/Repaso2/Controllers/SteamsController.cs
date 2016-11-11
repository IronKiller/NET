using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Repaso2.Models;

namespace Repaso2.Controllers
{
    public class SteamsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Steams
        public ActionResult Index()
        {
            return View(db.Steams.ToList());
        }

        // GET: Steams/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Steam steam = db.Steams.Find(id);
            if (steam == null)
            {
                return HttpNotFound();
            }
            return View(steam);
        }

        // GET: Steams/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Steams/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "SteamId,Employees,Games,CreationDate")] Steam steam)
        {
            if (ModelState.IsValid)
            {
                db.Steams.Add(steam);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(steam);
        }

        // GET: Steams/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Steam steam = db.Steams.Find(id);
            if (steam == null)
            {
                return HttpNotFound();
            }
            return View(steam);
        }

        // POST: Steams/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "SteamId,Employees,Games,CreationDate")] Steam steam)
        {
            if (ModelState.IsValid)
            {
                db.Entry(steam).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(steam);
        }

        // GET: Steams/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Steam steam = db.Steams.Find(id);
            if (steam == null)
            {
                return HttpNotFound();
            }
            return View(steam);
        }

        // POST: Steams/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Steam steam = db.Steams.Find(id);
            db.Steams.Remove(steam);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
