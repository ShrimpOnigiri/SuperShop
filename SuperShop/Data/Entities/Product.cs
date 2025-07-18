﻿using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Diagnostics.CodeAnalysis;

namespace SuperShop.Data.Entities
{
    public class Product
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(50, ErrorMessage ="The field {0} cannot contain more than {1} characters in length.")]
        public string Name { get; set; }

        [DisplayFormat(DataFormatString = "{0:C2}", ApplyFormatInEditMode =false)]
        public decimal Price { get; set; }

        [Display(Name= "Image")]
        public string? ImageUrl { get; set; }

        [Display (Name = "Last Purchase")]
        public DateTime? LastPurchase {  get; set; }


        [Display(Name = "Last Sale")]
        public DateTime? LastSale { get; set; }

        [Display(Name = "Is Available")]
        public bool IsAvailable { get; set; }

        [DisplayFormat(DataFormatString = "{0:N2}", ApplyFormatInEditMode = false)]
        public decimal Stock { get; set; }
    }
}
