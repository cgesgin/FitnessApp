using FitnessApp.Core.Models;
using FitnessApp.Core.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessApp.Repository.Repositories
{
    public class MembershipPlanRepository : IMembershipPlanRepository
    {
        private readonly AppDbContext _context;

        public MembershipPlanRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<MembershipPlan>> GetAllAsync()
        {
            return await _context.MembershipPlans
                .Where(mp => !mp.IsDeleted)
                .Include(mp => mp.MembershipType)
                .Include(mp => mp.Activities)
                .ToListAsync();
        }

        public async Task AddAsync(MembershipPlan entity)
        {
            await _context.MembershipPlans.AddAsync(entity);
            await _context.SaveChangesAsync();
        }
    }
}
