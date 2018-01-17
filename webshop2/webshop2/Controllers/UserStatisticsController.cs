using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using webshop2.Models;

namespace webshop2.Controllers
{
    public class UserStatisticsController : Controller
    {
        // GET: UserStatistics
        public ActionResult Index()
        {
            using (ApplicationDbContext db2 = new ApplicationDbContext())
            {
                List<ApplicationUser> listusers = new List<ApplicationUser>();
                string userid = User.Identity.GetUserId();
                if (User.IsInRole("Admin"))
                {
                    listusers = db2.Users.ToList();
                    return View(listusers);
                }
                else
                    return View(listusers);
                
            }

            
        }

        // GET: UserStatistics/Details/5
        public ActionResult Details(string id)
        {
            using (ApplicationDbContext db2 = new ApplicationDbContext())
            {
                ApplicationUser user = new ApplicationUser();
                
                string userid = User.Identity.GetUserId();
                if (User.IsInRole("Admin"))
                {
                    user = db2.Users.FirstOrDefault(x => x.Id == id);
                    return View(user);
                }
                else
                    return View(user);

            }
        }

        // GET: UserStatistics/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: UserStatistics/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                using (ApplicationDbContext db2 = new ApplicationDbContext())
                {
                    string userid = User.Identity.GetUserId();
                    if (User.IsInRole("Admin"))
                    {
                        //create logic 
                        return RedirectToAction("../Account/Register");
                    }
                    else
                        return RedirectToAction("Index");

                }
                
            }
            catch
            {
                return View();
            }
        }

        // GET: UserStatistics/Edit/5
        public ActionResult Edit(string id)
        {

                using (ApplicationDbContext db2 = new ApplicationDbContext())
                {
                ApplicationUser user = new ApplicationUser();
                    
                    if (User.IsInRole("Admin"))
                    {
                    //edit logic 
                    string userid = User.Identity.GetUserId();
                    user = db2.Users.FirstOrDefault(U => U.Id == id);
                    return View(user);
                    }
                    else
                        return View(user);

                }
                
            
        }

        // POST: UserStatistics/Edit/5
        [HttpPost]
        public ActionResult Edit(string id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                using (ApplicationDbContext db2 = new ApplicationDbContext())
                {
                    ApplicationUser user = new ApplicationUser();

                    if (User.IsInRole("Admin"))
                    {
                        //edit logic 
                        string userid = User.Identity.GetUserId();
                        user = db2.Users.FirstOrDefault(U => U.Id == id);
                        return View(user);
                    }
                    else
                        return View(user);

                }
            }
            catch
            {
                return View();
            }
        }

        // GET: UserStatistics/Delete/5
        public ActionResult Delete(string id)
        {
            using (ApplicationDbContext db2 = new ApplicationDbContext())
            {
                string userid = User.Identity.GetUserId();
                if (User.IsInRole("Admin"))
                {
                    //delete logic 
                    ApplicationUser user = new ApplicationUser();
                    user = db2.Users.FirstOrDefault(x => x.Id == id);
                    db2.Users.Remove(user);
                    db2.SaveChanges();
                    return RedirectToAction("Index");
                }
                else
                    return RedirectToAction("Index");

            }
        }

        // POST: UserStatistics/Delete/5
        [HttpPost]
        public ActionResult Delete(string id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
                using (ApplicationDbContext db2 = new ApplicationDbContext())
                {
                    string userid = User.Identity.GetUserId();
                    if (User.IsInRole("Admin"))
                    {
                        //delete logic 
                        ApplicationUser user = new ApplicationUser();
                        user = db2.Users.FirstOrDefault(x => x.Id == id);
                        db2.Users.Remove(user);
                        db2.SaveChanges();
                        return RedirectToAction("Index");
                    }
                    else
                        return RedirectToAction("Index");

                }
            }
            catch
            {
                return View();
            }
        }
    }
}
