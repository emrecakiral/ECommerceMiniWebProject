using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityConfiguration
{
    public class CompanyConfiguration : IEntityTypeConfiguration<Company>
    {
        public void Configure(EntityTypeBuilder<Company> builder)
        {
            builder.HasKey(c => c.CompanyID);

            builder.HasOne(c => c.About)
                .WithOne(c => c.Company)
                .HasForeignKey<Company>(c => c.AboutID)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasMany(c => c.Products)
                .WithOne(c => c.Company)
                .HasForeignKey(c => c.CompanyID)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
