using System;
using Joberguy.Data;

namespace Joberguy.Repo
{
	public interface IJobRepo
	{
		void PostJob(Job j);
		List<Job> GetAllPostedJobs();
		void UpdateJobDetails(Job j);
		void Deletejob(int jobId);
        Job GetJobById(int JobID);

	}
	public class JobRepo:IJobRepo
	{
		private readonly ApplicationDbContext _db;

		public JobRepo(ApplicationDbContext applicationDb)
		{
			_db = applicationDb;
		}

        public void Deletejob(int jobId)
        {
            var jobtodelete = _db.jobs.Where(p => p.Id.Equals(jobId)).FirstOrDefault();

            if(jobtodelete != null)
            {
                _db.jobs.Remove(jobtodelete);
                _db.SaveChanges();
            }
            
        } 

        public List<Job> GetAllPostedJobs()
        {
          var alljobs =  _db.jobs.OrderBy(p => p.expiringDate).ToList();
            return alljobs;
        }

        public Job GetJobById(int JobId)
        {
            var job = _db.jobs.Find(JobId);

            if (job == null)
            {
                // Handle the case where the job is not found, 
                // such as returning null or throwing a custom exception
                throw new KeyNotFoundException($"Job with ID {JobId} not found.");
            }

            return job;

        }

        public void PostJob(Job j)
        {
            _db.jobs.Add(j);
            _db.SaveChanges();
        }

        public void UpdateJobDetails(Job j)
        {
            var jobupdate = _db.jobs.Where(p => p.Id.Equals(j.Id)).FirstOrDefault();
            if(jobupdate != null)
            {
                jobupdate.JobTitle = j.JobTitle;
                jobupdate.JobRequirement = j.JobRequirement;
                jobupdate.JobLocation = j.JobLocation;
                _db.SaveChanges();


            }
            
        }
    }
}

