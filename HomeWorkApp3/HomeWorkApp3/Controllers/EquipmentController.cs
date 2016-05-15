using HomeWorkApp3.Helpers;
using HomeWorkApp3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HomeWorkApp3.Controllers
{
    public class EquipmentController : Controller
    {
        Cache cache = new Cache();
        LoginTriesManager loginManager = new LoginTriesManager();
        DisabledTimerManager timer = new DisabledTimerManager();

        // GET: Equipment
        public ActionResult Index()
        {
            var equipmentItems = cache.GetEquipmentItemsRows();
            return View(equipmentItems);
        }

        public ActionResult SearchResults(string searchTerm)
        {
            var equipmentItems = cache.GetEquipmentItemsRows();
            var filteredItems = equipmentItems.Where(i => i.Name.ToLower().Contains(searchTerm.ToLower())).ToList();
            return View("Index", filteredItems);
        }

        public ActionResult SearchByAssignee(string assignee)
        {
            var equipmentItems = cache.GetEquipmentItemsRows();
            var filteredItems = equipmentItems.Where(i => i.AssignedTo == assignee);
            return View("Index", filteredItems);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Equipment equipment)
        {
            if (ModelState.IsValid)
            {
                cache.AddNewEquipmentItem(equipment);
                return RedirectToAction("Index");
            }
            return View();
        }

        public ActionResult Details(int id)
        {
            var equipmentPiece = cache.GetEquipmentItemsRows().Single(e => e.ID == id);
            return View(equipmentPiece);
        }

        public ActionResult Edit(int id)
        {
            var equipmentPiece = cache.GetEquipmentItemsRows().Single(e => e.ID == id);
            return View(equipmentPiece);
        }

        [HttpPost]
        public ActionResult Edit(Equipment equipment)
        {
            cache.UpdateEquipmentItem(equipment);
            return RedirectToAction("index");
        }

        public ActionResult Delete(int id)
        {
            var equipmentPiece = cache.GetEquipmentItemsRows().Single(e => e.ID == id);
            return View(equipmentPiece);
        }

        [HttpPost]
        public ActionResult Delete(Equipment equipment)
        {
            cache.DeleteEquipmentItem(equipment);
            return RedirectToAction("index");
        }

        public ActionResult AllAssignees()
        {
            var assignees = cache.GetEquipmentItemsRows().Select(i => i.AssignedTo).Distinct();
            return PartialView("_Assignees", assignees);
        }

        public ActionResult FilteredAssignee()
        {

            return PartialView("_FilteredAssignee");
        }

        public ActionResult Login()
        {
            SetTempDataBasedOnTriesAndTime();
            return View();
        }

        void SetTempDataBasedOnTriesAndTime()
        {
            var areMoreThan5Tries = loginManager.areMoreThan5Tries();
            if (areMoreThan5Tries)
            {
                timer.StartTimerIfNotActive();
                if (timer.CheckIf30MinutesPassed())
                {
                    TempData["isDisabled"] = false;
                    loginManager.ResetTriesToZero();
                }
                else
                {
                    TempData["isDisabled"] = true;
                }
            }
            else
            {
                TempData["isDisabled"] = false;
            }
        }

        [HttpPost]
        public ActionResult Login(string username, string password)
        {
            if (username == "admin" && password == "admin#123")
            {
                loginManager.ResetTriesToZero();
                return RedirectToAction("Index");
            } else
            {
                loginManager.AddUnsuccessfulTry();
                TempData["message"] = loginManager.GetStatusMessage();
                return RedirectToAction("Login");
            }
            
        }
    }
}