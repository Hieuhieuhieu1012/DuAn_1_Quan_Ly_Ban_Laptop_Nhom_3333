using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DAL_DataAccessLayer.Models
{
    public class NhanVien
    {
        public Guid Id { get; set; }
        public Guid? IdGuiBaoCao { get; set; }
        public string Ma{get; set; }
        public string Hoten { get; set; }
        public string Email { get; set; }
        public string? DiaChi { get; set; }
        public bool? GioiTinh { get; set; }
        public bool? TrangThai { get; set; }
        public string SoDienThoai { get; set; }
        public string MatKhau { get; set; }
        public string ChucVu { get; set; }
        public byte[]? HinhAnh { get; set; }
        public string CCCD { get; set; }

        public ICollection<HoaDon> HoaDons { get; set; }
        public ICollection<NhanVien>NhanViens { get; set; }

    }
}
