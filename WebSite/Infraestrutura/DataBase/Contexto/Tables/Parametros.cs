using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebSite.Infraestrutura.DataBase.Contexto.Tables
{
    public class Parametros : TabelaBase
    {
        public string Conteudo { get; set; }
        public string TagHTML { get; set; }



        //[MaxLength(30, ErrorMessage = "Excedeu tamanho permitido.")]
        //public string Matricula { get; set; }

        //[Required(ErrorMessage = "O CPF é obrigatório.")]
        //public long? CPF { get; set; }

        //[MaxLength(15, ErrorMessage = "Excedeu tamanho permitido.")]
        //[Required(ErrorMessage = "Telefone é necessário para contato.")]
        //public string Telefone { get; set; }

        //[MaxLength(30, ErrorMessage = "Excedeu tamanho permitido.")]
        //public string Email { get; set; }

        //[DataType(DataType.Currency)]
        //public string ValorDesejado { get; set; }

        //[MaxLength(300, ErrorMessage = "Excedeu tamanho permitido.")]
        //[DataType(DataType.MultilineText, ErrorMessage = "Formato Incorreto.")]
        //public string Mensagem { get; set; }
        //public bool Efetivo { get; set; }
        //public bool EmailEnviado { get; set; }
        //public string Tipo { get; set; }
    }
}