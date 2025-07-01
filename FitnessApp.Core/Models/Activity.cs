﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessApp.Core.Models
{
    public class Activity
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual IEnumerable<MembershipPlan> MembershipPlans { get; set; }
    }
}
