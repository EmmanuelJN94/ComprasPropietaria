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
    public class Accounting_entriesController : Controller
    {
        private ComprasContext db = new ComprasContext();

        // GET: Accounting_entries
        public ActionResult Index()
        {
            return View(db.Accounting_entries.ToList());
        }

        // GET: Accounting_entries/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Accounting_entries accounting_entries = db.Accounting_entries.Find(id);
            if (accounting_entries == null)
            {
                return HttpNotFound();
            }
            return View(accounting_entries);
        }

        // GET: Accounting_entries/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Accounting_entries/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "AsientoContableId,AuxiliarId,AsientoContableFecha,AsientoContableDescripcion,AsientoContableCuentaDebito,AsientoContableCuentaCredito,AsientoContableMonto,AsientoContableEstado")] Accounting_entries accounting_entries)
        {
            if (ModelState.IsValid)
            {
                db.Accounting_entries.Add(accounting_entries);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(accounting_entries);
        }

        // GET: Accounting_entries/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Accounting_entries accounting_entries = db.Accounting_entries.Find(id);
            if (accounting_entries == null)
            {
                return HttpNotFound();
            }
            return View(accounting_entries);
        }

        // POST: Accounting_entries/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "AsientoContableId,AuxiliarId,AsientoContableFecha,AsientoContableDescripcion,AsientoContableCuentaDebito,AsientoContableCuentaCredito,AsientoContableMonto,AsientoContableEstado")] Accounting_entries accounting_entries)
        {
            if (ModelState.IsValid)
            {
                db.Entry(accounting_entries).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(accounting_entries);
        }

        // GET: Accounting_entries/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Accounting_entries accounting_entries = db.Accounting_entries.Find(id);
            if (accounting_entries == null)
            {
                return HttpNotFound();
            }
            return View(accounting_entries);
        }

        // POST: Accounting_entries/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Accounting_entries accounting_entries = db.Accounting_entries.Find(id);
            db.Accounting_entries.Remove(accounting_entries);
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
