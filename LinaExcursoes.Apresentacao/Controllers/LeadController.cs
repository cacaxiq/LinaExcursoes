using LinaExcursoes.Dominio.Interfaces;
using LinExcursoes.Apresentacao.Models;
using System;
using System.Linq;
using System.Web.Mvc;

namespace LinExcursoes.Apresentacao.Controllers
{
    public class LeadController : Controller
    {
        private IViagensRepositorio viagem;

        public LeadController(IViagensRepositorio _viagem)
        {
            viagem = _viagem;
        }

        // GET: Lead
        public ActionResult Promocoes(int id)
        {
            var model = new PromocoesViewModel();

            var resultado = viagem.ObterViagensLead(id);

            model.ListaCadatipo = resultado.ListaCadatipo;
            model.ListaViagem = resultado.ListaViagem;
            model.ViagemPrincipal = resultado.ViagemPrincipal;

            return View(model);
        }
    }
}