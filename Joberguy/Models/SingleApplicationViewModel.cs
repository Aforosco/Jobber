using System;
using Joberguy.Data;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Joberguy.Models
{
	public class SingleApplicationViewModel
	{

        public int Id { get; set; }

        [Required]
        public string ApplicatFirstName { get; set; } = string.Empty;

        [Required]
        public string ApplicantLastName { get; set; } = string.Empty;

        [Required]
        [Display(Name = "Street Address")]
        public string Address { get; set; } = string.Empty;

        [Display(Name = "City")]
        public string City { get; set; } = string.Empty;

        [Display(Name = "State/Province")]
        public string State { get; set; } = string.Empty;

        [Display(Name = "Country")]
        public string Country { get; set; } = string.Empty;

        [Display(Name = "Postal Code")]
        public string PostalCode { get; set; } = string.Empty;

        [Required]
        public string Nationality { get; set; } = string.Empty;

        [Required]
        public Gender Gender { get; set; }

        //  [Required]
        // public IFormFile? File { get; set; }

        public DateTime ExpiringDate { get; set; }

        public DateTime ApplicationDate { get; set; }

        public string? JobDescription { get; set; }
        public string? JobLocation { get; set; }
    }
}

