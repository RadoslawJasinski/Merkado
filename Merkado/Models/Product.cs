﻿using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Merkado.Models
{
    public class Product
    {
        public int ProductId { get; set; }

        [StringLength(64)]
        [Required]
        [Display(Name = "Nazwa")]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Lokalizacja produktu")]
        public string Localization { get; set; }

        [Required]
        [Display(Name = "Opis")]
        public string Description { get; set; }

        [Required]
        public string CoverURL { get; set; }

        [Required]
        [Precision(18, 2)]
        [Display(Name = "Cena")]
        public decimal Price { get; set; }

        [Required]
        [Display(Name = "Data dodania")]
        public DateTime AddedDate { get; set; }

        [Required]
        [Display(Name = "Kategoria")]
        public Category Category { get; set; }

        [Required]
        [Display(Name = "Dostawa")]
        public List<Provider> Providers { get; set; }

        [Display(Name = "Zdjęcia")]
        public List<ProductImage>? Images { get; set; }

    }
}
