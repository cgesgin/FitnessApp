using FitnessApp.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessApp.Core.Services
{
    public interface IMembershipPlanService
    {
        Task<IEnumerable<MembershipPlan>> GetAllAsync();
        Task AddAsync(MembershipPlan entity);
        Task<MembershipPlan> GetByIdAsync(int id);
        Task SoftDeleteAsync(int id);
    }
}
