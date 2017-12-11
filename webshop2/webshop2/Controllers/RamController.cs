using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using webshop2.Models;

namespace webshop2.Controllers
{
    public class RamController : Controller
    {
        public ActionResult Index()
        {
            using (new_testEntities db = new new_testEntities())
            {
                return View(db.ram.ToList());
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
        public ActionResult Add_To_Wishlist(int id)
        {
            Console.WriteLine("Add to wishlist is succesfully called");
            using (new_testEntities db = new new_testEntities())
            {
                user user = db.user.FirstOrDefault(x => x.ID == id);
                ram ram = db.ram.FirstOrDefault(x => x.ID == id);
                db.wishlist.Add(new wishlist { ProductId = ram.ID, UserId = user.ID, Quantity = 0, ProductName = "string", Price = (decimal)0.0 });
                db.SaveChanges();
            }
            return View();
        }
    }
}