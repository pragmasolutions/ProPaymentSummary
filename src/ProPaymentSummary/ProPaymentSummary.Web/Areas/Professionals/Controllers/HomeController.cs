using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin.Security;

namespace ProPaymentSummary.Web.Areas.Professionals.Controllers
{
    public class HomeController : Controller
    {
        // GET: Professionals/Home
        public ActionResult Index()
        {
            ViewBag.CurrentUserId = User.Identity.GetUserId();
            return View();
        }
    }
}
