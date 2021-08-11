using GoalVegan.API.Models;
using GoalVegan.Core.Entities;
using GoalVegan.Core.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoalVegan.Infrastructure.Persistence.Configurations
{
    class BuyerConfigurations : IEntityTypeConfiguration<Buyer>
    {
        public void Configure(EntityTypeBuilder<Buyer> builder)
        {
            builder
                .HasKey(b => b.Id);

            builder
                .HasMany(o => o.Orders)
                .WithOne()
                .HasForeignKey(b => b.Id)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
