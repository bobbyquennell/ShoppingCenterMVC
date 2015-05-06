using ShoppingCenter.Areas.U.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace ShoppingCenter.Areas.U.Controllers
{
    public class UserController : Controller
    {
        //UserManageServiceClient client = new UserManageServiceClient();

        // GET: U/User/Index
        public ActionResult Index()
        {
            if (Session["IsSignedIn"] == null || !(bool)Session["IsSignedIn"])
            {
                //User Not Sign In
                return PartialView();
            }
            else
            {
                //User Sign In
                if (Session["User"] == null)
                {
                    //Sign In Information Lost Need ReSign In
                    return PartialView();
                }
                else
                {
                    //var user = Session["User"] as ShoppingCenter.UserManage.User;
                    return PartialView();
                }
            }
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
            //if (ModelState.IsValid)
            //{
            //    var result = client.SignUp(model.Email.Trim(), model.Password);

            //    if (result.Success)
            //    {
            //        ViewBag.Message = new string[] 
            //        {
            //            "You have successfully signed up.",
            //            "A letter of confirmation has been sent to your email: " + model.Email,
            //            "Please active your account."
            //        };

            //        ViewBag.Title = "Successfully Signed Up";
            //        ViewBag.InvokeType = "ActionLink";
            //        ViewBag.LinkString = "Active Your Account";
            //        ViewBag.Action = "Active";
            //        ViewBag.Controller = "User";
            //        ViewBag.Area = "U";

            //        return View("Message");
            //    }
            //    else
            //    {
            //        ViewBag.Message = new string[]
            //        {
            //            "An error occured while signing up. Please read the error message and try later.",
            //            "ErrorMessage: " + result.ErrorMessage
            //        };

            //        ViewBag.Title = "Error";
            //        ViewBag.InvokeType = "ActionLink";
            //        ViewBag.LinkString = "Try again";
            //        ViewBag.Action = "SignUp";
            //        ViewBag.Controller = "User";
            //        ViewBag.Area = "U";

            //        return View("Message");
            //    }
            //}
            return View(model);
        }

        // GET: U/User/Active
        public async Task<ActionResult> Active(ActiveViewModel model)
        {
            if (String.IsNullOrEmpty(model.Email))
            {
                model = null;
                return View();
            }

            //if (ModelState.IsValid)
            //{
            //    var result = await client.ActiveAccountAsync(model.Email.Trim(), model.ConfirmationCode.Trim());
            //    if (result.Success)
            //    {
            //        ViewBag.Message = new string[] 
            //        {
            //            "Your Account is now active."
            //        };

            //        ViewBag.Title = "Account Active Successfully";
            //        ViewBag.InvokeType = "ActionLink";
            //        ViewBag.LinkString = "View Your Account";
            //        ViewBag.Action = "Index";
            //        ViewBag.Controller = "Manage";
            //        ViewBag.Area = "U";

            //        return View("Message");
            //    }
            //    else
            //    {
            //        ViewBag.Message = new string[]
            //        {
            //            "An error occured while active your account. Please read the error message and try later.",
            //            "ErrorMessage: " + result.ErrorMessage
            //        };

            //        ViewBag.Title = "Error";
            //        ViewBag.InvokeType = "ActionLink";
            //        ViewBag.LinkString = "Try again";
            //        ViewBag.Action = "Active";
            //        ViewBag.Controller = "User";
            //        ViewBag.Area = "U";

            //        return View("Message");
            //    }
            //}
            return View();
        }

        // GET: U/User/SignIn
        public ActionResult SignIn()
        {
            Session.Add("UrlReferrer", Request.UrlReferrer);
            return View();
        }

        // POST: U/User/SignIn
        [HttpPost]
        public async Task<ActionResult> SignIn(SignInViewModel model)
        {
            return View();

            //var result = await client.SignInAsync(model.Email.Trim(), model.Password);

            //if (result.Success)
            //{
            //    //成功

            //    //账户是否激活？
            //    if (result.User.IsConfirmed)
            //    {
            //        //账号已经激活
            //        //处理Session
            //        Session["IsSignedIn"] = true;
            //        Session["User"] = result.User;

            //        //返回当前页面
            //        if (Session["UrlReferrer"] == null)
            //        {
            //            return RedirectToAction("Index", new { area = "U" });
            //        }
            //        else
            //        {
            //            return Redirect(Session["UrlReferrer"].ToString());
            //        }
            //    }
            //    else
            //    {
            //        //尚未激活
            //        ViewBag.Message = new string[]
            //        {
            //            "Your account is inactive. Please active before sign in"
            //        };

            //        ViewBag.Title = "Account Needs Active";
            //        ViewBag.InvokeType = "ActionLink";
            //        ViewBag.LinkString = "Active Your Account";
            //        ViewBag.Action = "Active";
            //        ViewBag.Controller = "User";
            //        ViewBag.Area = "U";

            //        return View("Message");
            //    }
            //}
            //else
            //{
            //    //验证失败
            //    return View(model);
            //}
        }
    }
}