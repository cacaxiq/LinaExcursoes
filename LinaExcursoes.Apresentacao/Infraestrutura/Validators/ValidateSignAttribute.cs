using System.Web;
using System.Web.Mvc;
using WebSite_LinaExcursao.Infraestrutura.Session;

namespace WebSite_LinaExcursao.Infraestrutura.Validators
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