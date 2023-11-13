using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace _1_DAL_DataAccessLayer.Models
{
    public class HoaDon
    {
        public Guid Id { get; set; }
        public Guid IdNhanVien { get; set; }
        public Guid IdKhachHang { get; set; }
        public string Ma { get; set; }
        public string HinhThucTT { get; set; }
        public DateTime NgayTao { get; set; }
        public DateTime NgayThanhToan { get; set; }
       
        public int TrangThai { get; set; }
        public string? DiaChiNhanHang { get; set; }
        public string? GhiChu { get; set; }
        public decimal TongTien { get; set; }

        public ICollection<ChiTietHoaDon> ChiTietHoaDons { get; set; }
        public KhachHang? KhachHang { get; set; }
        public NhanVien? NhanVien { get; set; }

    }
}
