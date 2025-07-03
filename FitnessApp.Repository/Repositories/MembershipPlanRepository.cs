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

        public async Task<MembershipPlan> GetByIdAsync(int id)
        {
            return await _context.MembershipPlans
                .FirstOrDefaultAsync(mp => mp.Id == id && !mp.IsDeleted);
        }

        public async Task UpdateAsync(MembershipPlan entity)
        {
            _context.MembershipPlans.Update(entity);
            await _context.SaveChangesAsync();
        }
    }
}
