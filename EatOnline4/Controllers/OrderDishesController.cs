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
    public class OrderDishesController : Controller
    {
        private EatOnline4Context db = new EatOnline4Context();

        // GET: OrderDishes
        public ActionResult Index()
        {
            return View(db.OrderDishes.ToList());
        }

        // GET: OrderDishes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            OrderDish orderDish = db.OrderDishes.Find(id);
            if (orderDish == null)
            {
                return HttpNotFound();
            }
            return View(orderDish);
        }

        // GET: OrderDishes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: OrderDishes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "OrderDishID,Count")] OrderDish orderDish)
        {
            if (ModelState.IsValid)
            {
                db.OrderDishes.Add(orderDish);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(orderDish);
        }

        // GET: OrderDishes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            OrderDish orderDish = db.OrderDishes.Find(id);
            if (orderDish == null)
            {
                return HttpNotFound();
            }
            return View(orderDish);
        }

        // POST: OrderDishes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "OrderDishID,Count")] OrderDish orderDish)
        {
            if (ModelState.IsValid)
            {
                db.Entry(orderDish).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(orderDish);
        }

        // GET: OrderDishes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            OrderDish orderDish = db.OrderDishes.Find(id);
            if (orderDish == null)
            {
                return HttpNotFound();
            }
            return View(orderDish);
        }

        // POST: OrderDishes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            OrderDish orderDish = db.OrderDishes.Find(id);
            db.OrderDishes.Remove(orderDish);
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
