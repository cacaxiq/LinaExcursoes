using System.Web.Mvc;
using WebSite_LinaExcursao.Infraestrutura.Validators;

namespace WebSite.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        [ValidateSign]
        public ActionResult Admin()
        {
            return View();
        }
    }
}