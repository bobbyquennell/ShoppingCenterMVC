using ShoppingCenter.Areas.U.Models;
using ShoppingCenter.UserManage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ShoppingCenter.Areas.U.Controllers
{
    public class UserController : Controller
    {
        UserManageServiceClient client = new UserManageServiceClient();

        // GET: U/User/Index
        public ActionResult Index()
        {
            return View();
        }

        // GET: U/User/SignUp
        public ActionResult SignUp()
        {
            return View();
        }

        // POST: U/User/SignUp
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult SignUp(SignUpViewModel model)
        {
            if (ModelState.IsValid)
            {
                var result = client.SignUp(model.Email.Trim(), model.Password);

                if (result.Success)
                {
                    ViewBag.Message = new string[] 
                    {
                        "You have successfully signed up.",
                        "A letter of confirmation has been sent to your email: " + model.Email,
                        "Please active your account."
                    };

                    ViewBag.Title = "Successfully Signed Up";
                    ViewBag.InvokeType = "ActionLink";
                    ViewBag.LinkString = "Active Your Account";
                    ViewBag.Action = "Active";
                    ViewBag.Controller = "User";
                    ViewBag.Area = "U";

                    return View("Message");
                }
                else
                {
                    ViewBag.Message = new string[]
                    {
                        "An error occured while signing up. Please read the error message and try later.",
                        "ErrorMessage: " + result.ErrorMessage
                    };

                    ViewBag.Title = "Error";
                    ViewBag.InvokeType = "ActionLink";
                    ViewBag.LinkString = "Try again";
                    ViewBag.Action = "SignUp";
                    ViewBag.Controller = "User";
                    ViewBag.Area = "U";

                    return View("Message");
                }
            }
            return View(model);
        }

        // GET: U/User/Active
        public ActionResult Active(ActiveViewModel model)
        {
            if(model.Email == null)
            {
                return View();
            }


            if (ModelState.IsValid)
            {
                var result = client.ActiveAccount(model.Email.Trim(), model.ConfirmationCode.Trim());
                if (result.Success)
                {
                    ViewBag.Message = new string[] 
                    {
                        "Your Account is now active."
                    };

                    ViewBag.Title = "Account Active Successfully";
                    ViewBag.InvokeType = "ActionLink";
                    ViewBag.LinkString = "View Your Account";
                    ViewBag.Action = "Index";
                    ViewBag.Controller = "Manage";
                    ViewBag.Area = "U";

                    return View("Message");
                }
                else
                {
                    ViewBag.Message = new string[]
                    {
                        "An error occured while active your account. Please read the error message and try later.",
                        "ErrorMessage: " + result.ErrorMessage
                    };

                    ViewBag.Title = "Error";
                    ViewBag.InvokeType = "ActionLink";
                    ViewBag.LinkString = "Try again";
                    ViewBag.Action = "Active";
                    ViewBag.Controller = "User";
                    ViewBag.Area = "U";

                    return View("Message");
                }
            }
            return View();
        }

        // GET: U/User/SignIn
        public ActionResult SignIn()
        {
            return View();
        }

        // POST: U/User/SignIn
        [HttpPost]
        public ActionResult SignIn(SignInViewModel model)
        {
            return View();
        }
    }
}