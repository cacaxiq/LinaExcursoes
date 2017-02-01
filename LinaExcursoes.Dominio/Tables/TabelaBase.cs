using System;
using System.ComponentModel.DataAnnotations;

namespace LinaExcursoes.Dominio.Tables
{
    public class TabelaBase
    {
        [Key]
        public long Id { get; set; }
        
        [ScaffoldColumn(false)]
        [DisplayFormat(DataFormatString = "{0:dd MMM yyyy}")]
        public DateTime DataInclusao { get; set; }
    }
}