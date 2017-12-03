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
        // GET: Image
        public ActionResult View(int id)
        {
            ram ramimage = new ram();

            using (new_testEntities3 db = new new_testEntities3())
            {
                db.ram.Add(new ram {
                    Brand ="testbrand",
                    CompositionOfMemory ="wut",
                    MemoryType ="testtype",
                    Clockspeed=1,
                    CASlatency=1,
                    Voltage=1,
                    MemoryModuleConnection=50,
                    MemorySuitableFor="datatest",
                    ImagePath = "C:/Users/erikv/Desktop/PRJ 56/project-5-6 - kopie/webshop2/webshop2/Content/ram1.jpg" });
                 
                db.SaveChanges();

                ramimage = db.ram.Where(x => x.RamId == id).FirstOrDefault();
            }
                return View(ramimage);
        }
    }
}