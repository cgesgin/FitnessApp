using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessApp.Core.Models
{
    public class MembershipPlan
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int DurationValue { get; set; }
        public string DurationType { get; set; }

        public int MembershipTypeId { get; set; }
        public MembershipType MembershipType { get; set; }

        public virtual IEnumerable<Activity> Activities { get; set; }

        // System properties
        public bool IsDeleted { get; set; } = false;
    }
}
