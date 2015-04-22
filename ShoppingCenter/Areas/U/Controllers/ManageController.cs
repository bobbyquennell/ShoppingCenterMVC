using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ShoppingCenter.Areas.U.Controllers
{
    public class ManageController : Controller
    {
        // GET: U/Manage/Index
        public ActionResult Index()
        {
            return View();
        }

        // GET: U/Manage/ChangePassword
        public ActionResult ChangePassword()
        {
            return View();
        }

        // POST: U/Manage/ChangePassword
        [HttpPost]
        public ActionResult ChangePassword(string password)
        {
            return View();
        }

        // GET: U/Manage/ChangeEmail
        public ActionResult ChangeEmail()
        {
            return View();
        }

        // POST: U/Manage/ChangeEmail
        [HttpPost]
        public ActionResult ChangeEmail(string email)
        {
            return View();
        }

        // GET: U/Manage/ChangeInformation
        public ActionResult ChangeInformation()
        {
            return View();
        }

        // POST: U/Manage/ChangeInformation
        [HttpPost]
        public ActionResult ChangeInformation(string information)
        {
            return View();
        }
    }
}