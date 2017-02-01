using LinaExcursoes.Dominio.Tables;
using System.Collections.Generic;

namespace LinExcursoes.Apresentacao.Models
{
    public class ViagensporDetalhe
    {
        public Viagens Detalhe { get; set; }
        public IEnumerable<Viagens> ListaViagem { get; set; }
    }
}