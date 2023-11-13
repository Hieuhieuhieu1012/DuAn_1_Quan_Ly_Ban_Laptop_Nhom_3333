using _1_DAL_DataAccessLayer.Models;
using _2_BUS_BusinessLayer.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_BUS_BusinessLayer.ViewModel
{
    public class LaptopView
    {
        public Guid Id { get; set; }
        public Guid IdHangLaptop { get; set; }
        public string HangLaptop { get; set; }
        public Guid IdDongLaptop { get; set; }
        public string DongLaptop { get; set; }
        public Guid IdNhaCungCap { get; set; }
        public string NhaCungCap { get; set; }
        //public Guid IdKhuyenMai { get; set; }
        //public string KhuyenMai { get; set; }
        public Guid IdCpu { get; set; }
        public string Cpu { get; set; }
        public Guid? IdVga { get; set; }
        public string? Vga { get; set; }
        public Guid IdRam { get; set; }
        public string Ram { get; set; }
        public Guid IdManHinh { get; set; }
        public string ManHinh { get; set; }
        public Guid IdMauSac { get; set; }
        public string MauSac { get; set; }
        public Guid IdOCung { get; set; }
        public string OCung { get; set; }
        public Guid? IdKhuyenMai { get; set; }
        public string Ten { get; set; }
        public string Mota { get; set; }
        public decimal TrongLuong { get; set; }
        public decimal GiaNhap { get; set; }
        public decimal GiaBan { get; set; }
        public int NamBh { get; set; }
        public int SoLuongTon { get; set; }
        public bool? TrangThai { get; set; }
        public byte[]? Anh { get; set; }
        public string Serial { get; set; }
        public List<string> ListSerial { get; set; }

    }
}
