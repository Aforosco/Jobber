﻿using System;
using System.ComponentModel.DataAnnotations;
namespace Joberguy.Models
{
	public class PostJobViewModel
    {

        [Required]
        public string JobTitle { get; set; } = string.Empty;
        [Required]
        public string JobDescription { get; set; } = string.Empty;
        [Required]
        public string? JobLocation { get; set; } = string.Empty;
        [Required]
        public string? JobRequirement { get; set; } = string.Empty;
       
    }
}

