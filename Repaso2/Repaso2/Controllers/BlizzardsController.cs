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
    public class BlizzardsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Blizzards
        public ActionResult Index()
        {
            return View(db.Blizzards.ToList());
        }

        // GET: Blizzards/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Blizzard blizzard = db.Blizzards.Find(id);
            if (blizzard == null)
            {
                return HttpNotFound();
            }
            return View(blizzard);
        }

        // GET: Blizzards/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Blizzards/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "BlizzardId,Employees,Games,CreationDate")] Blizzard blizzard)
        {
            if (ModelState.IsValid)
            {
                db.Blizzards.Add(blizzard);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(blizzard);
        }

        // GET: Blizzards/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Blizzard blizzard = db.Blizzards.Find(id);
            if (blizzard == null)
            {
                return HttpNotFound();
            }
            return View(blizzard);
        }

        // POST: Blizzards/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "BlizzardId,Employees,Games,CreationDate")] Blizzard blizzard)
        {
            if (ModelState.IsValid)
            {
                db.Entry(blizzard).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(blizzard);
        }

        // GET: Blizzards/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Blizzard blizzard = db.Blizzards.Find(id);
            if (blizzard == null)
            {
                return HttpNotFound();
            }
            return View(blizzard);
        }

        // POST: Blizzards/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Blizzard blizzard = db.Blizzards.Find(id);
            db.Blizzards.Remove(blizzard);
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
