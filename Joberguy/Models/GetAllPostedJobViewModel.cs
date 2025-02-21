using System;
using System.ComponentModel.DataAnnotations;
namespace Joberguy.Models
{
	public class GetAllPostedJobViewModel
	{
[Required]
public int Id { get; set; }
[Required]
public string? JobRequirement { get; set; }
[Required]
public string? JobDescription { get; set; }
            [Required]
            public string JobTitle { get; set; } = string.Empty;
            [Required]
            public string? JobLocation { get; set; }
            [Required]
            public DateTime PostDateTime { get; set; }
            [Required]
            public DateTime expiringDate { get; set; }
            
        
	}
}

