using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebSite.Models
{
    public class CauroselViewModel
    {
        [Required(ErrorMessage = "Campo deve ser preenchido.")]
        public string NomeCarousel { get; set; }

        [Required(ErrorMessage = "Campo deve ser preenchido.")]
        public string Imagem { get; set; }


        public string Titulo { get; set; }

        public string SubTitulo { get; set; }
    }
}