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
    public class ChiTietHoaDonConfiguration:IEntityTypeConfiguration<ChiTietHoaDon>
    {
        public void Configure(EntityTypeBuilder<ChiTietHoaDon> builder)
        {
            builder.ToTable("ChiTietHoaDon");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.DonGia).HasDefaultValue(0).HasColumnType("decimal(18,0)");
            builder.Property(x=>x.SoLuong).HasDefaultValue(0);
            builder.Property(x=>x.ThanhTien).HasDefaultValue(0).HasColumnType("decimal(18,0)");
            builder.Property(x => x.GiamGia).HasDefaultValue(0).HasColumnType("decimal(18,0)");
            builder.HasOne<Laptop>(x => x.Laptop).WithMany(a => a.ChiTietHoaDons).HasForeignKey(a => a.IdLaptop);
            builder.HasOne<HoaDon>(x => x.HoaDon).WithMany(a => a.ChiTietHoaDons).HasForeignKey(a => a.IdHoaDon);
        }
    }
}
