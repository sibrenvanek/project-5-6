using prj56.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace prj56.Controllers
{
    public class Db_Controller : Controller
    {
        //db_Entities DB = new db_Entities();
        
        // GET: Db
        public ActionResult Index()
        {
           

                return View();
        }

        public ActionResult Cases()
        {
            List<Case> ListCases = new List<Case>();
            ListCases.Add(new Case { CaseId = 1 });



            return View(ListCases);
        }

    }
}