using LinaExcursoes.Dominio.Tables;
using System.Collections.Generic;
namespace LinaExcursoes.Dominio.DTO
{
    public class ViagensLeadDTO
    {
        public Viagem ViagemPrincipal { get; set; }
        public IEnumerable<Viagem> ListaViagem { get; set; }
        public IEnumerable<Viagem> ListaCadatipo { get; set; }
    }
}
