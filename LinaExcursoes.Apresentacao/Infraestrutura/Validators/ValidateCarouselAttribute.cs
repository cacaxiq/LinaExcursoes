﻿using System.ComponentModel.DataAnnotations;

namespace LinaExcursoes.Apresentacao.Infraestrutura.Validators
{

    public class ValidateCarouselAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            var nomeCarousel = value as string;

            if (nomeCarousel.Contains("Carousel_"))
            {
                return true;
            }

            return false;
        }
    }
}