using prj56.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace prj56.Controllers
{
    public class PeopleController : Controller
    {
        // GET: People
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult ListPeople()
        {
            List<PeopleModel> People = new List<PeopleModel>();
            People.Add(new PeopleModel { Name = "Erik", ID = 1 });

            

            return View(People);
        }
    }
}