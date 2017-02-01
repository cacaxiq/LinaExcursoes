using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinaExcursoes.Infraestrutura.Enumerator
{
    public enum TipoDestino
    {
        [Description("Praias")]
        Praias = 1,

        [Description("Cidades Turísticas")]
        Cidades = 2,

        [Description("Parques Aquáticos")]
        Parques = 3,

        [Description("Eco Turismo")]
        Ecoturismo = 4
    }
}
