using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using webshop2.Models;

namespace webshop2.Controllers
{
    public class SSDController : Controller
    {
        public ActionResult Index()
        {
            using (new_testEntities db = new new_testEntities())
            {
                return View(db.ssd.ToList());
            }
                
        }
        // GET: Image
        [HttpGet]
        public ActionResult View(int id)
        {
            ssd ssdimage = new ssd();

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

                ssdimage = db.ssd.Where(x => x.ID == id).FirstOrDefault();
            }
                return View(ssdimage);
        }
    }
}