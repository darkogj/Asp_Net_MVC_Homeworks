using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Homework.Controllers
{
    public class UsersController : Controller
    {
        // GET: Users
        public string Index()
        {
            return "this is the index";
        }

        public ActionResult Add()
        {
            var users = new List<string>() { "Hajan", "Barry", "John" };
            ViewBag.Users = users;
            return View();
        }

        public int Remove()
        {
            return 3;
        }

        public string Edit()
        {
            return "Editing the users yo";
        }
    }
}