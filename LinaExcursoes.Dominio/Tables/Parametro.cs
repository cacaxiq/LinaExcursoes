using System.ComponentModel.DataAnnotations;

namespace LinaExcursoes.Dominio.Tables
{
    public class Parametro : TabelaBase
    {
        [MaxLength(20, ErrorMessage = "Excedeu tamanho permitido(20).")]
        public string TagHTML { get; set; }

        public string Conteudo { get; set; }

        Usuario CriadoPor { get; set; }

        Usuario AlteradoPor { get; set; }
    }
}