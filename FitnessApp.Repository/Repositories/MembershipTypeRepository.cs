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
    public class MembershipTypeRepository : IMembershipTypeRepository
    {
        private readonly AppDbContext _context;

        public MembershipTypeRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<MembershipType>> GetAllAsync()
        {
            return await _context.MembershipTypes.ToListAsync();
        }
    }
}
