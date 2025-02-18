using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Joberguy.Data
{
	public class Job
	{
        public Job()
		{
			postDateTime = DateTime.Now;
			expiringDate = postDateTime.AddDays(30);
            JobApplications = new HashSet<JobApplication>();
        }

		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int Id { get; set; }
		public string? JobTitle { get; set; }
		public string? JobDescription {get; set;}
		public string? JobLocation { get; set; }
		public string? JobRequirement { get; set; }
		public DateTime postDateTime { get; set; } 
		public DateTime expiringDate { get; set; }
        public virtual ICollection<JobApplication> JobApplications { get; set; }
    }
}

