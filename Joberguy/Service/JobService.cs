using System;
using Joberguy.Data;
using Joberguy.Models;
using Joberguy.Repo;
using Mapster;

namespace Joberguy.Service
{
	public interface IJobService
	{
		void InsertJob(PostJobViewModel pjvm);
		void UpdateJob(EditJobViewModel edvm);
		List<GetAllPostedJobViewModel>AllPostedJobs();
		void Delete(int Id);
        Job GetJobById(int jobId);
        Job GetApplicationforJob(int Id);


    }
    public class JobService : IJobService
    {
        private readonly IJobRepo _jr;

        public JobService(IJobRepo jr)
        {
            _jr = jr;
        }

        public List<GetAllPostedJobViewModel> AllPostedJobs()
        {
            var jobs = _jr.GetAllPostedJobs();
            return jobs.Adapt<List<GetAllPostedJobViewModel>>(); // ✅ Map `Job` to `GetAllPostedJobViewModel`
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


