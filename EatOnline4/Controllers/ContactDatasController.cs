using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using EatOnline4.Models;

namespace EatOnline4.Controllers
{
    public class ContactDatasController : Controller
    {
        private EatOnline4Context db = new EatOnline4Context();

        // GET: ContactDatas
        public ActionResult Index()
        {
            return View(db.ContactDatas.ToList());
        }

        // GET: ContactDatas/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ContactData contactData = db.ContactDatas.Find(id);
            if (contactData == null)
            {
                return HttpNotFound();
            }
            return View(contactData);
        }

        // GET: ContactDatas/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ContactDatas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ContactDataID,City,Street,FlatNumber,PhoneNumber")] ContactData contactData)
        {
            if (ModelState.IsValid)
            {
                db.ContactDatas.Add(contactData);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(contactData);
        }

        // GET: ContactDatas/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ContactData contactData = db.ContactDatas.Find(id);
            if (contactData == null)
            {
                return HttpNotFound();
            }
            return View(contactData);
        }

        // POST: ContactDatas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ContactDataID,City,Street,FlatNumber,PhoneNumber")] ContactData contactData)
        {
            if (ModelState.IsValid)
            {
                db.Entry(contactData).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(contactData);
        }

        // GET: ContactDatas/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ContactData contactData = db.ContactDatas.Find(id);
            if (contactData == null)
            {
                return HttpNotFound();
            }
            return View(contactData);
        }

        // POST: ContactDatas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ContactData contactData = db.ContactDatas.Find(id);
            db.ContactDatas.Remove(contactData);
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
