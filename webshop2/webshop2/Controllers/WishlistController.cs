using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using webshop2.Models;

namespace webshop2.Controllers
{
    public class WishlistController : Controller
    {
        // GET: Wishlist
        public ActionResult Index() //laten zien van de wishlist
        {
            wishlist w = new wishlist();
            return View();
        }

        // GET: Wishlist/WishlistItems/5
        public ActionResult WishlistItems()
        {
            using (new_testEntities1 dbWishlist = new new_testEntities1())
            {
                dbWishlist.wishlist.Add(new wishlist { Quantity = 0, ImagePath = "string", Name = "string", Price = 0.0f, DeliveryTime = "string" });
                //return View(db.wishlist.ToList());
                return View(dbWishlist);
            }
            
        }

        // GET: Wishlist/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Wishlist/Create
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

        // GET: Wishlist/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Wishlist/Edit/5
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

        // GET: Wishlist/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Wishlist/Delete/5
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
