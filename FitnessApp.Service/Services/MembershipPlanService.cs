﻿using FitnessApp.Core.Models;
using FitnessApp.Core.Repositories;
using FitnessApp.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessApp.Service.Services
{
    public class MembershipPlanService : IMembershipPlanService
    {
        private readonly IMembershipPlanRepository _planRepository;

        public MembershipPlanService(IMembershipPlanRepository planRepository)
        {
            _planRepository = planRepository;
        }

        public async Task<IEnumerable<MembershipPlan>> GetAllAsync()
        {
            return await _planRepository.GetAllAsync();
        }

        public async Task AddAsync(MembershipPlan entity)
        {
            await _planRepository.AddAsync(entity);
        }

        public async Task<MembershipPlan> GetByIdAsync(int id)
        {
            return await _planRepository.GetByIdAsync(id);
        }

        public async Task SoftDeleteAsync(int id)
        {
            var plan = await _planRepository.GetByIdAsync(id);
            if (plan == null)
            {
                throw new KeyNotFoundException($"Membership plan plan with ID {id} not found.");
            }
            plan.IsDeleted = true;
            await _planRepository.UpdateAsync(plan);
        }
    }
}
