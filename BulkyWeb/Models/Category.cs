﻿using System.ComponentModel.DataAnnotations;

namespace BulkyWeb.Models
{
    public class Category
    {
        [Key]
        public int id { get; set; }

        [Required]
        public string Name { get; set; }

        public int DispayOrder { get; set; }
    }
}
