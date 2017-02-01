using LinaExcursoes.Apresentacao.Infraestrutura.Validators;
using LinaExcursoes.Dominio.Interfaces;
using LinaExcursoes.Dominio.Tables;
using System.Net;
using System.Web.Mvc;

namespace LinaExcursoes.Apresentacao.Controllers
{
    [ValidateSign]
    public class UsuariosController : Controller
    {
        private IUsuariosRepositorio usuario;

        public UsuariosController(IUsuariosRepositorio _usuario)
        {
            usuario = _usuario;
        }

        // GET: Usuarios
        public ActionResult Index()
        {
            return View(usuario.GetAll());
        }

        // GET: Usuarios/Details/5
        public ActionResult Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Usuarios usuarios = usuario.GetById(id.Value);
            if (usuarios == null)
            {
                return HttpNotFound();
            }
            return View(usuarios);
        }

        // GET: Usuarios/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Usuarios/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Nome,Login,Senha,DataInclusao")] Usuarios usuarios)
        {
            if (ModelState.IsValid)
            {
                usuario.Add(usuarios);
                return RedirectToAction("Index");
            }

            return View(usuarios);
        }

        // GET: Usuarios/Edit/5
        public ActionResult Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Usuarios usuarios = usuario.GetById(id.Value);
            if (usuarios == null)
            {
                return HttpNotFound();
            }
            return View(usuarios);
        }

        // POST: Usuarios/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Nome,Login,Senha,DataInclusao")] Usuarios usuarios)
        {
            if (ModelState.IsValid)
            {
                usuario.Update(usuarios);
                return RedirectToAction("Index");
            }
            return View(usuarios);
        }

        // GET: Usuarios/Delete/5
        public ActionResult Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Usuarios usuarios = usuario.GetById(id.Value);
            if (usuarios == null)
            {
                return HttpNotFound();
            }
            return View(usuarios);
        }

        // POST: Usuarios/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(long id)
        {
            Usuarios usuarios = usuario.GetById(id);
            usuario.Remove(usuarios);
            return RedirectToAction("Index");
        }
    }
}
