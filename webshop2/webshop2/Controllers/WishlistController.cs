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
        [HttpGet]
        public ActionResult Index() //laten zien van de wishlist
        {
            
            using (new_testEntities db = new new_testEntities())
            {
                user usertest1 = db.user.FirstOrDefault(x => x.ID == 1);
                ram ramtest1 = db.ram.FirstOrDefault(x => x.ID == 1);
                db.wishlist.Add(new wishlist {ProductId=ramtest1.ID,UserId=usertest1.ID, Quantity = 0, ProductName = "string", Price = (decimal)0.0 });
                //db.SaveChanges();
                //return View(db.wishlist.ToList());
                return View(db.wishlist.ToList());
            }
        }

        // GET: Wishlist/WishlistItems/5
        public ActionResult WishlistItems()
        {
            using (new_testEntities db = new new_testEntities())
            {
                db.wishlist.Add(new wishlist { Quantity = 0, ProductName = "string", Price = (decimal)0.0 });
                db.SaveChanges();
                //return View(db.wishlist.ToList());
                return View();
            }
            
        }

        public ActionResult View(int id)
        {
            wishlist wishlist = new wishlist();
            using (new_testEntities db = new new_testEntities())
            {
                wishlist = db.wishlist.FirstOrDefault(x => x.ProductId == 1);
            }

            return View(wishlist);
        }

        
    }
}
