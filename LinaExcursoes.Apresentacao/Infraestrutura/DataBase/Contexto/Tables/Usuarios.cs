using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Security;
using WebSite.Infraestrutura.DataBase.Contexto.Tables;

namespace WebSite_LinaExcursao.Infraestrutura.DataBase.Contexto.Tables
{
    public class Usuarios : TabelaBase
    {
        [MaxLength(100, ErrorMessage = "Excedeu tamanho permitido(20).")]
        [Required(ErrorMessage = "Campo deve ser preenchido.")]
        public string Nome { get; set; }

        [MaxLength(20, ErrorMessage = "Excedeu tamanho permitido(20).")]
        [Required(ErrorMessage = "Campo deve ser preenchido.")]
        public string Login { get; set; }

        [DataType(DataType.Password)]
        [MaxLength(8, ErrorMessage = "Excedeu tamanho permitido(8).")]
        [Required(ErrorMessage = "Campo deve ser preenchido.")]
        public string Senha { get; set; }

        [Compare("Senha",ErrorMessage ="Senhas não são identicas.")]
        [NotMapped]
        [MaxLength(8, ErrorMessage = "Excedeu tamanho permitido(8).")]
        [Required(ErrorMessage = "Campo deve ser preenchido.")]
        [DataType(DataType.Password)]
        public string ContraSenha { get; set; }

        [NotMapped]
        [Required(ErrorMessage = "Campo deve ser preenchido.")]
        [DataType(DataType.Password)]
        public string Token { get; set; }
    }
}