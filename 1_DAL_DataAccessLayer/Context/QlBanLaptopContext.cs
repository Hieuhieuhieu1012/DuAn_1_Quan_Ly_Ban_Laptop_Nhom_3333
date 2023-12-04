using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;
using _1_DAL_DataAccessLayer.Configurations;
using _1_DAL_DataAccessLayer.Models;
using _1_DAL_DataAccessLayer.Repositories;
using Microsoft.EntityFrameworkCore;

namespace _1_DAL_DataAccessLayer.Context
{
    public class QlBanLaptopContext : DbContext
    {
        public QlBanLaptopContext()
        {

        }

        public QlBanLaptopContext(DbContextOptions<QlBanLaptopContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ChiTietHoaDonConfiguration());
            modelBuilder.ApplyConfiguration(new CpuConfiguration());
            modelBuilder.ApplyConfiguration(new DongLaptopConfiguration());
            modelBuilder.ApplyConfiguration(new HangLaptopConfiguration());
            modelBuilder.ApplyConfiguration(new HoaDonConfiguration());
            modelBuilder.ApplyConfiguration(new KhachHangConfiguration());
            modelBuilder.ApplyConfiguration(new LaptopConfiguration());
            modelBuilder.ApplyConfiguration(new ManHinhConfiguration());
            modelBuilder.ApplyConfiguration(new MauSacConfiguration());
            modelBuilder.ApplyConfiguration(new NhaCungCapConfiguration());
            modelBuilder.ApplyConfiguration(new NhanVienConfiguration());
            modelBuilder.ApplyConfiguration(new OCungConfiguration());
            modelBuilder.ApplyConfiguration(new VgaConfiguration());
            modelBuilder.ApplyConfiguration(new RamConfiguration());
            modelBuilder.ApplyConfiguration(new KhuyenMaiConfiguration());
            modelBuilder.ApplyConfiguration(new SerialLaptopConfiguration());
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(
                    @"Data Source=DESKTOP-VGNG2FP\SQLEXPRESS;Initial Catalog=Du_An_1_Group_Done;Integrated Security=True");
            }
        }

        public DbSet<ChiTietHoaDon> ChiTietHoaDons { get; set; }
        public DbSet<Cpu> Cpus { get; set; }
        public DbSet<DongLaptop> DongLaptops { get; set; }
        public DbSet<HangLaptop> HangLaptops { get; set; }
        public DbSet<HoaDon> HoaDons { get; set; }
        public DbSet<KhachHang> KhachHangs { get; set; }
        public DbSet<KhuyenMai> KhuyenMais { get; set; }
        public DbSet<Laptop> Laptops { get; set; }
        public DbSet<ManHinh> ManHinhs { get; set; }
        public DbSet<MauSac> MauSacs { get; set; }
        public DbSet<NhaCungCap> NhaCungCaps { get; set; }
        public DbSet<NhanVien> NhanViens { get; set; }
        public DbSet<OCung> OCungs { get; set; }
        public DbSet<Ram> Rams { get; set; }
        public DbSet<Vga> Vgas { get; set; }
        public DbSet<SerialLaptop> SerialLaptop { get; set; }

    }
}
