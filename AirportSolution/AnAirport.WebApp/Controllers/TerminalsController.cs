using AnAirport.Entities;
using AnAirport.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AnAirport.WebApp.Controllers
{
    public class TerminalsController : Controller
    {
        TerminalRepository rep = new TerminalRepository(); 
        public ActionResult Index()
        {
            return View(rep.GetAll());
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Terminal terminal)
        {
            if (ModelState.IsValid)
            {
                rep.Add(terminal);
                return View("Index");
            } else
            {
                return View("Create");
            }

        }

        public ActionResult Details(int id)
        {
            return View(rep.GetByID(id));
        }

        public ActionResult Update(int id)
        {
            return View(rep.GetByID(id));
        }

        [HttpPost]
        public ActionResult Update(Terminal terminal)
        {
            if (ModelState.IsValid)
            {
                rep.Update(terminal);
                return View("Index");
            }
            else
            {
                return View("Create");
            }
        }

        public ActionResult Remove(int id)
        {
            return View(rep.GetByID(id));
        }

        [HttpPost]
        public ActionResult Remove(Terminal terminal)
        {
            rep.Delete(terminal);
            return View("Index");
        }
    }
}