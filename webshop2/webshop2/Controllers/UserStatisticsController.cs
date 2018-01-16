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

                return View(db2.Users.ToList());
            }

            
        }

        // GET: UserStatistics/Details/5
        public ActionResult Details(int id)
        {
            return View();
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
                    
                }
                    return RedirectToAction("Index");
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

                
                return View(db2.Users.FirstOrDefault(U => U.Id== id  ));
            }
        }

        // POST: UserStatistics/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: UserStatistics/Delete/5
        public ActionResult Delete(int id)
        {
            return RedirectToAction("Index");
        }

        // POST: UserStatistics/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
