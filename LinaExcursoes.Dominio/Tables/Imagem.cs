using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinaExcursoes.Dominio.Tables
{
    public class Imagem : TabelaBase
    {
        public byte[] Conteudo { get; set; }

        public Viagem Viagem { get; set; }

        public Carousel Carousel { get; set; }

        Usuario CriadoPor { get; set; }

        Usuario AlteradoPor { get; set; }
    }
}
