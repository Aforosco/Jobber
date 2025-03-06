using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Joberguy.Data;
using Joberguy.Models;
using Joberguy.Service;
using Mapster;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using static System.Net.Mime.MediaTypeNames;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Joberguy.Controllers
{
    
   
    public class JobController : Controller
    {
        private readonly IJobService _ijs;
        private readonly IJobApplicationService _ija;
        private readonly UserManager<ApplicationUser> _userManager; 
        public JobController(IJobService ijs, IJobApplicationService ija, UserManager<ApplicationUser> userManager)
        {
            _ijs = ijs;
            _ija = ija;
            _userManager = userManager;
        }

        [HttpGet]
        [Authorize(Roles ="Admin")]
        public IActionResult PostJob()
        {

            return View();

        }


        [HttpPost]
        [Authorize(Roles = "Admin")]
        public IActionResult PostJob(PostJobViewModel Pjvm)
        {
            if (!ModelState.IsValid)
            {
                return View(Pjvm); // Return the same view with validation errors
            }

            _ijs.InsertJob(Pjvm);

            TempData["SuccessMessage"] = "Job posted successfully!";
            return RedirectToAction("GetAllPostedJobs");

        }

        [HttpGet]
        [IgnoreAntiforgeryToken]
        public IActionResult GetAllPostedJobs(int page = 1)
        {
            var viewModel = _ijs.AllPostedJobs(page);
            return View(viewModel);
        }


        [HttpGet]
        [Authorize(Roles = "Admin")]
        public IActionResult EditPostedJob(int id)
        {

            var job = _ijs.GetJobById(id);
            if (job == null)
            {
                return NotFound();
            }
            var model = new EditJobViewModel
            {
                JobTitle = job.JobTitle?? string.Empty,
                JobDescription = job.JobDescription ?? string.Empty,
                JobLocation = job.JobLocation,
                JobRequirement = job.JobRequirement
            };

            return View(model);
        }



        [HttpPost]
        [Authorize(Roles = "Admin")]
        public IActionResult EditPostedJob(EditJobViewModel amend)
        {

            if (!ModelState.IsValid)
            {
                return View(amend);
            }
            _ijs.UpdateJob(amend);

            TempData["SuccessMessage"] = "Job Updated successfully!";

            return RedirectToAction("GetAllPostedJobs");

        }


        [HttpPost]
        [Authorize(Roles = "Admin")]
        public IActionResult DeleteJob(int id)
        {
            try
            {
                _ijs.Delete(id);
                return Ok("Job deleted successfully!");
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Error deleting job: " + ex.Message);
            }
        }


        [HttpGet]
        public IActionResult SendApplication(int jobId)
        {
            // Get the job details based on the jobId
            var job = _ijs.GetJobById(jobId);
            if (job == null) return NotFound();

            // Create a new SendApplicationViewModel and map the job data to it
            var sendApplicationViewModel = new SendApplicationViewModel
            {
                JobDescription = job.JobDescription,
                JobLocation = job.JobLocation,
                ExpiringDate = job.expiringDate,
                Id = job.Id,
                UserId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value ?? string.Empty,
                ApplicationDate = DateTime.Today
            };

            // Return the view with the model
            return View(sendApplicationViewModel);
        }


        [HttpPost]
        public IActionResult SendApplication(SendApplicationViewModel apply)
        {

            if (!ModelState.IsValid)
            {
                return View(apply);
            }
            _ija.Apply(apply);

            TempData["SuccessMessage"] = "Application Send successfully!";

            return RedirectToAction("ViewMyApplications");
        }

        [HttpPost]

        public IActionResult WithdrawApplication(int id)
        {
            _ija.WidrawApplication(id);
            return View();
        }

        [HttpGet]
        public IActionResult EditApplication()
        {

            return View();
        }

        [HttpPost]

        public IActionResult EditApplication(UpdateApplicationViewModel uapv)
        {

            if (!ModelState.IsValid)
            {
                return View(uapv);
            }
            _ija.UpdateApplication(uapv);

            TempData["SuccessMessage"] = "Application Updated successfully!";
            return RedirectToAction("ViewMyApplications");
        }

        [HttpGet]
        public async Task<IActionResult> ViewMyApplications()
        {
            var user = await _userManager.GetUserAsync(User);
            if (user == null) return RedirectToAction("Login", "Account"); 

            var myApplications = _ija.AllAppliedJobs(user.Id);
            return View(myApplications);
        }

        [Route("Job/GetJobById/{id}")]
        [HttpGet]
        [IgnoreAntiforgeryToken]
        public IActionResult GetJobById(int id)
        {
            var job = _ijs.GetJobById(id);
            if (job == null) return NotFound();

            var jobViewModel = job.Adapt<SingleJobViewModel>();

            return View("GetJobById", jobViewModel); 
        }


        [HttpGet]
        public IActionResult JobApplicationRecieved(int id)
        {
            var Applications = _ijs.GetApplicationforJob(id);
            if (Applications == null )
            {
                return View(new List<JobApplication>()); 
            }
            ViewBag.JobTitle = Applications.JobTitle ?? "Job Applications";

            return Ok(Applications);

        }

        [HttpGet]
        public IActionResult ViewSingleApplication(int ApplicationId)
        {
            var application = _ija.singleApplicationView(ApplicationId);
            if (application == null)
            {
                return NotFound(); // or handle the error as needed
            }
            return View("SingleApplicationView", application);
        }


    }

}

