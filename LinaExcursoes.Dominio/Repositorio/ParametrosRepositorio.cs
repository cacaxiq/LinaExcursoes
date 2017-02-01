using LinaExcursoes.Dominio.Interfaces;
using LinaExcursoes.Dominio.Tables;
using System.Linq;

namespace LinaExcursoes.Dominio.Repositorio
{
    public class ParametrosRepositorio : RepositoryBase<Parametros>, IParametrosRepositorio
    {
        public Parametros ObterPorNomeParametro(string nomeParametro)
        {
            return Db.Set<Parametros>().FirstOrDefault(p => p.NomeParametro == nomeParametro);
        }
    }
}