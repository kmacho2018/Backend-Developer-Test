using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using App.Model.Models;

namespace App.Web.Controllers
{
    public class Localities1Controller : Controller
    {
        private DbTestEntities db = new DbTestEntities();

        // GET: Localities1
        public ActionResult Index()
        {
            return View(db.Localities.ToList());
        }

        // GET: Localities1/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Locality locality = db.Localities.Find(id);
            if (locality == null)
            {
                return HttpNotFound();
            }
            return View(locality);
        }

        // GET: Localities1/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Localities1/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name")] Locality locality)
        {
            if (ModelState.IsValid)
            {
                db.Localities.Add(locality);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(locality);
        }

        // GET: Localities1/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Locality locality = db.Localities.Find(id);
            if (locality == null)
            {
                return HttpNotFound();
            }
            return View(locality);
        }

        // POST: Localities1/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name")] Locality locality)
        {
            if (ModelState.IsValid)
            {
                db.Entry(locality).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(locality);
        }

        // GET: Localities1/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Locality locality = db.Localities.Find(id);
            if (locality == null)
            {
                return HttpNotFound();
            }
            return View(locality);
        }

        // POST: Localities1/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Locality locality = db.Localities.Find(id);
            db.Localities.Remove(locality);
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
