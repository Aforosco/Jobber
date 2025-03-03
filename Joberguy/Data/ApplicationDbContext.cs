using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Joberguy.Data;

public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }
    public DbSet<Job>jobs { get; set; }
    public DbSet<JobApplication>applications { get; set; }
    public DbSet<Address> Addresses { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Job>().HasData(
            new Job { Id=-1, JobTitle = "Software Engineer", JobDescription = "Develop and maintain software applications.", JobLocation = "New York, USA", JobRequirement = "C#, .NET, SQL", postDateTime = DateTime.Now, expiringDate = DateTime.Now.AddDays(30) },
            new Job { Id = -2, JobTitle = "Data Analyst", JobDescription = "Analyze data and generate reports.", JobLocation = "San Francisco, USA", JobRequirement = "Python, SQL, Power BI", postDateTime = DateTime.Now, expiringDate = DateTime.Now.AddDays(30) },
            new Job { Id = -3, JobTitle = "Cybersecurity Specialist", JobDescription = "Protect company assets from cyber threats.", JobLocation = "London, UK", JobRequirement = "Network Security, Ethical Hacking", postDateTime = DateTime.Now, expiringDate = DateTime.Now.AddDays(30) },
            new Job { Id = -4, JobTitle = "UX/UI Designer", JobDescription = "Design user-friendly interfaces.", JobLocation = "Remote", JobRequirement = "Figma, Adobe XD, HTML/CSS", postDateTime = DateTime.Now, expiringDate = DateTime.Now.AddDays(30) },
            new Job { Id = -5, JobTitle = "Project Manager", JobDescription = "Manage project timelines and resources.", JobLocation = "Berlin, Germany", JobRequirement = "Agile, Scrum, PMP", postDateTime = DateTime.Now, expiringDate = DateTime.Now.AddDays(30) },
            new Job { Id = -6, JobTitle = "AI Engineer", JobDescription = "Develop AI models and algorithms.", JobLocation = "Toronto, Canada", JobRequirement = "TensorFlow, Machine Learning, Python", postDateTime = DateTime.Now, expiringDate = DateTime.Now.AddDays(30) },
            new Job { Id = -8, JobTitle = "DevOps Engineer", JobDescription = "Maintain CI/CD pipelines.", JobLocation = "Sydney, Australia", JobRequirement = "AWS, Kubernetes, Docker", postDateTime = DateTime.Now, expiringDate = DateTime.Now.AddDays(30) },
            new Job { Id = -9, JobTitle = "Marketing Manager", JobDescription = "Develop and execute marketing strategies.", JobLocation = "Paris, France", JobRequirement = "SEO, Google Ads, Content Marketing", postDateTime = DateTime.Now, expiringDate = DateTime.Now.AddDays(30) },
            new Job { Id = -10, JobTitle = "HR Specialist", JobDescription = "Manage hiring and employee relations.", JobLocation = "Dubai, UAE", JobRequirement = "HR Management, Recruitment", postDateTime = DateTime.Now, expiringDate = DateTime.Now.AddDays(30) },
            new Job { Id = -11, JobTitle = "Blockchain Developer", JobDescription = "Develop decentralized applications.", JobLocation = "Singapore", JobRequirement = "Solidity, Ethereum, Smart Contracts", postDateTime = DateTime.Now, expiringDate = DateTime.Now.AddDays(30) }
        );
    }
}

