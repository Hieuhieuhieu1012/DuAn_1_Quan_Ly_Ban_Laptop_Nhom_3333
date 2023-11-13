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
    public class KhachHangConfiguration:IEntityTypeConfiguration<KhachHang>
    {
        public void Configure(EntityTypeBuilder<KhachHang> builder)
        {
            builder.ToTable("KhachHang");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Ma).HasMaxLength(10).IsRequired();
            builder.Property(x => x.Hoten).HasMaxLength(50);
            builder.Property(x=>x.SoDienThoai).HasMaxLength(11);
            builder.Property(x=>x.DiaChi).HasMaxLength(100);
            builder.Property(x=>x.Email).HasMaxLength(100);
        }
    }
}
