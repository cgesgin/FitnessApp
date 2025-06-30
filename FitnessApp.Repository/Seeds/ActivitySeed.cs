using FitnessApp.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessApp.Repository.Seeds
{
    public class ActivitySeed : IEntityTypeConfiguration<Activity>
    {
        public void Configure(EntityTypeBuilder<Activity> builder)
        {
            builder.HasData(
                new Activity { Id = 1, Name = "Fitness" },
                new Activity { Id = 2, Name = "Swimming" },
                new Activity { Id = 3, Name = "Kickboxing" },
                new Activity { Id = 4, Name = "Yoga" },
                new Activity { Id = 5, Name = "Pilates" },
                new Activity { Id = 6, Name = "CrossFit" },
                new Activity { Id = 7, Name = "Spinning" },
                new Activity { Id = 8, Name = "Zumba" },
                new Activity { Id = 9, Name = "TRX" },
                new Activity { Id = 10, Name = "Stretching" }
            );
        }
    }
}
