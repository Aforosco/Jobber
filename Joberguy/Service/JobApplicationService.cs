using System;
using Joberguy.Data;
using Joberguy.Data.Migrations;
using Joberguy.Models;
using Joberguy.Repo;
using Mapster;
using Microsoft.AspNetCore.Builder;

namespace Joberguy.Service
{
	public interface IJobApplicationService
	{
		void Apply(SendApplicationViewModel send);
		void WidrawApplication(int Id);
		void UpdateApplication(UpdateApplicationViewModel amend);
		List<MyApplicationViewModel> AllAppliedJobs(string UserId);
        SingleApplicationViewModel singleApplicationView(int ApplicationId);



	}
	public class JobApplicationService:IJobApplicationService
	{
		IJobApplicationRepo _ja;
        private readonly IWebHostEnvironment _hostingEnvironment;
        public JobApplicationService(IJobApplicationRepo ja, IWebHostEnvironment hostingEnvironment)
		{
			_ja = ja;
            _hostingEnvironment = hostingEnvironment;
        }

        public List<MyApplicationViewModel> AllAppliedJobs(string userId)
        {
            var appliedjobs = _ja.GetAllJobApplied(userId);
            return appliedjobs.Adapt<List<MyApplicationViewModel>>();
        

        }

        public void Apply(SendApplicationViewModel send)
        {
            // Map the view model to the JobApplication DTO
            var app = send.Adapt<Data.JobApplication>();

            // Create and assign the Address entity from the dynamic address fields
            app.Address = new Data.Address
            {
                StreetAddress = send.Address,
                City = send.City,
                State = send.State,
                Country = send.Country,
                PostalCode = send.PostalCode
            };

            // Process file upload if a file was provided
            //if (send.File != null && send.File.Length > 0)
            //{
            //    // Generate a unique file name
            //    var fileName = Guid.NewGuid().ToString() + Path.GetExtension(send.File.FileName);

            //    // Define the folder path where the files will be stored (e.g., "Documents")
            //    var documentsPath = Path.Combine(_hostingEnvironment.WebRootPath, "Documents");

            //    // Create the folder if it doesn't exist
            //    if (!Directory.Exists(documentsPath))
            //    {
            //        Directory.CreateDirectory(documentsPath);
            //    }

            //    // Build the complete file path
            //    var filePath = Path.Combine(documentsPath, fileName);

            //    // Save the file locally
            //    using (var stream = new FileStream(filePath, FileMode.Create))
            //    {
            //        send.File.CopyToAsync(stream);
            //    }

            //    // Store the file's relative path in the database for later retrieval
            //    app.FilePath = "/Documents/" + fileName;
            //}

            // Save the job application using your repository/service
            _ja.SendApplication(app);
        }


        public void UpdateApplication(UpdateApplicationViewModel amend)
        {
            var update = amend.Adapt<Data.JobApplication>();
            _ja.UpdateJobApplication(update);
        }

        public void WidrawApplication(int Id)
        {
            _ja.WithdrawlApplication(Id);
        }

        public SingleApplicationViewModel singleApplicationView(int ApplicationId)
        {
            var application = _ja.JobApplication(ApplicationId);
            return application.Adapt<SingleApplicationViewModel>();

        }
    }
}

