﻿using FitnessApp.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessApp.Core.Repositories
{
    public interface IActivityRepository
    {
        Task<IEnumerable<Activity>> GetAllAsync();
    }
}
