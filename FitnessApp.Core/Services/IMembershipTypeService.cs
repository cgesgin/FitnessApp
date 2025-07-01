using FitnessApp.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessApp.Core.Services
{
    public interface IMembershipTypeService
    {
        Task<IEnumerable<MembershipType>> GetAllAsync();
    }
}
