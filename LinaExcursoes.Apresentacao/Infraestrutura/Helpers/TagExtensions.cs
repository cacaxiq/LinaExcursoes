using LinaExcursoes.Dominio.Repositorio;
using System;
using System.Configuration;
using System.Web.Mvc;

namespace LinaExcursoes.Apresentacao.Infraestrutura.Helpers
{
    public class TagExtensions
    {
        public static MvcHtmlString CustomTag(int id)
        {
            var repositorio = new ParametrosRepositorio();

            var parametro = repositorio.GetById(id);

            return new MvcHtmlString(String.Format("<{0}>{1}</{0}>", parametro.TagHTML, parametro.Conteudo));
        }

        public static string CustomContent(int id)
        {
            var repositorio = new ParametrosRepositorio();

            var parametro = repositorio.GetById(id);

            return parametro.Conteudo;
        }

        public static string CustomContentPorNome(string nomeParametro)
        {
            var repositorio = new ParametrosRepositorio();

            var parametro = repositorio.ObterPorNomeParametro(nomeParametro);

            if (parametro != null)
            {
                return parametro.Conteudo;
            }

            return string.Empty;
        }

        public static MvcHtmlString CustomImgTag(string nomeParametro)
        {
            var repositorio = new ParametrosRepositorio();

            var parametro = repositorio.ObterPorNomeParametro(nomeParametro);

            return new MvcHtmlString(String.Format("<img class='img-responsive' src='" + ConfigurationManager.AppSettings["caminhoImagens"] + "' alt='Lina Excursões - A melhor viagem para seu momento.'/>", parametro.TagHTML));
        }
    }
}