using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Joberguy.Data
{
    public class JobApplication
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string? ApplicatFirstName { get; set; }
        public string? ApplicantLastName { get; set; }
        [Required]
        public Gender Gender { get; set; }
        public string? JobDescription { get; set; }
        public string? JobLocation { get; set; }
        public string? Nationality { get; set; }
        [NotMapped]
        public IFormFile? File { get; set; }
        public DateTime ApplicationDate { get; set; } = DateTime.Now;
        public bool HasApplied { get; set; } = false;
        [ForeignKey("JobId")]
        public int JobId { get; set; }
        public virtual Job? Job { get; set; }
        [ForeignKey("UserId")]
        public string? UserId { get; set; }
        [ForeignKey("Id")]
        public virtual Address? Address {get;set;}

        public virtual ApplicationUser? User { get; set; }

    }
}

