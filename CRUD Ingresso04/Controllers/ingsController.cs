using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CRUD_Ingresso04.Models;

namespace CRUD_Ingresso04.Controllers
{
    public class ingsController : Controller
    {
        private contexto db = new contexto();

        // GET: ings
        public ActionResult Index()
        {
            return View(db.ings.ToList());
        }

        // GET: ings/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ing ing = db.ings.Find(id);
            if (ing == null)
            {
                return HttpNotFound();
            }
            return View(ing);
        }

        // GET: ings/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ings/Create
        // Para se proteger de mais ataques, ative as propriedades específicas a que você quer se conectar. Para 
        // obter mais detalhes, consulte https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "codigo,filme,sessoes,salas,cinemas,cidade")] ing ing)
        {
            if (ModelState.IsValid)
            {
                db.ings.Add(ing);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(ing);
        }

        // GET: ings/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ing ing = db.ings.Find(id);
            if (ing == null)
            {
                return HttpNotFound();
            }
            return View(ing);
        }

        // POST: ings/Edit/5
        // Para se proteger de mais ataques, ative as propriedades específicas a que você quer se conectar. Para 
        // obter mais detalhes, consulte https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "codigo,filme,sessoes,salas,cinemas,cidade")] ing ing)
        {
            if (ModelState.IsValid)
            {
                db.Entry(ing).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(ing);
        }

        // GET: ings/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ing ing = db.ings.Find(id);
            if (ing == null)
            {
                return HttpNotFound();
            }
            return View(ing);
        }

        // POST: ings/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ing ing = db.ings.Find(id);
            db.ings.Remove(ing);
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
