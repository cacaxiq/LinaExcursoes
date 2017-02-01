using LinaExcursoes.Apresentacao.Infraestrutura.Validators;
using System.ComponentModel.DataAnnotations;
using System.Configuration;

namespace LinaExcursoes.Apresentacao.Models
{
    public class CauroselViewModel
    {
        [Required(ErrorMessage = "Campo deve ser preenchido.")]
        [ValidateCarousel(ErrorMessage = "O nome do carousel deve começar com 'Carousel'")]
        public string NomeCarousel { get; set; }


        private string _imagem;
        [MaxLength(20, ErrorMessage = "Excedeu tamanho permitido(20).")]
        [Required(ErrorMessage = "Campo deve ser preenchido.")]

        public string Imagem { get { return _imagem; } set { _imagem = string.Format(ConfigurationManager.AppSettings["caminhoImagens"], value); } }
        public string Titulo { get; set; }

        public string SubTitulo { get; set; }
    }
}