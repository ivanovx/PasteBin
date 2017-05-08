﻿using System.ComponentModel.DataAnnotations;

namespace PasteBin.Models
{
    public class Language
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Tag { get; set; }
    }
}