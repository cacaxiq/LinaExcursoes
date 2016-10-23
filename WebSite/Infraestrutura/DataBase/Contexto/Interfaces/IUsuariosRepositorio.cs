using WebSite_LinaExcursao.Infraestrutura.DataBase.Contexto.Tables;

namespace WebSite.Infraestrutura.DataBase.Contexto.Interfaces
{
    public interface IUsuariosRepositorio : IRepositoryBase<Usuarios>
    {
        bool ValidarLoginUnico(Usuarios usuario);

        bool ValidarLogin(Usuarios usuario);
    }
}