using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
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
            if (Request.HttpMethod == "POST")
            {
                return CheckOut();
            }
            else
            {
                ViewBag.Message = "Your Shopping Cart.";
                List<shoppingcart> listshippingcartitems = new List<shoppingcart>();
                using (new_testEntities db = new new_testEntities())
                {
                    listshippingcartitems = db.shoppingcart.ToList();
                }

                return View(listshippingcartitems);
            }
        }
        public ActionResult CheckOut()
        {
            List<shoppingcart> shoppingcartitems = new List<shoppingcart>();
            product product = new product();
            EmailService mail = new EmailService();
            IdentityMessage message = new IdentityMessage();
            var keys = Request.Form.AllKeys;
            message.Destination = Request.Form.Get(keys[0]);
            message.Subject = "Order confirmation Bright Yellow";
            message.Body = "Thank you for your purchase. <br />You purchased the following items:";
            using (new_testEntities db = new new_testEntities())
            {
                shoppingcartitems = db.shoppingcart.ToList();

                foreach (shoppingcart item in shoppingcartitems)
                {
                    product = db.product.FirstOrDefault(x => x.ID == item.ProductId);
                    product.stock = product.stock - item.Quantity;
                    message.Body = message.Body + "<br />" + product.ProductName;
                    if (product.PurchasedQuantity==null) { product.PurchasedQuantity = 1; }
                    product.PurchasedQuantity = product.PurchasedQuantity + item.Quantity;
                    db.SaveChanges();
                    db.shoppingcart.Remove(item);
                    db.SaveChanges();
                }
                mail.SendAsync(message);
                
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
