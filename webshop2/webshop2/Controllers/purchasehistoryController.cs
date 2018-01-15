using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using webshop2.Models;

namespace webshop2.Controllers
{
    public class purchasehistoryController : Controller
    {
        // GET: purchasehistory
        public ActionResult Index()
        {
            using(new_testEntities db = new new_testEntities())
            {
                using (ApplicationDbContext db2 = new ApplicationDbContext())
                {
                    string userID = User.Identity.GetUserId();
                    return View(db.purchasehistory.Where(ph => ph.UserID == userID).ToList());
                }
            }
        }

        // GET: purchasehistory/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: purchasehistory/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: purchasehistory/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: purchasehistory/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: purchasehistory/Edit/5
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

        // GET: purchasehistory/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: purchasehistory/Delete/5
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
