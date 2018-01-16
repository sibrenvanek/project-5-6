using Microsoft.AspNet.Identity;
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
                using (ApplicationDbContext db2 = new ApplicationDbContext())
                {
                    string userid = User.Identity.GetUserId();
                    return View(db.wishlist.Where(item => item.UserId == userid).ToList());
                }
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

        public ActionResult Remove_From_Wishlist(int id)
        {
            //Console.WriteLine("Add to wishlist is succesfully called");
            int? ProductId;
            ProductId = id;


            using (new_testEntities db = new new_testEntities())
            {

                //user user = db.user.FirstOrDefault(x => x.ID == id);
                wishlist Wishlist = db.wishlist.FirstOrDefault(x => x.ProductId == id);


                db.SaveChanges();

                db.wishlist.Remove(Wishlist);
                    db.SaveChanges();


                return RedirectToAction("Index", "Wishlist");
            }

        }

        public ActionResult Add_To_Cart(int id)
        {
            //Console.WriteLine("Add to wishlist is succesfully called");
            int? ProductId;
            ProductId = id;


            using (new_testEntities db = new new_testEntities())
            {

                //user user = db.user.FirstOrDefault(x => x.ID == id);
                product product = db.product.FirstOrDefault(x => x.ID == id);
                shoppingcart shoppingcart = db.shoppingcart.FirstOrDefault(x => x.ProductId == id);
                wishlist Wishlist = db.wishlist.FirstOrDefault(x => x.ProductId == id);

                if (shoppingcart == null)
                {

                    db.shoppingcart.Add(new shoppingcart { ProductId = Wishlist.ProductId, /*UserId = user.ID,*/ Quantity = Wishlist.Quantity, ProductName = Wishlist.ProductName, Price = Wishlist.Price, Imagepath = Wishlist.Imagepath });
                    db.SaveChanges();
                }
                else
                {
                    shoppingcart.Quantity += Wishlist.Quantity;
                    db.SaveChanges();
                }

                return RedirectToAction("Index", "Shoppingcart");
            }
        }

        // GET: Wishlist/WishlistItems/5
        public ActionResult WishlistItems()
        {
            return View();
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
