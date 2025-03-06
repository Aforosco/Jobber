using System;
using System.ComponentModel.DataAnnotations;
namespace Joberguy.Models
{
    public class AllPostedJobsViewModel
    {
        public IEnumerable<GetAllPostedJobViewModel> Jobs { get; set; } = new List<GetAllPostedJobViewModel>();
        public int CurrentPage { get; set; }
        public int TotalPages { get; set; }
    }

}

