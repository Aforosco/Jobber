using System;
using Joberguy.Data;
using Joberguy.Models;
using Joberguy.Repo;
using Mapster;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Joberguy.Service
{
	public interface IJobService
	{
		void InsertJob(PostJobViewModel pjvm);
		void UpdateJob(EditJobViewModel edvm);
		void Delete(int Id);
        Job GetJobById(int jobId);
        Job GetApplicationforJob(int Id);
        AllPostedJobsViewModel AllPostedJobs(int page = 1);


    }
    public class JobService : IJobService
    {
        private readonly IJobRepo _jr;

        public JobService(IJobRepo jr)
        {
            _jr = jr;
        }

        public AllPostedJobsViewModel AllPostedJobs(int page = 1)
        {
            int pageSize = 10;
            // Get the paged jobs from the repository.
            var jobs = _jr.GetAllPostedJobs(page);
            // Get total count.
            var totalCount = _jr.GetJobsCount();

            var viewModel = new AllPostedJobsViewModel
            {
                Jobs = jobs.Adapt<List<GetAllPostedJobViewModel>>(), // Using Mapster to map
                CurrentPage = page,
                TotalPages = (int)Math.Ceiling(totalCount / (double)pageSize)
            };

            return viewModel;
        }
        public void Delete(int Id)
        {
            _jr.Deletejob(Id);
        }

        public Job GetJobById(int JobId)
        {
            var job = _jr.GetJobById(JobId);

            if (job == null)
            {
                throw new KeyNotFoundException($"Job with ID {JobId} not found.");
                // OR return null;
            }


            return job; // Return the Job entity, NOT SingleJobViewModel
        }


        public void InsertJob(PostJobViewModel pjvm)
        {
            var job = pjvm.Adapt<Job>(); // ✅ Convert `PostJobViewModel` to `Job`
            _jr.PostJob(job);
        }

        public void UpdateJob(EditJobViewModel edvm)
        {
            var job = edvm.Adapt<Job>(); // ✅ Convert `EditJobViewModel` to `Job`
            _jr.UpdateJobDetails(job);
        }

        public Job GetApplicationforJob(int Id)
        {
            var Applications = _jr.ApplicationRecieved(Id);

            if (Applications == null)
            {
                throw new KeyNotFoundException($"Job with ID {Id} not found.");
                // OR return null;
            }

            return Applications;
        }
    }

}


