using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
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
                    int productid = item.ProductId;
                    string userid = User.Identity.GetUserId();
                    int quantity = (int)item.Quantity;
                    DateTime date = DateTime.Now;
                    string productname = product.ProductName;
                    string imagePath = product.imagepath;
                    purchasehistory ph = new purchasehistory
                    {
                        ProductID = productid,
                        UserID = userid,
                        Quantity = quantity,
                        PurchaseDate = date,
                        ProductName = productname,
                        imagepath = imagePath
                    };
                    db.purchasehistory.Add(ph);
                    db.SaveChanges();
                }
                mail.SendAsync(message);
                
            }
            return View();
        }
        public ActionResult Plus_To_Cart(int id)
        {
            //Console.WriteLine("Add to Shoppingcart is succesfully called");
            int? ProductId;
            ProductId = id;


            using (new_testEntities db = new new_testEntities())
            {

                //user user = db.user.FirstOrDefault(x => x.ID == id);
                shoppingcart Shoppingcart = db.shoppingcart.FirstOrDefault(x => x.ProductId == id);


                Shoppingcart.Quantity += 1;
                db.SaveChanges();


                return RedirectToAction("Index", "Shoppingcart");
            }

        }
        public ActionResult Minus_To_Cart(int id)
        {
            //Console.WriteLine("Add to shoppingcart is succesfully called");
            int? ProductId;
            ProductId = id;


            using (new_testEntities db = new new_testEntities())
            {

                //user user = db.user.FirstOrDefault(x => x.ID == id);
                shoppingcart Shoppingcart = db.shoppingcart.FirstOrDefault(x => x.ProductId == id);


                Shoppingcart.Quantity -= 1;
                db.SaveChanges();

                if (Shoppingcart.Quantity <= 0)
                {

                    db.shoppingcart.Remove(Shoppingcart);
                    db.SaveChanges();
                }


                return RedirectToAction("Index", "Shoppingcart");
            }

        }

        public ActionResult Remove_From_Cart(int id)
        {
            //Console.WriteLine("Add to shoppingcart is succesfully called");
            int? ProductId;
            ProductId = id;


            using (new_testEntities db = new new_testEntities())
            {

                //user user = db.user.FirstOrDefault(x => x.ID == id);
                shoppingcart Shoppingcart = db.shoppingcart.FirstOrDefault(x => x.ProductId == id);


                db.SaveChanges();

                db.shoppingcart.Remove(Shoppingcart);
                db.SaveChanges();


                return RedirectToAction("Index", "Shoppingcart");
            }

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
