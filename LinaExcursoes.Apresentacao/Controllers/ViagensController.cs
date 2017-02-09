using LinaExcursoes.Apresentacao.Infraestrutura.Validators;
using LinaExcursoes.Dominio.Interfaces;
using LinaExcursoes.Dominio.Tables;
using LinExcursoes.Apresentacao.Models;
using LinExcursoes.Infraestrutura.Extensions;
using System;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace LinaExcursoes.Apresentacao.Controllers
{
    [ValidateSign]
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
        [AllowAnonymous]
        public ActionResult ListarViagensPorTipo(string tipoDestino)
        {
            return View(viagem.FindBy(p => p.Tipo == tipoDestino && p.DataSaida >= DateTime.Now).OrderBy(p => p.DataSaida));
        }

        // GET: Viagens
        [AllowAnonymous]
        public ActionResult Detalhe(int id)
        {
            var model = new ViagensporDetalhe();

            try
            {
                var retorno = viagem.ObterDetalheViagem(id);

                model.Detalhe = retorno.Detalhe;
                model.ListaViagem = retorno.ListaViagem;
            }
            catch (Exception)
            {

                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            return View(model);
        }

        // GET: Viagens
        [AllowAnonymous]
        public ActionResult Praias()
        {
            return View(viagem.ObterProximasViagensPraias());
        }

        // GET: Viagens
        [AllowAnonymous]
        public ActionResult Cidades()
        {
            return View(viagem.ObterProximasViagensCidades());
        }

        // GET: Viagens
        [AllowAnonymous]
        public ActionResult Parques()
        {
            return View(viagem.ObterProximasViagensParques());
        }

        // GET: Viagens
        [AllowAnonymous]
        public ActionResult EcoTurismo()
        {
            return View(viagem.ObterProximasViagensEcoturismo());
        }

        // GET: Viagens/Details/5
        public ActionResult Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Viagem viagens = viagem.GetById(id.Value);
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
        public ActionResult Create([Bind(Include = "Id,Local,Periodo,Valor,Tipo,Descricao,DataSaida,DataRetorno,Imagem")] Viagem viagens)
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
            Viagem viagens = viagem.GetById(id.Value);
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
        public ActionResult Edit([Bind(Include = "Id,Local,Periodo,Valor,Tipo,Descricao,DataSaida,DataRetorno,Imagem")] Viagem viagens)
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
            Viagem viagens = viagem.GetById(id.Value);
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
            viagem.Remove(id);
            return RedirectToAction("Index");
        }

        [AllowAnonymous]
        public JsonResult AutoCompletePesquisa(string termo)
        {
            var lista = viagem.ConsultarViagens();

            var termoNormalizado = termo.Normalizacao();

            var link = string.Format(ConfigurationManager.AppSettings["caminhoBase"], "Detalhe");

            var listaFiltrada = lista.Where(p => p.Normalizacao().Contains(termoNormalizado));

            var listaExibicao = listaFiltrada.Select(item => new
            {
                link = string.Format("{0}/{1}", link, item.Split('&')[1]),
                descricao = item.Split('&')[0]
            }).ToList();

            return Json(listaExibicao, JsonRequestBehavior.AllowGet);
        }

        [AllowAnonymous]
        public ActionResult DetalhesPesquisa(string pesquisar)
        {
            var lista = viagem.ObterViagensPorPesquisa(pesquisar);

            ViewBag.Termo = pesquisar;

            return View(lista);
        }
    }
}
