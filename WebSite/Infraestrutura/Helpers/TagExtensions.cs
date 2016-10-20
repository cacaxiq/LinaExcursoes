using System;
using System.Web;
using System.Web.Mvc;
using WebSite.Infraestrutura.DataBase.Contexto.Interfaces;
using WebSite.Infraestrutura.DataBase.Contexto.Repositorio;

namespace WebSite.Infraestrutura.Helpers
{
    public class TagExtensions
    {
        public static MvcHtmlString CustomTag(int id)
        {
            var repositorio = new ParametrosRepositorio();

            var parametro = repositorio.GetById(id);

            return new MvcHtmlString(String.Format("<{0}>{1}</{0}>", parametro.TagHTML, parametro.Conteudo));
        }
    }
}