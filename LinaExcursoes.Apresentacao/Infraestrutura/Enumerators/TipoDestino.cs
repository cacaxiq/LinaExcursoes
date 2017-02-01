using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace LinaExcursoes.Apresentacao.Infraestrutura.Enumerators
{
    public enum TipoDestino
    {
        [Description("Cidades")]
        Cidades = 0,

        [Description("Praias")]
        Praias = 1,

        [Description("Ecoturismo")]
        Ecoturismo = 2,

        [Description("ParquesAquaticos")]
        ParquesAquaticos = 3
    }
}