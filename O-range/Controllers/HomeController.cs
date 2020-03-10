using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.SqlClient;

namespace O_range.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            System.Data.DataTable dt = new System.Data.DataTable();
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}