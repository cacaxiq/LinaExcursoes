using System.Web;
using System.Web.Mvc;
using LinaExcursoes.Apresentacao.Infraestrutura.Session;

namespace LinaExcursoes.Apresentacao.Infraestrutura.Validators
{
    public class ValidateSignAttribute : AuthorizeAttribute
    {
        protected override bool AuthorizeCore(HttpContextBase httpContext)
        {
            return GerenciaSession.Usuario != null;
        }

        protected override void HandleUnauthorizedRequest(AuthorizationContext filterContext)
        {
            filterContext.Result = new RedirectResult("~/Login/Logar");
        }
    }
}