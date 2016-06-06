using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Data;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class SingInsController : Controller
    {
        private StudentSystemDbContext db = new StudentSystemDbContext();

        // GET: SingIns
        public ActionResult Index()
        {
            return View(db.SingIns.ToList());
        }

        // GET: SingIns/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SingIn singIn = db.SingIns.Find(id);
            if (singIn == null)
            {
                return HttpNotFound();
            }
            return View(singIn);
        }

        // GET: SingIns/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SingIns/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Password,UserName,LastName,Email,Birthday,Gender,Mobile,Name")] SingIn singIn)
        {
            if (ModelState.IsValid)
            {
                db.SingIns.Add(singIn);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(singIn);
        }

        // GET: SingIns/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SingIn singIn = db.SingIns.Find(id);
            if (singIn == null)
            {
                return HttpNotFound();
            }
            return View(singIn);
        }

        // POST: SingIns/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Password,UserName,LastName,Email,Birthday,Gender,Mobile,Name")] SingIn singIn)
        {
            if (ModelState.IsValid)
            {
                db.Entry(singIn).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(singIn);
        }

        // GET: SingIns/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SingIn singIn = db.SingIns.Find(id);
            if (singIn == null)
            {
                return HttpNotFound();
            }
            return View(singIn);
        }

        // POST: SingIns/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            SingIn singIn = db.SingIns.Find(id);
            db.SingIns.Remove(singIn);
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
