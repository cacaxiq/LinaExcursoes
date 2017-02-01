using LinaExcursoes.Dominio.Interfaces;
using LinaExcursoes.Dominio.Tables;
using System.Linq;

namespace LinaExcursoes.Dominio.Repositorio
{
    public class UsuariosRepositorio : RepositoryBase<Usuarios>, IUsuariosRepositorio
    {
        public bool ValidarLoginUnico(Usuarios usuario)
        {
            var usuarios = Db.Set<Usuarios>().Where(p => p.Login == usuario.Login).ToList();

            if (usuarios.Count > 1)
            {
                return false;
            }

            return true;
        }

        public bool ValidarLogin(Usuarios usuario)
        {
            var valida = Db.Set<Usuarios>().Any(p => p.Login == usuario.Login && p.Senha == usuario.Senha);

            return valida;
        }
    }
}