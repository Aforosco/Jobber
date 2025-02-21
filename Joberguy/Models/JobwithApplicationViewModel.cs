using System;
using Joberguy.Data;
using System.ComponentModel.DataAnnotations.Schema;

namespace Joberguy.Models
{
	public class JobwithApplicationViewModel
	{

        public int Id { get; set; }
        public string? ApplicatFirstName { get; set; }
        public string? ApplicantLastName { get; set; }
        public string? Address { get; set; }
        public Gender Gender { get; set; }
        public string? JobLocation { get; set; }
        public string? Nationality { get; set; }
        public IFormFile? File { get; set; }
        public DateTime ApplicationDate { get; set; } 
        public ApplicationUser? User { get; set; }
        
    }
}

