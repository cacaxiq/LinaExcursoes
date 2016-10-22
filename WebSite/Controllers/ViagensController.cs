using System.IO;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using WebSite.Infraestrutura.DataBase.Contexto.Interfaces;
using WebSite_LinaExcursao.Infraestrutura.DataBase.Contexto.Tables;
using WebSite_LinaExcursao.Infraestrutura.Enumerators;
using WebSite_LinaExcursao.Infraestrutura.Helpers;

namespace WebSite_LinaExcursao.Controllers
{
    public class ViagensController : Controller
    {
        private IViagensRepositorio viagem;

        public ViagensController(IViagensRepositorio _viagem)
        {
            viagem = _viagem;
        }

        public ActionResult Index()
        {
            return View(viagem.GetAll());
        }


        // GET: Viagens
        public ActionResult ListarViagensPorTipo(string tipoDestino)
        {
            return View(viagem.FindBy(p => p.Tipo == tipoDestino));
        }

        // GET: Viagens/Details/5
        public ActionResult Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Viagens viagens = viagem.GetById(id.Value);
            if (viagens == null)
            {
                return HttpNotFound();
            }
            return View(viagens);
        }

        // GET: Viagens/Create
        public ActionResult Create()
        {
            var path = Path.GetFullPath(Server.MapPath("~/img/Viagens"));
            ViewBag.Arquivos = Directory.GetFiles(path).ToList();

            return View();
        }

        // POST: Viagens/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Local,Periodo,Valor,Tipo,Descricao,DataSaida,DataRetorno,Imagem")] Viagens viagens)
        {
            if (ModelState.IsValid)
            {
                viagem.Add(viagens);
                return RedirectToAction("Index");
            }

            return View(viagens);
        }

        // GET: Viagens/Edit/5
        public ActionResult Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Viagens viagens = viagem.GetById(id.Value);
            if (viagens == null)
            {
                return HttpNotFound();
            }
            return View(viagens);
        }

        // POST: Viagens/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Local,Periodo,Valor,Tipo,Descricao,DataSaida,DataRetorno,Imagem")] Viagens viagens)
        {
            if (ModelState.IsValid)
            {
                viagem.Update(viagens);
                return RedirectToAction("Index");
            }
            return View(viagens);
        }

        // GET: Viagens/Delete/5
        public ActionResult Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Viagens viagens = viagem.GetById(id.Value);
            if (viagens == null)
            {
                return HttpNotFound();
            }
            return View(viagens);
        }

        // POST: Viagens/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(long id)
        {
            Viagens viagens = viagem.GetById(id);
            viagem.Remove(viagens);
            return RedirectToAction("Index");
        }
    }
}
