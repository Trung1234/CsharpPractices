using SimpleLoginApp.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SimpleLoginApp.Controllers
{
    public class HomeController : Controller
    {
        readonly IUserService userService;

        //inject dependency
        public HomeController(IUserService userService)
        {
            this.userService = userService;
        }

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Login()
        {
            return View();
        }
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(UserProfile objUser)
        {
            if (ModelState.IsValid)
            {
                var obj = userService.GetUserProfile(objUser.UserName, objUser.Password);
                if (obj != null)
                {
                    Session["UserID"] = obj.UserId.ToString();
                    Session["UserName"] = obj.UserName.ToString();
                    return RedirectToAction("UserDashBoard");
                }
            }
            return View(objUser);
        }

        public ActionResult UserDashBoard()
        {
            if (Session["UserID"] != null)
            {
                return View();
            }
            else
            {
                return RedirectToAction("Login");
            }
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}