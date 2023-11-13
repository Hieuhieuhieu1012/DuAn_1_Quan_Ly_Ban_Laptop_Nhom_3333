using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1_DAL_DataAccessLayer.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace _1_DAL_DataAccessLayer.Configurations
{
    public class HangLaptopConfiguration : IEntityTypeConfiguration<HangLaptop>
    {
        public void Configure(EntityTypeBuilder<HangLaptop> builder)
        {
            builder.ToTable("HangLaptop");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Ma).HasMaxLength(10).IsRequired();
            builder.Property(x => x.Ten).HasMaxLength(50).IsRequired();

            builder.HasMany<DongLaptop>(x => x.DongLaptops).WithOne(x => x.HangLaptop)
                .HasForeignKey(x => x.IdHangLaptop);
        }
    }
}
