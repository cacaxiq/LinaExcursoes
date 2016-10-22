using System.ComponentModel.DataAnnotations;

namespace WebSite.Infraestrutura.DataBase.Contexto.Tables
{
    public class Parametros : TabelaBase
    {
        [MaxLength(10, ErrorMessage = "Excedeu tamanho permitido.")]
        public string TagHTML { get; set; }

        public string Conteudo { get; set; }
    }
}