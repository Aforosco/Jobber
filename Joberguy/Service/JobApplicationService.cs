﻿using System;
using Joberguy.Data;
using Joberguy.Models;
using Joberguy.Repo;
using Mapster;

namespace Joberguy.Service
{
	public interface IJobApplicationService
	{
		void Apply(SendApplicationViewModel send);
		void WidrawApplication(int Id);
		void UpdateApplication(UpdateApplicationViewModel amend);
		List<MyApplicationViewModel> AllAppliedJobs(string UserId);



	}
	public class JobApplicationService:IJobApplicationService
	{
		IJobApplicationRepo _ja;
		public JobApplicationService(IJobApplicationRepo ja)
		{
			_ja = ja;
		}

        public List<MyApplicationViewModel> AllAppliedJobs(string userId)
        {
            var appliedjobs = _ja.GetAllJobApplied(userId);
            return appliedjobs.Adapt<List<MyApplicationViewModel>>();
        

        }

        public void Apply(SendApplicationViewModel send)
        {
            var app = send.Adapt<JobApplication>();
            _ja.SendApplication(app);
        }

        public void UpdateApplication(UpdateApplicationViewModel amend)
        {
            var update = amend.Adapt<JobApplication>();
            _ja.UpdateJobApplication(update);
        }

        public void WidrawApplication(int Id)
        {
            _ja.WithdrawlApplication(Id);
        }
    }
}

