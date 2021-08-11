using GoalVegan.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoalVegan.Infrastructure.Persistence.Configurations
{
    class SellerConfiguration : IEntityTypeConfiguration<Seller>
    {
        public void Configure(EntityTypeBuilder<Seller> builder)
        {
            builder
                .HasKey(s => s.Id);

            builder
                .HasMany(o => o.Orders)
                .WithOne()
                .HasForeignKey(b=>b.Id)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasMany(p => p.Products)
                .WithOne()
                .HasForeignKey(p => p.Id)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
