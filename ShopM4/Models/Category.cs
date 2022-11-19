﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace ShopM4.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        [DisplayName("Display Order")]
        public int DisplayOrder { get; set; }
    }
}

