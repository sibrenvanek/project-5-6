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

            using (new_testEntities db = new new_testEntities())
            {
                //db.ram.Add(new ram
                //{
                //    Brand = "testbrand",
                //    CompositionOfMemory = "wut",
                //    MemoryType = "testtype",
                //    Clockspeed = 1,
                //    CASlatency = 1,
                //    Voltage = 1,
                //    MemoryModuleConnection = 50,
                //    MemorySuitableFor = "datatest",
                //    ImagePath = "C:/Users/Erik/Desktop/Prj5-6/project-5-6 - Copy/webshop2/webshop2/Contentram1.jpg"
                //});
                
                //db.SaveChanges();

                ram = db.ram.Where(x => x.ID == id).FirstOrDefault();
            }
                return View(ram);
        }
        [HttpGet]
        public void Add_To_Wishlist(int id)
        {
            //Console.WriteLine("Add to wishlist is succesfully called");
            using (new_testEntities db = new new_testEntities())
            {
                
                user user = db.user.FirstOrDefault(x => x.ID == id);
                ram ram = db.ram.FirstOrDefault(x => x.ID == id);
                wishlist Wishlist = db.wishlist.FirstOrDefault(x => x.ProductId == id);

                if (Wishlist == null)
                {
                    
                    db.wishlist.Add(new wishlist { ProductId = ram.ID, UserId = user.ID, Quantity = 1, ProductName = "string", Price = (decimal)0.0 });
                    db.SaveChanges();
                }
                else
                {
                    Wishlist.Quantity +=1;
                    db.SaveChanges();
                }


            }
            
        }
    }
}