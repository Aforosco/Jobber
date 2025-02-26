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
        [Display(Name = "Job Description")]
        public string? JobDescription { get; set; }
        [Required]
        [Display(Name ="Job Location")]
        public string? JobLocation { get; set; }
        [Required]
        [Display(Name = "Skills Required ")]
        public string? JobRequirement { get; set; }
        [Required]
        [Display(Name = "Job Posted on  ")]
        public DateTime postDateTime { get; set; }
        [Required]
        [Display(Name = "Job Expires  on  ")]
        public DateTime expiringDate { get; set; }
    }
}

