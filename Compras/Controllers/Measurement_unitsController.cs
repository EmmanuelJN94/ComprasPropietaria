using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Compras.Models;

namespace Compras.Controllers
{
    public class Measurement_unitsController : Controller
    {
        private ComprasContext db = new ComprasContext();

        // GET: Measurement_units
        public ActionResult Index()
        {
            return View(db.Measurement_units.ToList());
        }

        // GET: Measurement_units/Details/5
        public ActionResult Details(decimal id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Measurement_units measurement_units = db.Measurement_units.Find(id);
            if (measurement_units == null)
            {
                return HttpNotFound();
            }
            return View(measurement_units);
        }

        // GET: Measurement_units/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Measurement_units/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "unit_id,unit_name,unit_status")] Measurement_units measurement_units)
        {
            if (ModelState.IsValid)
            {
                db.Measurement_units.Add(measurement_units);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(measurement_units);
        }

        // GET: Measurement_units/Edit/5
        public ActionResult Edit(decimal id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Measurement_units measurement_units = db.Measurement_units.Find(id);
            if (measurement_units == null)
            {
                return HttpNotFound();
            }
            return View(measurement_units);
        }

        // POST: Measurement_units/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "unit_id,unit_name,unit_status")] Measurement_units measurement_units)
        {
            if (ModelState.IsValid)
            {
                db.Entry(measurement_units).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(measurement_units);
        }

        // GET: Measurement_units/Delete/5
        public ActionResult Delete(decimal id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Measurement_units measurement_units = db.Measurement_units.Find(id);
            if (measurement_units == null)
            {
                return HttpNotFound();
            }
            return View(measurement_units);
        }

        // POST: Measurement_units/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(decimal id)
        {
            Measurement_units measurement_units = db.Measurement_units.Find(id);
            db.Measurement_units.Remove(measurement_units);
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
