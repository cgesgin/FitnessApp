using FitnessApp.Core.Enums;
using FitnessApp.Core.Models;
using FitnessApp.Core.Services;
using FitnessApp.Web.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace FitnessApp.Web.Controllers
{
    [Authorize(Roles = "Admin")]
    public class MembershipPlanController : Controller
    {
        private readonly IMembershipPlanService _planService;
        private readonly IMembershipTypeService _membershipTypeService;
        private readonly IActivityService _activityService;

        public MembershipPlanController(IMembershipPlanService planService, IMembershipTypeService membershipTypeService, IActivityService activityService)
        {
            _planService = planService;
            _membershipTypeService = membershipTypeService;
            _activityService = activityService;
        }

        public async Task<IActionResult> Index()
        {
            var plans = await _planService.GetAllAsync();

            return View(plans);
        }

        public async Task<IActionResult> Create()
        {
            var membershipTypes = await _membershipTypeService.GetAllAsync();

            var model = new MembershipPlanCreateViewModel
            {
                MembershipTypes = membershipTypes
                    .Select(mt => new SelectListItem
                    {
                        Value = mt.Id.ToString(),
                        Text = mt.Name
                    }).ToList(),
                DurationTypes = Enum.GetValues(typeof(DurationType)).Cast<DurationType>()
                    .Select(e => new SelectListItem
                    {
                        Value = e.ToString(),
                        Text = e.ToString()
                    }).ToList(),
                AllActivities = await _activityService.GetAllAsync(),

            };

            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(MembershipPlanCreateViewModel model)
        {
            if (!ModelState.IsValid)
            {
                var errors = ModelState.Values.SelectMany(v => v.Errors);
                foreach (var err in errors)
                {
                    Console.WriteLine(err.ErrorMessage);
                }
                await PopulateSelectListsAsync(model);
                return View("Create", model);
            }

            var membershipPlan = new MembershipPlan
            {
                Name = model.Name,
                Price = model.Price,
                DurationValue = model.DurationValue,
                DurationType = model.DurationType.ToString(),
                MembershipTypeId = model.MembershipTypeId
            };

            if (model.SelectedActivityIds != null && model.SelectedActivityIds.Any())
            {
                var allActivities = await _activityService.GetAllAsync();
                membershipPlan.Activities = allActivities
                    .Where(a => model.SelectedActivityIds.Contains(a.Id))
                    .ToList();
            }

            await _planService.AddAsync(membershipPlan);

            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int id)
        {
            var plan = await _planService.GetByIdAsync(id);
            if (plan == null)
            {
                return NotFound();
            }
            await _planService.SoftDeleteAsync(plan.Id);
            return RedirectToAction(nameof(Index));
        }

        private async Task PopulateSelectListsAsync(MembershipPlanCreateViewModel model)
        {
            var membershipTypes = await _membershipTypeService.GetAllAsync();
            model.MembershipTypes = membershipTypes
                .Select(mt => new SelectListItem
                {
                    Value = mt.Id.ToString(),
                    Text = mt.Name
                }).ToList();

            model.DurationTypes = Enum.GetValues(typeof(DurationType))
                .Cast<DurationType>()
                .Select(e => new SelectListItem
                {
                    Value = e.ToString(),
                    Text = e.ToString()
                }).ToList();

            model.AllActivities = await _activityService.GetAllAsync();
        }

    }
}
