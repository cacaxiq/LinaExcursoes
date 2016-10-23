using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebSite.Infraestrutura.DataBase.Contexto.Interfaces;
using WebSite.Infraestrutura.DataBase.Contexto.Tables;
using WebSite.Models;
using WebSite_LinaExcursao.Infraestrutura.Validators;

namespace WebSite.Controllers
{
    [ValidateSign]
    public class CarouselController : Controller
    {
        private IParametrosRepositorio parametro;

        public CarouselController(IParametrosRepositorio _parametro)
        {
            parametro = _parametro;
        }

        // GET: Carousel
        public ActionResult Index()
        {
            List<CauroselViewModel> model = ObterTodosCarousel();

            return View(model);
        }

        [AllowAnonymous]
        public ActionResult Montacarousel()
        {
            List<CauroselViewModel> model = ObterTodosCarousel();

            return View(model);
        }

        // GET: Carousel/Details/5
        public ActionResult Details(string nomeCaurosel)
        {

            CauroselViewModel caurosel = ObterCauroselPorNome(nomeCaurosel);
            return View(caurosel);
        }

        // GET: Carousel/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Carousel/Create
        [HttpPost]
        public ActionResult Create(CauroselViewModel caurosel)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    List<Parametros> parametrosList = GerarParametrosParaCaurosel(caurosel);

                    parametro.AddList(parametrosList);
                }

                return RedirectToAction("Index");
            }
            catch (Exception e)
            {
                ModelState.AddModelError("", "Erro no processo. Caso Persista enre em contato com o administrador.");
                return View();
            }
        }

        // GET: Carousel/Edit/5
        public ActionResult Edit(string nomeCaurosel)
        {
            CauroselViewModel caurosel = ObterCauroselPorNome(nomeCaurosel);

            return View(caurosel);
        }

        // POST: Carousel/Edit/5
        [HttpPost]
        public ActionResult Edit(CauroselViewModel caurosel)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    IEnumerable<Parametros> parametrosList = AtualizaParametrosPorCaurosel(caurosel.NomeCarousel, caurosel);

                    parametro.UpdateList(parametrosList);

                    return RedirectToAction("Index");
                }

                return View(caurosel);
            }
            catch
            {
                ModelState.AddModelError("", "Erro no processo. Caso Persista enre em contato com o administrador.");
                return View(caurosel);
            }
        }

        // GET: Carousel/Delete/5
        public ActionResult Delete(string nomeCaurosel)
        {
            CauroselViewModel caurosel = ObterCauroselPorNome(nomeCaurosel);

            return View(caurosel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string nomeCaurosel)
        {
            IEnumerable<Parametros> parametrosList = parametro.FindBy(p => p.TagHTML == nomeCaurosel);

            parametro.RemoveList(parametrosList);

            return RedirectToAction("Index");
        }

        // POST: Carousel/Delete/5
        [HttpPost]
        public ActionResult Delete(CauroselViewModel caurosel)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var parametrosList = parametro.FindBy(p => p.TagHTML == caurosel.NomeCarousel);

                    parametro.RemoveList(parametrosList);

                    return RedirectToAction("Index");
                }

                return View(caurosel);
            }
            catch
            {
                ModelState.AddModelError("", "Erro no processo. Caso Persista enre em contato com o administrador.");
                return View(caurosel);
            }
        }

        private List<CauroselViewModel> ObterTodosCarousel()
        {
            var model = new List<CauroselViewModel>();

            var parametroList = parametro.FindBy(p => p.TagHTML.Contains("Caurosel_"));

            var dictParametros = parametroList.GroupBy(p => p.TagHTML).ToDictionary(x => x.Key, x => x.ToList());

            foreach (var parametros in dictParametros)
            {
                var carousel = new CauroselViewModel();

                carousel.NomeCarousel = parametros.Key;

                foreach (var item in parametros.Value)
                {
                    if (item.NomeParametro.Contains("_imagem"))
                    {
                        carousel.Imagem = item.Conteudo;
                    }

                    if (item.NomeParametro.Contains("_titulo"))
                    {
                        carousel.Titulo = item.Conteudo;
                    }

                    if (item.NomeParametro.Contains("_subTitulo"))
                    {
                        carousel.SubTitulo = item.Conteudo;
                    }
                }

                model.Add(carousel);
            }

            return model;
        }

        private static List<Parametros> GerarParametrosParaCaurosel(CauroselViewModel caurosel)
        {
            var parametro_imagem = new Parametros
            {
                NomeParametro = string.Format("{0}_imagem", caurosel.NomeCarousel),
                Conteudo = caurosel.Imagem,
                TagHTML = caurosel.NomeCarousel
            };

            var parametro_titulo = new Parametros
            {
                NomeParametro = string.Format("{0}_titulo", caurosel.NomeCarousel),
                Conteudo = caurosel.Titulo,
                TagHTML = caurosel.NomeCarousel
            };

            var parametro_subTitulo = new Parametros
            {
                NomeParametro = string.Format("{0}_subTitulo", caurosel.NomeCarousel),
                Conteudo = caurosel.SubTitulo,
                TagHTML = caurosel.NomeCarousel
            };

            var parametrosList = new List<Parametros>
                    {
                        parametro_imagem,
                        parametro_titulo,
                        parametro_subTitulo
                    };

            return parametrosList;
        }

        private CauroselViewModel ObterCauroselPorNome(string nomeCaurosel)
        {
            var parametros = parametro.FindBy(p => p.TagHTML == nomeCaurosel);
            var caurosel = new CauroselViewModel
            {
                NomeCarousel = nomeCaurosel,
                Imagem = parametros.First(p => p.NomeParametro == string.Format("{0}_imagem", nomeCaurosel)).Conteudo,
                Titulo = parametros.First(p => p.NomeParametro == string.Format("{0}_titulo", nomeCaurosel)).Conteudo,
                SubTitulo = parametros.First(p => p.NomeParametro == string.Format("{0}_subTitulo", nomeCaurosel)).Conteudo
            };
            return caurosel;
        }

        private IEnumerable<Parametros> AtualizaParametrosPorCaurosel(string nomeCaurosel, CauroselViewModel caurosel)
        {
            var parametrosList = parametro.FindBy(p => p.TagHTML == nomeCaurosel);

            foreach (var item in parametrosList)
            {
                item.TagHTML = caurosel.NomeCarousel;

                if (item.NomeParametro.Contains("_imagem"))
                {
                    item.Conteudo = caurosel.Imagem;
                }

                if (item.NomeParametro.Contains("_titulo"))
                {
                    item.Conteudo = caurosel.Titulo;
                }

                if (item.NomeParametro.Contains("_subTitulo"))
                {
                    item.Conteudo = caurosel.SubTitulo;
                }
            }

            return parametrosList;
        }
    }
}
