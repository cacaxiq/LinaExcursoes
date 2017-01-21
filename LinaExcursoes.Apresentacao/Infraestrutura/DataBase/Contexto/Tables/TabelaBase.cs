using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebSite.Infraestrutura.DataBase.Contexto.Tables
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