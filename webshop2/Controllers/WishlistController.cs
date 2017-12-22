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
            List<wishlist> list_wishlist = new List<wishlist>();
            using (new_testEntities db = new new_testEntities())
            {
                list_wishlist = db.wishlist.ToList();
                return View(list_wishlist);
            }
        }

        // GET: Wishlist/WishlistItems/5
        public ActionResult WishlistItems()
        {
            using (new_testEntities db = new new_testEntities())
            {
                
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
