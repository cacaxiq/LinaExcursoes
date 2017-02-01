using System.Text;
using System.Web.Mvc;
using LinaExcursoes.Apresentacao.Infraestrutura.Mail;
using LinaExcursoes.Dominio.Interfaces;
using LinaExcursoes.Dominio.Tables;
using LinaExcursoes.Apresentacao.Models;

namespace LinaExcursoes.Apresentacao.Controllers
{
    public class ContatosController : Controller
    {
        // GET: Contatos
        public ActionResult Index()
        {
            return View();
        }

        // POST: Contatos/Create
        [HttpPost]
        public ActionResult Create(ContatoViewModel contato)
        {
            try
            {
                StringBuilder sb = new StringBuilder();
                sb.Append("Fale conosco - Site Lina Excursões");
                sb.Append("\n");
                sb.AppendFormat("Nome: {0}", contato.Nome);
                sb.Append("\n");
                sb.AppendFormat("Email: {0}", contato.Email);
                sb.Append("\n");
                sb.AppendFormat("Telefone: {0}", contato.Telefone);
                sb.Append("\n");
                sb.AppendFormat("Mensagem: {0}", contato.Messagem);
                sb.Append("\n");

                Mail.SendSimpleMessage(sb.ToString());
                
                return Content("Recebemos a sua mensgem! Em breve entraremos em contato.");
            }
            catch
            {
                return Content("Não foi possível enviar a mensagem. Utilize um dos nossos telefones.");
            }
        }
    }
}
