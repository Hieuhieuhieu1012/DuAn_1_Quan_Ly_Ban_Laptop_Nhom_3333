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
    public class SerialLaptopConfiguration: IEntityTypeConfiguration<SerialLaptop>
    {
        public void Configure(EntityTypeBuilder<SerialLaptop> builder)
        {
            builder.ToTable("SerialLaptop");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Serial).HasMaxLength(50).IsRequired();
            
        }
    }
}
