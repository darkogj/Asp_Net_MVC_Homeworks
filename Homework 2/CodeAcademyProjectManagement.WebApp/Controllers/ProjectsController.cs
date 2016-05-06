using CodeAcademyProjectManagement.WebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Linq;

namespace CodeAcademyProjectManagement.WebApp.Controllers
{

    public class ProjectsController : Controller
    {
        // GET: Projects
        public ActionResult Index()
        {
            // List of all projects + favorite projects
            // Important: keep in mind longer list of projects migt need pagination

            return View();
        }

        [HttpPost]

        public ActionResult Create(string name, string desc, int estimate)
        {
            return RedirectToAction("Test", new
            {
                name = name,
                desc = desc,
                estimate = estimate
            });
        }

        public ActionResult Test(string name, string desc, int estimate)
        {
            ViewBag.Name = name;
            ViewBag.Desc = desc;
            ViewBag.Estimate = estimate;
            return View();
        }

        public ActionResult Create()
        {
            return View();
        }

        public ActionResult Update(int id)
        {
            var projects = Projects.GetAll();
            var foundProject = projects.First(x => x.ID == id);
            ViewBag.project = foundProject;
            return View();
        }

        [HttpPost]
        public ActionResult Update(int id, string name, string desc, int estimate)
        {
            return RedirectToAction("Test", new
            {
                name = name,
                desc = desc,
                estimate = estimate
            });
        }

        public ActionResult Delete()
        {
            return View();
        }

        public ActionResult Favorite(int id, bool favorite)
        {
            return View();
        }
    }
}