using LinaExcursoes.Dominio.DTO;
using LinaExcursoes.Dominio.Tables;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LinaExcursoes.Dominio.Interfaces
{
    public interface IViagensRepositorio : IRepositoryBase<Viagem>
    {
        IEnumerable<Viagem> ObterProximasViagens();

        IEnumerable<Viagem> ObterProximasViagensPraias();

        IEnumerable<Viagem> ObterProximasViagensCidades();

        IEnumerable<Viagem> ObterProximasViagensParques();

        IEnumerable<Viagem> ObterProximasViagensEcoturismo();

        ViagensLeadDTO ObterViagensLead(int id);

        IEnumerable<string> ConsultarViagens();

        DetalheViagem ObterDetalheViagem(int id);

        IEnumerable<Viagem> ObterViagensPorPesquisa(string termo);
    }
}