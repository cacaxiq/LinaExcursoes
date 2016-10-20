using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebSite.Infraestrutura.Mail;

namespace WebSite.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            ViewBag.teste = Environment.CurrentDirectory;
            Mail.SendSimpleMessage();
            return View();
        }
    }
}