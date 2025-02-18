using System;
using System.ComponentModel.DataAnnotations;
using Joberguy.Data;
using static Joberguy.Data.JobApplication;

namespace Joberguy.Models
{
	public class UpdateApplicationViewModel
	{
        [Required]
        public string Address { get; set; } = string.Empty;

        [Required]
        public string Nationality { get; set; } = string.Empty;

        [Required]
        public Gender Gender { get; set; }

        [Required]
        public IFormFile? File { get; set; }

        public DateTime ApplicationDate { get; set; }

    }
}

