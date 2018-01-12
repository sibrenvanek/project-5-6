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
        public ActionResult Plus_To_Wishlist(int id)
        {
            //Console.WriteLine("Add to wishlist is succesfully called");
            int? ProductId;
            ProductId = id;


            using (new_testEntities db = new new_testEntities())
            {

                //user user = db.user.FirstOrDefault(x => x.ID == id);
                wishlist Wishlist = db.wishlist.FirstOrDefault(x => x.ProductId == id);


                Wishlist.Quantity += 1;
                db.SaveChanges();


                return RedirectToAction("Index", "Wishlist");
            }

        }
        public ActionResult Minus_To_Wishlist(int id)
        {
            //Console.WriteLine("Add to wishlist is succesfully called");
            int? ProductId;
            ProductId = id;


            using (new_testEntities db = new new_testEntities())
            {

                //user user = db.user.FirstOrDefault(x => x.ID == id);
                wishlist Wishlist = db.wishlist.FirstOrDefault(x => x.ProductId == id);


                Wishlist.Quantity -= 1;
                db.SaveChanges();

                if (Wishlist.Quantity <= 0)
                {

                    db.wishlist.Remove(Wishlist);
                    db.SaveChanges();
                }


                return RedirectToAction("Index", "Wishlist");
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
