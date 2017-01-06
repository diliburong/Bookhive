using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Bookhive.Controllers.frontend
{
    public class AccountController : Controller
    {
        // GET: Account
        public ActionResult Login()
        {
            return View();

        }

        public ActionResult Register()
        {
            return View();
        }

        public ActionResult FogetPassword()
        {
            return View();
        }
    }
}