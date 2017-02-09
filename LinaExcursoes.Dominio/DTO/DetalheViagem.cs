using LinaExcursoes.Dominio.Tables;
using System.Collections.Generic;

namespace LinaExcursoes.Dominio.DTO
{
    public class DetalheViagem
    {
        public Viagem Detalhe { get; set; }
        public IEnumerable<Viagem> ListaViagem { get; set; }
    }
}
