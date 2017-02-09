using System;
using System.ComponentModel.DataAnnotations;

namespace LinaExcursoes.Dominio.Tables
{
    public class TabelaBase
    {
        [Key]
        public long Id { get; set; }

        [MaxLength(50, ErrorMessage = "Excedeu tamanho permitido(50).")]
        public string Nome { get; set; }

        [MaxLength(400, ErrorMessage = "Excedeu tamanho permitido(400).")]
        public string Descricao { get; set; }

        public DateTime DataInclusao { get; set; }

        public DateTime DataAlteracao { get; set; }

        public bool Ativo { get; set; }
    }
}