using FitnessApp.Core.Models;
using FitnessApp.Core.Repositories;
using FitnessApp.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessApp.Service.Services
{
    public class AcitivityService : IActivityService
    {
        private readonly IActivityRepository _activityRepository;

        public AcitivityService(IActivityRepository activityRepository)
        {
            _activityRepository = activityRepository ?? throw new ArgumentNullException(nameof(activityRepository));
        }

        public async Task<IEnumerable<Activity>> GetAllAsync()
        {
            return await _activityRepository.GetAllAsync();
        }

    }
}
