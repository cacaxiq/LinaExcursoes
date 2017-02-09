using LinaExcursoes.Dominio.Interfaces;
using LinaExcursoes.Dominio.Tables;
using System.Linq;

namespace LinaExcursoes.Dominio.Repositorio
{
    public class ParametroRepositorio : RepositoryBase<Parametro>, IParametrosRepositorio
    {
        public Parametro ObterPorNomeParametro(string nomeParametro)
        {
            return Db.Set<Parametro>().FirstOrDefault(p => p.Nome == nomeParametro);
        }
    }
}