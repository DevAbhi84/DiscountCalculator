using DiscountCalculatorWebAPI.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DiscountCalculatorWebAPI.Controllers
{
    [AuthenticateUser]
    public class DiscountCalculatorController : Controller
    {
        // GET: DiscountCalculator
        public ActionResult Index()
        {
            if (ValidateUserData.session)
            {
                return View();
            }
            else
            {
                return RedirectToAction("LoginView", "Login");
            }
        }
        [Route("Login")]
        public ActionResult LogOut()
        {
            ValidateUserData.session = false;
            return RedirectToAction("Index");
        }
    }
}