using LinaExcursoes.Apresentacao.Infraestrutura.Session;
using LinaExcursoes.Dominio.Interfaces;
using LinaExcursoes.Dominio.Tables;
using System.Web.Mvc;

namespace LinaExcursoes.Apresentacao.Controllers
{
    public class LoginController : Controller
    {
        private IUsuariosRepositorio usuario;

        public LoginController(IUsuariosRepositorio _usuario)
        {
            usuario = _usuario;
        }

        [HttpGet]
        public ActionResult CriarLogin()
        {
            var model = new Usuarios();
            return View(model);
        }

        [HttpPost]
        public ActionResult CriarLogin(Usuarios usuarios)
        {
            if (ModelState.IsValid)
            {
                if ((usuarios.Senha != usuarios.ContraSenha)
                    || string.IsNullOrEmpty(usuarios.Nome)
                    || string.IsNullOrEmpty(usuarios.Login)
                    || usuarios.Token != "Lina_8946479363")
                {
                    usuarios.Senha = string.Empty;
                    usuarios.ContraSenha = string.Empty;
                    ModelState.AddModelError("", "Problemas na autenticação!!!");
                    return View(usuarios);
                }

                if (!usuario.ValidarLoginUnico(usuarios))
                {
                    usuarios.Senha = string.Empty;
                    usuarios.ContraSenha = string.Empty;
                    ModelState.AddModelError("", "Login já existente.");
                    return View(usuarios);
                }

                usuario.Add(usuarios);

                return RedirectToAction("Admin", "Home");
            }

            usuarios.Senha = string.Empty;
            usuarios.ContraSenha = string.Empty;
            return View(usuarios);
        }

        public ActionResult Logar()
        {
            var model = new Usuarios();
            return View(model);
        }

        [HttpPost]
        public ActionResult Logar(Usuarios usuarios)
        {
            ModelState["Nome"].Errors.Clear();
            ModelState["ContraSenha"].Errors.Clear();
            ModelState["Token"].Errors.Clear();
            if (ModelState.IsValid)
            {
                if (!usuario.ValidarLogin(usuarios))
                {
                    usuarios.Senha = string.Empty;
                    ModelState.AddModelError("", "Problema na autenticação!!!");
                    return View("Logar");
                }

                GerenciaSession.Usuario = usuarios;

                return RedirectToAction("Admin", "Home");
            }

            usuarios.Senha = string.Empty;
            return View(usuarios);
        }
        
        public ActionResult Deslogar()
        {
            GerenciaSession.Remove();

            return RedirectToAction("Admin", "Home");
        }
    }
}