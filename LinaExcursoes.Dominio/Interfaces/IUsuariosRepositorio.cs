using LinaExcursoes.Dominio.Tables;

namespace LinaExcursoes.Dominio.Interfaces
{
    public interface IUsuariosRepositorio : IRepositoryBase<Usuarios>
    {
        bool ValidarLoginUnico(Usuarios usuario);

        bool ValidarLogin(Usuarios usuario);
    }
}