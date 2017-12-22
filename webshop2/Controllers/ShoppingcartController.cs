using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using webshop2.Models;

namespace webshop2.Controllers
{
    public class ShoppingcartController : Controller
    {
        // GET: Shoppingcart
        public ActionResult Index()
        {
            ViewBag.Message = "Your Shopping Cart.";
            List<shoppingcart> listshippingcartitems = new List<shoppingcart>();
            using (new_testEntities db = new new_testEntities())
            {
                listshippingcartitems = db.shoppingcart.ToList();
            }

                return View(listshippingcartitems);
        }
        public ActionResult CheckOut()
        {
            List<shoppingcart> shoppingcartitems = new List<shoppingcart>();
            product product = new product();
            using (new_testEntities db = new new_testEntities())
            {
                shoppingcartitems = db.shoppingcart.ToList();


                foreach (shoppingcart item in shoppingcartitems)
                {
                    product = db.product.FirstOrDefault(x => x.ID == item.ProductId);
                    product.stock = product.stock - 1;
                    if(product.PurchasedQuantity==null) { product.PurchasedQuantity = 1; }
                    product.PurchasedQuantity = product.PurchasedQuantity + 1;
                    db.SaveChanges();
                    db.shoppingcart.Remove(item);
                    db.SaveChanges();
                }

                
            }
            



                return View();
        }

        public ActionResult Delete (int id)
        {
            using (new_testEntities db = new new_testEntities())
            {
                shoppingcart shoppingcart = db.shoppingcart.FirstOrDefault(x => x.ProductId == id);
                db.shoppingcart.Remove(shoppingcart);
                db.SaveChanges();
            }

                return RedirectToAction("Index", "Shoppingcart");
        }
        

    }
}
