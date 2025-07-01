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
    public class MembershipTypeService : IMembershipTypeService
    {
        private readonly IMembershipTypeRepository _membershipTypeRepository;

        public MembershipTypeService(IMembershipTypeRepository membershipTypeRepository)
        {
            _membershipTypeRepository = membershipTypeRepository;
        }

        public async Task<IEnumerable<MembershipType>> GetAllAsync()
        {
            return await _membershipTypeRepository.GetAllAsync();
        }
    }
}
