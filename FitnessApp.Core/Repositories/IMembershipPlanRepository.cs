using FitnessApp.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessApp.Core.Repositories
{
    public interface IMembershipPlanRepository
    {
        Task<IEnumerable<MembershipPlan>> GetAllAsync();
        Task AddAsync(MembershipPlan entity);
        Task<MembershipPlan> GetByIdAsync(int id);
        Task UpdateAsync(MembershipPlan entity);

    }
}
