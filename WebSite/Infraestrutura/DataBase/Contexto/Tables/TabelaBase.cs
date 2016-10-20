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

        //[Required(ErrorMessage = "Seu nome é necessário para contato.")]
        //[MaxLength(100, ErrorMessage = "Excedeu tamanho permitido.")]
        //public string Nome { get; set; }

        //[MaxLength(300, ErrorMessage = "Excedeu tamanho permitido.")]
        //[DataType(DataType.MultilineText, ErrorMessage = "Formato Incorreto.")]
        //public string Descricao { get; set; }

        public DateTime DataInclusao { get; set; }
    }
}