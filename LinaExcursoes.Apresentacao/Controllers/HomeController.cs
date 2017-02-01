using System.Web.Mvc;
using LinaExcursoes.Apresentacao.Infraestrutura.Validators;

namespace LinaExcursoes.Apresentacao.Controllers
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