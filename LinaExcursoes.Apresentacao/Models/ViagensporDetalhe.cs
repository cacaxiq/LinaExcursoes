using LinaExcursoes.Dominio.Tables;
using System.Collections.Generic;

namespace LinExcursoes.Apresentacao.Models
{
    public class ViagensporDetalhe
    {
        public Viagem Detalhe { get; set; }
        public IEnumerable<Viagem> ListaViagem { get; set; }
    }
}