using EatOnline4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EatOnline4.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        public ActionResult Index()
        {
            using (EatOnline4Context db = new EatOnline4Context())
            {
                return View(db.Users.ToList());
            }
        }

        //Register
        public ActionResult Register()
        {
            return View();
        }

        //Register
        [HttpPost]
        public ActionResult Register(User user)
        {
            if (ModelState.IsValid)
            {
                using (EatOnline4Context db = new EatOnline4Context())
                {
                    user.AuthSecurity = Guid.NewGuid().ToString();
                    db.Users.Add(user);
                    db.SaveChanges();
                }
                ModelState.Clear();
                ViewBag.Message = user.FirstName + "" + user.LastName + "sucessfuly registered.";
            }
            return View();
        }

        
        //Login
        public ActionResult Login()
        {
            return View();
        }

        //Login
        [HttpPost]
        public ActionResult Login(User user)
        {
            using (EatOnline4Context db = new EatOnline4Context())
            {
                var usr = db.Users.Single(u => u.UserName == user.UserName && u.Password == user.Password);
                if (usr != null)
                {
                    Session["UserID"] = usr.UserID.ToString();
                    Session["UserName"] = usr.UserName.ToString();
                    Session["UserToken"] = usr.AuthSecurity;
                    return RedirectToAction("LoggedIn");
                }
                else
                {
                    ModelState.AddModelError("", "UserName or Password is wrong");
                }
            }
            return View();
        }

        //LoggedIn
        public ActionResult LoggedIn()
        {
            if (Session["UserID"] != null)
            {
                return View();
            }
            else
            {
                return RedirectToAction("Login");
            }
        }




    }
}