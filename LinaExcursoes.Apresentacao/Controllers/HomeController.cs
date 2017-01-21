using System.Web.Mvc;
using WebSite_LinaExcursao.Infraestrutura.Validators;

namespace WebSite.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            ViewBag.Home = true;
            return View();
        }

        [ValidateSign]
        public ActionResult Admin()
        {
            return View();
        }
    }
}