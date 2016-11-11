using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Pubs2;
using Pubs2.Models;

namespace Pubs2.Controllers
{
    public class PubsController : Controller
    {
        private PubsContext db = new PubsContext();

        // GET: Pubs
        public ActionResult Index()
        {
            return View(db.Pubs.ToList());
        }

        // GET: Pubs/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Pubs pubs = db.Pubs.Find(id);
            if (pubs == null)
            {
                return HttpNotFound();
            }
            return View(pubs);
        }

        // GET: Pubs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Pubs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "PubsId,LicenciaFiscal,Domicilio,FechaApertura,Horario")] Pubs pubs)
        {
            if (ModelState.IsValid)
            {
                db.Pubs.Add(pubs);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(pubs);
        }

        // GET: Pubs/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Pubs pubs = db.Pubs.Find(id);
            if (pubs == null)
            {
                return HttpNotFound();
            }
            return View(pubs);
        }

        // POST: Pubs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "PubsId,LicenciaFiscal,Domicilio,FechaApertura,Horario")] Pubs pubs)
        {
            if (ModelState.IsValid)
            {
                db.Entry(pubs).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(pubs);
        }

        // GET: Pubs/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Pubs pubs = db.Pubs.Find(id);
            if (pubs == null)
            {
                return HttpNotFound();
            }
            return View(pubs);
        }

        // POST: Pubs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Pubs pubs = db.Pubs.Find(id);
            db.Pubs.Remove(pubs);
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
