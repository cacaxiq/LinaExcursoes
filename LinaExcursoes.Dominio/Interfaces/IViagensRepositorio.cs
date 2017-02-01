using LinaExcursoes.Dominio.DTO;
using LinaExcursoes.Dominio.Tables;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LinaExcursoes.Dominio.Interfaces
{
    public interface IViagensRepositorio : IRepositoryBase<Viagens>
    {
        IEnumerable<Viagens> ObterProximasViagens();

        IEnumerable<Viagens> ObterProximasViagensPraias();

        IEnumerable<Viagens> ObterProximasViagensCidades();

        IEnumerable<Viagens> ObterProximasViagensParques();

        IEnumerable<Viagens> ObterProximasViagensEcoturismo();

        ViagensLeadDTO ObterViagensLead(int id);

        IEnumerable<string> ConsultarViagens();

        DetalheViagem ObterDetalheViagem(int id);

        IEnumerable<Viagens> ObterViagensPorPesquisa(string termo);
    }
}