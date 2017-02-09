using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinaExcursoes.Dominio.Tables
{
    public class Carousel : TabelaBase
    {
        public string Imagem { get; set; }
        public string Titulo { get; set; }

        public string SubTitulo { get; set; }

        Usuario CriadoPor { get; set; }

        Usuario AlteradoPor { get; set; }
    }
}
