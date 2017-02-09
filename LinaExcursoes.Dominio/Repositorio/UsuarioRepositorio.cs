using LinaExcursoes.Dominio.Interfaces;
using LinaExcursoes.Dominio.Tables;
using System.Linq;

namespace LinaExcursoes.Dominio.Repositorio
{
    public class UsuarioRepositorio : RepositoryBase<Usuario>, IUsuariosRepositorio
    {
        public bool ValidarLoginUnico(Usuario usuario)
        {
            var usuarios = Db.Set<Usuario>().Where(p => p.Login == usuario.Login).ToList();

            if (usuarios.Count > 1)
            {
                return false;
            }

            return true;
        }

        public bool ValidarLogin(Usuario usuario)
        {
            var valida = Db.Set<Usuario>().Any(p => p.Login == usuario.Login && p.Senha == usuario.Senha);

            return valida;
        }
    }
}