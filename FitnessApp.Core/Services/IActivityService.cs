﻿using FitnessApp.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessApp.Core.Services
{
    public interface IActivityService
    {
        Task<IEnumerable<Activity>> GetAllAsync();
    }
}
