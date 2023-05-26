using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CollegeManagement.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ACADEMICS()
        {
            return View();
        }
        public ActionResult Admission()
        {
            return View();
        }
    }
}