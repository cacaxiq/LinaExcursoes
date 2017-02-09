using LinaExcursoes.Dominio.Tables;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Configuration;

namespace LinaExcursoes.Dominio.Tables
{
    public class Viagem : TabelaBase
    {
        [MaxLength(100, ErrorMessage = "Excedeu tamanho permitido(100).")]
        public string Local { get; set; }

        [MaxLength(100, ErrorMessage = "Excedeu tamanho permitido(100).")]
        public string Periodo { get; set; }

        [MaxLength(150, ErrorMessage = "Excedeu tamanho permitido(150).")]
        public string Valor { get; set; }

        [MaxLength(20, ErrorMessage = "Excedeu tamanho permitido(20).")]
        public string Tipo { get; set; }

        [MaxLength(20, ErrorMessage = "Excedeu tamanho permitido(20).")]
        public string Imagem { get; set; }

        [DisplayFormat(DataFormatString = "{0:dd MMM yyyy}")]
        public DateTime DataSaida { get; set; }

        [DisplayFormat(DataFormatString = "{0:dd MMM yyyy}")]
        public DateTime DataRetorno
        {
            get; set;
        }

        Usuario CriadoPor { get; set; }

        Usuario AlteradoPor { get; set; }
    }
}