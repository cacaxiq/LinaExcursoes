using System.Collections.Generic;
using WebSite_LinaExcursao.Infraestrutura.DataBase.Contexto.Tables;

namespace WebSite.Infraestrutura.DataBase.Contexto.Interfaces
{
    public interface IViagensRepositorio : IRepositoryBase<Viagens>
    {
        IEnumerable<Viagens> ObterProximasViagens();
    }
}