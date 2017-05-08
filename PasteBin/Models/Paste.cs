﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PasteBin.Models
{
    public class Paste
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MinLength(3)]
        [MaxLength(300)]
        public string Title { get; set; }

        [Required]
        [DataType(DataType.MultilineText)]
        public string Content { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime CreatedOn { get; set; }

        public bool Private { get; set; }

        public string UserId { get; set; }

        [ForeignKey("UserId")]
        public virtual ApplicationUser User { get; set; }

        public int LanguageId { get; set; }

        [ForeignKey("LanguageId")]
        public virtual Language Language { get; set; }
    }
}