using System;
using System.ComponentModel.DataAnnotations;

namespace Joberguy.Models
{
	public class SingleJobViewModel
	{

        public int Id { get; set; }

        [Required]
        public string? JobTitle { get; set; }
        [Required]
        public string? JobDescription { get; set; }
        [Required]
        public string? JobLocation { get; set; }
        [Required]
        public string? JobRequirement { get; set; }
        [Required]
        public DateTime postDateTime { get; set; }
        [Required]
        public DateTime expiringDate { get; set; }
    }
}

