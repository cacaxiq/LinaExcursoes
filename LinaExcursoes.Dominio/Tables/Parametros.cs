using System.ComponentModel.DataAnnotations;

namespace LinaExcursoes.Dominio.Tables
{
    public class Parametros : TabelaBase
    {
        [MaxLength(50, ErrorMessage = "Excedeu tamanho permitido(50).")]
        public string NomeParametro { get; set; }

        [MaxLength(20, ErrorMessage = "Excedeu tamanho permitido(20).")]
        public string TagHTML { get; set; }

        public string Conteudo { get; set; }
    }
}