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
    public class MembershipTypeSeed : IEntityTypeConfiguration<MembershipType>
    {
        public void Configure(EntityTypeBuilder<MembershipType> builder)
        {
            builder.HasData(
                new MembershipType { Id = 1, Name = "Personal Training" ,Description= "One-to-one training with a personal trainer." },
                new MembershipType { Id = 2, Name = "Group Training" , Description= "Group lessons with instructor." }
            );
        }
    }
}