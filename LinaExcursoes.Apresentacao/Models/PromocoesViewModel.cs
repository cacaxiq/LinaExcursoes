using LinaExcursoes.Dominio.Tables;
using System.Collections.Generic;

namespace LinExcursoes.Apresentacao.Models
{
    public class PromocoesViewModel
    {
        public Viagens ViagemPrincipal { get; set; }
        public IEnumerable<Viagens> ListaViagem { get; set; }
        public IEnumerable<Viagens> ListaCadatipo { get; set; }
    }
}