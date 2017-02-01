using LinaExcursoes.Dominio.Tables;

namespace LinaExcursoes.Dominio.Interfaces
{
    public interface IParametrosRepositorio : IRepositoryBase<Parametros>
    {
        Parametros ObterPorNomeParametro(string nomeParametro);
    }
}