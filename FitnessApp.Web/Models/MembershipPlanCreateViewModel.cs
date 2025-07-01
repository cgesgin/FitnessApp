using FitnessApp.Core.Enums;
using FitnessApp.Core.Models;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace FitnessApp.Web.Models
{
    public class MembershipPlanCreateViewModel
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public decimal Price { get; set; }

        [Required]
        public int DurationValue { get; set; }

        [Required]
        public int MembershipTypeId { get; set; }

        [BindNever]
        public IEnumerable<SelectListItem> MembershipTypes { get; set; } = new List<SelectListItem>();

        [Required]
        public DurationType DurationType { get; set; }

        [BindNever]
        public IEnumerable<SelectListItem> DurationTypes { get; set; } = new List<SelectListItem>();

        [BindNever]
        public IEnumerable<Activity> AllActivities { get; set; } = new List<Activity>();

        [Required]
        public List<int> SelectedActivityIds { get; set; } = new List<int>();
    }


}
