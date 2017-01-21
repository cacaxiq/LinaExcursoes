using WebSite.Infraestrutura.DataBase.Contexto.Interfaces;
using WebSite_LinaExcursao.Infraestrutura.DataBase.Contexto.Tables;
using System.Linq;
using System.Collections.Generic;

namespace WebSite.Infraestrutura.DataBase.Contexto.Repositorio
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