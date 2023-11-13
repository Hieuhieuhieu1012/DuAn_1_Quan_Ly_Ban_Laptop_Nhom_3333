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
    public class NhanVienConfiguration:IEntityTypeConfiguration<NhanVien>
    {
        public void Configure(EntityTypeBuilder<NhanVien> builder)
        {
            builder.ToTable("NhanVien");
            builder.HasKey(x => x.Id);
            builder.Property(x=>x.Ma).HasMaxLength(10).IsRequired();
            builder.Property(x => x.Hoten).HasMaxLength(100);
            builder.Property(x => x.Email).HasMaxLength(100).IsRequired();
            builder.Property(x => x.SoDienThoai).HasMaxLength(11).IsRequired();
            builder.Property(x => x.CCCD).HasMaxLength(12);
            builder.Property(x => x.ChucVu).IsRequired();

        }
    }
}
