using LinaExcursoes.Dominio.Tables;
using System.Collections.Generic;
namespace LinaExcursoes.Dominio.DTO
{
    public class ViagensLeadDTO
    {
        public Viagens ViagemPrincipal { get; set; }
        public IEnumerable<Viagens> ListaViagem { get; set; }
        public IEnumerable<Viagens> ListaCadatipo { get; set; }
    }
}
