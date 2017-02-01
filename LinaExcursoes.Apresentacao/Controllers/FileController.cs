using System.IO;
using System.Web;
using System.Web.Mvc;
using LinaExcursoes.Apresentacao.Infraestrutura.Validators;

namespace LinaExcursoes.Apresentacao.Controllers
{
    [ValidateSign]
    public class FileController : Controller
    {
        public ActionResult FileUpload()
        {
            return View();
        }

        [HttpPost]
        public ActionResult FileUpload(HttpPostedFileBase file)
        {
            if (file != null && file.ContentLength > 0)
            {
                var fileName = Path.GetFileName(file.FileName);
                var path = Path.Combine(Server.MapPath("~/img/Viagens"), fileName);
                file.SaveAs(path);
            }

            return RedirectToAction("Index","Viagens");
        }
    }
}