using System.Net;
using System.Web.Mvc;
using LinaExcursoes.Apresentacao.Infraestrutura.Validators;
using LinaExcursoes.Dominio.Interfaces;
using LinaExcursoes.Dominio.Tables;

namespace LinaExcursoes.Apresentacao.Controllers
{
    [ValidateSign]
    public class ParametrosController : Controller
    {
        private IParametrosRepositorio parametro;

        public ParametrosController(IParametrosRepositorio _parametro)
        {
            parametro = _parametro;
        }

        // GET: Parametros
        public ActionResult Index()
        {
            return View(parametro.FindBy(p => !p.TagHTML.Contains("Carousel")));
        }

        // GET: Parametros/Details/5
        public ActionResult Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Parametros parametros = parametro.GetById(id.Value);
            if (parametros == null)
            {
                return HttpNotFound();
            }
            return View(parametros);
        }

        // GET: Parametros/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Parametros/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Conteudo,TagHTML,NomeParametro")] Parametros parametros)
        {
            if (ModelState.IsValid)
            {
                parametro.Add(parametros);
                return RedirectToAction("Index");
            }

            return View(parametros);
        }

        // GET: Parametros/Edit/5
        public ActionResult Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Parametros parametros = parametro.GetById(id.Value);
            if (parametros == null)
            {
                return HttpNotFound();
            }
            return View(parametros);
        }

        // POST: Parametros/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Conteudo,TagHTML,NomeParametro")] Parametros parametros)
        {
            if (ModelState.IsValid)
            {
                parametro.Update(parametros);
                return RedirectToAction("Index");
            }
            return View(parametros);
        }

        // GET: Parametros/Delete/5
        public ActionResult Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Parametros parametros = parametro.GetById(id.Value);
            if (parametros == null)
            {
                return HttpNotFound();
            }
            return View(parametros);
        }

        // POST: Parametros/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(long id)
        {
            parametro.Remove(id);
            return RedirectToAction("Index");
        }
    }
}
