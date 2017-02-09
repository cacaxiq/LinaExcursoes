using LinaExcursoes.Dominio.Tables;

namespace LinaExcursoes.Dominio.Interfaces
{
    public interface IParametrosRepositorio : IRepositoryBase<Parametro>
    {
        Parametro ObterPorNomeParametro(string nomeParametro);
    }
}