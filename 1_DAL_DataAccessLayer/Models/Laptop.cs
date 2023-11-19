using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using _1_DAL_DataAccessLayer.Repositories;

namespace _1_DAL_DataAccessLayer.Models
{
    public class Laptop
    {
        public Guid Id { get; set; }
        public Guid IdHangLaptop { get; set; }
        public Guid IdDongLaptop { get; set; }
        public Guid IdNhaCungCap { get; set; }
        public Guid IdCpu { get; set; }
        public Guid? IdVga { get; set; }
        public Guid IdRam { get; set; }
        public Guid IdManHinh { get; set; }
        public Guid IdMauSac { get; set; }
        public Guid IdOCung { get; set; }
        public Guid? IdKhuyenMai { get; set; }
        public string? Ten { get; set; }
        public decimal GiaNhap { get; set; }
        public decimal GiaBan { get; set; }
        public string? Mota { get; set; }
        public decimal TrongLuong { get; set; }
        public int NamBh { get; set; }
        public bool? TrangThai { get; set; }
        public byte[]? HinhAnh { get; set; }

        public HangLaptop? HangLaptop { get; set; }
        public DongLaptop? DongLaptop { get; set; }
        public NhaCungCap? NhaCungCap { get; set; }
        public Cpu? Cpu { get; set; }
        public Vga? Vga { get; set; }
        public KhuyenMai? KhuyenMai{ get; set; }
        public Ram? Ram { get; set; }
        public ManHinh? ManHinh { get; set; }
        public MauSac? MauSac { get; set; }
        public OCung? OCung { get; set; }

        public ICollection<ChiTietHoaDon> ChiTietHoaDons { get; set; }
        public ICollection<SerialLaptop> SerialLaptops { get; set; }
    }
}
