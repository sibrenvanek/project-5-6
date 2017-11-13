using prj56.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace prj56.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ListUsers()
        {
            List<User> Users = new List<User>();
            Users.Add(new User { Username = "FirstUserName", UserId = 2 });
            return View(Users);
        }
    }
}