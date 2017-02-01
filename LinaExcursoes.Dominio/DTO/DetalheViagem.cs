using LinaExcursoes.Dominio.Tables;
using System.Collections.Generic;

namespace LinaExcursoes.Dominio.DTO
{
    public class DetalheViagem
    {
        public Viagens Detalhe { get; set; }
        public IEnumerable<Viagens> ListaViagem { get; set; }
    }
}
