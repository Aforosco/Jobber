using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Joberguy.Data;
using Joberguy.Models;
using Joberguy.Service;
using Mapster;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Joberguy.Controllers
{
    
    [ValidateAntiForgeryTokenAttribute]
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
            return RedirectToAction("AllJobs");

        }

        [HttpGet]
        public IActionResult GetAllPostedJobs()
        {

            List<GetAllPostedJobViewModel> alljobs = _ijs.AllPostedJobs();

            return View(alljobs);

        }


        [HttpGet]
        [Authorize(Roles = "Admin")]
        public IActionResult EditPostedJob()
        {


            return View();
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

            return RedirectToAction("AllJobs");

        }


        [HttpPost]
        [Authorize(Roles = "Admin")]
        public IActionResult DeleteJob(int id)
        {
            _ijs.Delete(id);
            return View();

        }


        [HttpGet]
        public IActionResult SendApplication()
        {

            return View();

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
            if (user == null) return RedirectToAction("Login", "Account"); // Ensure the user is logged in

            var myApplications = _ija.AllAppliedJobs(user.Id);
            return View(myApplications);
        }

        [HttpGet]
        public IActionResult GetJobByID(int id)
        {
            try
            {
                var job = _ijs.GetJobById(id);

                if (job == null)
                {
                    return NotFound(new { message = $"Job with ID {id} not found." });
                }

                // Convert Job → SingleJobViewModel
                var jobViewModel = job.Adapt<SingleJobViewModel>();

                return Ok(jobViewModel);
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = "An error occurred.", details = ex.Message });
            }
        }

        [HttpGet]
        public IActionResult JobApplicationRecieved(int id)
        {
            var Applications = _ijs.GetApplicationforJob(id);
            return Ok(Applications);

        }

    }

}

