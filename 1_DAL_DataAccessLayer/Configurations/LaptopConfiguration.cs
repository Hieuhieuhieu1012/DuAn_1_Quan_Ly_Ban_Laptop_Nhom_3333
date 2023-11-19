using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using _1_DAL_DataAccessLayer.Models;
using _1_DAL_DataAccessLayer.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace _1_DAL_DataAccessLayer.Configurations
{
    public class LaptopConfiguration : IEntityTypeConfiguration<Laptop>
    {
        public void Configure(EntityTypeBuilder<Laptop> builder)
        {
            builder.ToTable("Laptop");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.GiaBan).HasColumnType("decimal(18,0)").IsRequired();
            builder.Property(x => x.GiaNhap).HasColumnType("decimal(18,0)").IsRequired();
            builder.Property(x => x.NamBh).IsRequired();
            builder.Property(x => x.TrangThai).HasDefaultValue(true);
            builder.Property(x => x.TrongLuong).HasColumnType("decimal(18,0)").IsRequired();
            builder.Property(x => x.Ten).HasMaxLength(50);

            //builder.Property(x => x.NhaCungCap).IsRequired();
            //builder.Property(x => x.DongLaptop).IsRequired();
            //builder.Property(x => x.HangLaptop).IsRequired();
            //builder.Property(x => x.Cpu).IsRequired();
            //builder.Property(x => x.Ram).IsRequired();
            //builder.Property(x => x.MauSac).IsRequired();
            //builder.Property(x => x.ManHinh).IsRequired();
            //builder.Property(x => x.OCung).IsRequired();
          //  builder.Property(x => x.ChiTietLaptops).IsRequired();

          builder.HasOne<HangLaptop>(x => x.HangLaptop).WithMany(a => a.Laptops).HasForeignKey(x => x.IdHangLaptop). OnDelete(DeleteBehavior.Restrict);
            builder.HasOne<DongLaptop>(x => x.DongLaptop).WithMany(a => a.Laptops).HasForeignKey(x => x.IdDongLaptop);
            builder.HasOne<NhaCungCap>(x => x.NhaCungCap).WithMany(a => a.Laptops).HasForeignKey(x => x.IdNhaCungCap);
            builder.HasOne<Cpu>(x => x.Cpu).WithMany(a => a.Laptops).HasForeignKey(x => x.IdCpu);
            builder.HasOne<Vga>(x => x.Vga).WithMany(a => a.Laptops).HasForeignKey(x => x.IdVga);
            builder.HasOne<Ram>(x => x.Ram).WithMany(a => a.Laptops).HasForeignKey(x => x.IdRam);
            builder.HasOne<ManHinh>(x => x.ManHinh).WithMany(a => a.Laptops).HasForeignKey(x => x.IdManHinh);
            builder.HasOne<MauSac>(x => x.MauSac).WithMany(a => a.Laptops).HasForeignKey(x => x.IdMauSac);
            builder.HasOne<OCung>(x => x.OCung).WithMany(a => a.Laptops).HasForeignKey(x => x.IdOCung);

            builder.HasMany<SerialLaptop>(c => c.SerialLaptops).WithOne(a => a.Laptop).HasForeignKey(a => a.IdLaptop);

            builder.HasOne<KhuyenMai>(c => c.KhuyenMai).WithMany(a => a.Laptops).HasForeignKey(c => c.IdKhuyenMai);
        }
    }
}
