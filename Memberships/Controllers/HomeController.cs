using Memberships.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using Memberships.Extensions;
using System.Threading.Tasks;

namespace Memberships.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index() 
        {
            ViewBag.Message = "Your application description page.";

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