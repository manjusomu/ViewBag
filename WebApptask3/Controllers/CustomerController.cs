using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApptask3.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        public ActionResult Index()
        {
            List<string> list = new List<string>()
            {
                "Ravi","Ram","Janu","Guna" };
            ViewBag.namelist = list;
            return View();
        }
      
        public ActionResult RedirectDemo()
        {


            TempData["msg"] = "Welcome to Customer Page";
            return View();
        }
        public ActionResult DisplayMessage() 
        {

            TempData["Dmsg"] = "Customer Details";
            return View();
        }
    }
}