using System;
using Mapster;
using static Joberguy.Models.SendApplicationViewModel;
using System.Reflection;
using Joberguy.Models;
using Joberguy.Data;

namespace Joberguy.Service
{

    public class Mapsterconfig : IRegister
    {
        public void Register(TypeAdapterConfig config)
        {
            config.NewConfig<SendApplicationViewModel, JobApplication>().TwoWays()
                .Map(d => d.Id, s => s.Id)
                .Map(d => d.ApplicantLastName, s => s.ApplicantLastName)
                .Map(d => d.ApplicatFirstName, s => s.ApplicatFirstName)
                .Map(d => d.JobDescription, s => s.JobDescription)
                .Map(d => d.JobLocation, s => s.JobLocation)
                .Map(d => d.ApplicationDate, s => s.ApplicationDate);

            config.NewConfig<PostJobViewModel, Job>().TwoWays()
                .Map(d => d.JobLocation, s => s.JobLocation)
                .Map(d => d.JobDescription, s => s.JobDescription)
                .Map(d => d.JobRequirement, s => s.JobRequirement)
                .Map(d => d.JobTitle, s => s.JobTitle);

            config.NewConfig<EditJobViewModel, Job>().TwoWays()
                .Map(d => d.JobLocation, s => s.JobLocation)
                .Map(d => d.JobDescription, s => s.JobDescription)
                .Map(d => d.JobRequirement, s => s.JobRequirement)
                .Map(d => d.JobTitle, s => s.JobTitle);

            config.NewConfig<UpdateApplicationViewModel, JobApplication>().TwoWays() // ✅ Fixed mapping
                .Map(d => d.Address, s => s.Address)
                .Map(d => d.Gender, s => s.Gender)
                .Map(d => d.Nationality, s => s.Nationality)
                .Map(d => d.File, s => s.File);

            config.NewConfig<SingleJobViewModel, Job>().TwoWays()
                .Map(d => d.Id, s => s.Id)
                .Map(d => d.JobTitle, s => s.JobTitle)
                .Map(d => d.expiringDate, s => s.expiringDate)
                .Map(d => d.JobDescription, s => s.JobLocation)
                .Map(d => d.JobDescription, s => s.JobDescription)
                .Map(d => d.JobRequirement, s => s.JobRequirement)
                .Map(d => d.expiringDate, s => s.expiringDate);
            config.NewConfig<SingleJobViewModel, SendApplicationViewModel>()
                 .Map(d => d.ExpiringDate, s => s.expiringDate)
                 .Map(d => d.JobDescription, s => s.JobDescription)
                 .Map(d => d.JobLocation, s => s.JobLocation);

            config.NewConfig<SendApplicationViewModel, JobApplication>()
                .Map(d => d.ApplicatFirstName, s => s.ApplicatFirstName)
                .Map(d => d.ApplicantLastName, s => s.ApplicantLastName)
                .Map(d => d.JobLocation, s => s.JobLocation)
                // Instead of mapping a string to d.Address, build a new Address object:
                .Map(d => d.Address, s => new Address
                {
                    StreetAddress = s.Address,
                    City = s.City,
                    State = s.State,
                    Country = s.Country,
                    PostalCode = s.PostalCode
                })
                .Map(d => d.ApplicationDate, s => s.ApplicationDate)
                .Map(d => d.Gender, s => s.Gender)
                .Map(d => d.JobId, s => s.Id)
                .Map(d => d.Nationality, s => s.Nationality);

            config.NewConfig<SingleApplicationViewModel, JobApplication>()
               .Map(d => d.ApplicatFirstName, s => s.ApplicatFirstName)
                .Map(d => d.ApplicantLastName, s => s.ApplicantLastName)
                .Map(d => d.JobLocation, s => s.JobLocation)
               
                .Map(d => d.Address, s => new Address
                {
                    StreetAddress = s.Address,
                    City = s.City,
                    State = s.State,
                    Country = s.Country,
                    PostalCode = s.PostalCode
                })
                .Map(d => d.ApplicationDate, s => s.ApplicationDate)
                .Map(d => d.Gender, s => s.Gender)
                .Map(d => d.JobId, s => s.Id)
                .Map(d => d.Nationality, s => s.Nationality);
            config.NewConfig<JobApplication, MyApplicationViewModel>()
                    .Map(dest => dest.applicationId, src => src.Id)
                    .Map(dest => dest.JobTitle, src => src.Job != null ? src.Job.JobTitle : "N/A")
                    .Map(dest => dest.JobLocation, src => !string.IsNullOrEmpty(src.JobLocation) ? src.JobLocation : (src.Job != null ? src.Job.JobLocation : "N/A"))
                    .Map(dest => dest.ApplicationDate, src => src.ApplicationDate);
                   }
             
    }

    
}


