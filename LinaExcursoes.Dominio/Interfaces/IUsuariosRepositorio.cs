using LinaExcursoes.Dominio.Tables;

namespace LinaExcursoes.Dominio.Interfaces
{
    public interface IUsuariosRepositorio : IRepositoryBase<Usuario>
    {
        bool ValidarLoginUnico(Usuario usuario);

        bool ValidarLogin(Usuario usuario);
    }
}