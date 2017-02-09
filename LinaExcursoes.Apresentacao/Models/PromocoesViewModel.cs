using LinaExcursoes.Dominio.Tables;
using System.Collections.Generic;

namespace LinExcursoes.Apresentacao.Models
{
    public class PromocoesViewModel
    {
        public Viagem ViagemPrincipal { get; set; }
        public IEnumerable<Viagem> ListaViagem { get; set; }
        public IEnumerable<Viagem> ListaCadatipo { get; set; }
    }
}