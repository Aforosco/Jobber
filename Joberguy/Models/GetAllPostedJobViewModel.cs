using System;
using System.ComponentModel.DataAnnotations;
namespace Joberguy.Models
{
	public class GetAllPostedJobViewModel
	{
		
            [Required]
            public string JobTitle { get; set; } = string.Empty;
            [Required]
            public string? Location { get; set; }
            [Required]
            public string? PostDate { get; set; }
            [Required]
            public string? expiringDate { get; set; }
            
        
	}
}

