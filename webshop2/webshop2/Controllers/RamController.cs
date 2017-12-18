using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Services;
using webshop2.Models;

namespace webshop2.Controllers
{
    public class RamController : Controller
    {
        int? ID;
        public ActionResult Index()
        {
            
            if (Request.HttpMethod == "POST")
            {
                var keys = Request.Form.AllKeys;

                var min = Request.Form.Get(keys[0]);
                var max = Request.Form.Get(keys[1]);

                if (min == "")
                {
                    if(max == "")
                    {
                        return FilterRam(null, null);
                    }
                    else
                    {
                        return FilterRam(null, Convert.ToInt32(max));
                    }
                }
                else
                {
                    if (max == "")
                    {
                        return FilterRam(Convert.ToInt32(min), null);
                    }
                    else
                    {
                        return FilterRam(Convert.ToInt32(min), Convert.ToInt32(max));
                    }
                }
            }
            else
            {
                return FilterRam(null, null);
            }

        }
        [WebMethod]
        public ActionResult FilterRam(int? min, int? max)
        {
            using(new_testEntities db = new new_testEntities())
            {
                if(min == null)
                {
                    if (max == null)
                    {
                        return View(db.ram.ToList());
                    }
                    else
                    {
                        return View(db.ram.Where(r => r.Price <= max).ToList());
                    }
                }
                else
                {
                    if (max == null)
                    {
                        return View(db.ram.Where(r => r.Price >= min).ToList());
                    }
                    else
                    {
                        return View(db.ram.Where(r => r.Price >= min && r.Price <= max).ToList());
                    }
                }
            }
        }

        // GET: Image
        [HttpGet]
        public ActionResult View(int? id)
        {
            ram ram = new ram();
            ID = id;
            using (new_testEntities db = new new_testEntities())
            {
                //db.product.Add(new product
                //{
                //    ID = 1,
                //    price = 80,
                //    imagepath = "~/images/ram/ram1.jpg",
                //    stock = 100,
                //    Brand = "Kingston",
                //    Supplier = "testsupplier"
                //});
                //db.SaveChanges();
                //product product = db.product.FirstOrDefault(x => x.ID == id);
                //db.ram.Add(new ram
                //{
                //    ID = product.ID,
                //    Brand = "Kingston",
                //    CompositionOfMemory = "1x",
                //    MemoryType = "DDR3",
                //    Clockspeed = 2133,
                //    CASlatency = 15,
                //    Voltage = (float)1.2 ,
                //    MemoryModuleConnection = 1,
                //    MemorySuitableFor = "Desktop",
                //    ImagePath = "~/images/ram/ram1.jpg",
                //    Name = "Kingston123",
                //    Price = 80,
                //    Ramsize = 8
                //});

                //db.SaveChanges();

                ram = db.ram.Where(x => x.ID == ID).FirstOrDefault();
            }
                return View(ram);
        }
        //[HttpGet]
        public ActionResult Add_To_Wishlist(int id)
        {
            //Console.WriteLine("Add to wishlist is succesfully called");
            ID = id;
            

            using (new_testEntities db = new new_testEntities())
            {

                user user = db.user.FirstOrDefault(x => x.ID == id);
                product product = db.product.FirstOrDefault(x => x.ID == id);
                wishlist Wishlist = db.wishlist.FirstOrDefault(x => x.ProductId == id);

                if (Wishlist == null)
                {

                    db.wishlist.Add(new wishlist { ProductId = product.ID, UserId = user.ID, Quantity = 1, ProductName = "string", Price = (decimal)0.0 , Imagepath = product.imagepath });
                    db.SaveChanges();
                }
                else
                {
                    Wishlist.Quantity += 1;
                    db.SaveChanges();
                }

                return RedirectToAction("View/" + ID, "Ram");
            }

        }
    }
}