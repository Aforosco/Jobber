﻿using System;
using Joberguy.Data;
using Microsoft.EntityFrameworkCore;

namespace Joberguy.Repo
{
	public interface IJobApplicationRepo
	{
		void SendApplication(JobApplication app);
		void WithdrawlApplication(int appId);
		void UpdateJobApplication(JobApplication app);
        List<JobApplication> GetAllJobApplied(string userid);
        JobApplication JobApplication(int appId);



	}
	public class JobApplicationRepo :IJobApplicationRepo
	{
		private readonly ApplicationDbContext _db;
		public JobApplicationRepo(ApplicationDbContext db)
		{
			_db = db;
		}

        public List<JobApplication> GetAllJobApplied(string userId)
        {
            return _db.applications.Include(a => a.Job).Where(p => p.UserId == userId).ToList();
            
           
        }

        
        public JobApplication JobApplication(int appId)
        {
            var application = _db.applications.Include(a=> a.Job).Include(b=>b.Address).FirstOrDefault(p => p.Id == appId);
            if (application == null)
            {
                throw new KeyNotFoundException($"Application with Id {appId} not found.");
            }
            return application;
        }


        public void SendApplication(JobApplication app)
        {
            _db.applications.Add(app);
            _db.SaveChanges();
        }

        public void UpdateJobApplication(JobApplication app)
        {
            var EditApplication = _db.applications.Where(p => p.Id.Equals(app.Id)).FirstOrDefault();
            if (EditApplication != null)
            {
                EditApplication.File = app.File;
                EditApplication.Nationality = app.Nationality;
                EditApplication.Address = app.Address;
                _db.SaveChanges();
            }
        }

        public void WithdrawlApplication(int appId)
        {
            var deleteApplication = _db.applications.Where(p => p.Id.Equals(appId)).FirstOrDefault();

            if(deleteApplication !=null)
            {
                _db.applications.Remove(deleteApplication);
                _db.SaveChanges();

            }

            

        }
    }
}

