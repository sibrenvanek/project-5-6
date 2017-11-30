using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using webshop2.Models;

namespace webshop2.Controllers
{
    public class ImageController : Controller
    {
        // GET: Image
        public ActionResult View(int id)
        {
            ram ramimage = new ram();

            using (new_testEntities1 db = new new_testEntities1())
            {
                db.ram.Add(new ram { ImagePath = "~/Image/ram1.jpg" });
                db.SaveChanges();
            
                ramimage = db.ram.Where(x => x.RAMId == id).FirstOrDefault();
            }
                return View(ramimage);
        }
    }
}