using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_BUS_BusinessLayer.ViewModel
{
    public class ChiTietHoaDonView
    {
        public Guid Id { get; set; }
        public Guid IdHoaDon { get; set; }
        public Guid IdSanPham { get; set; }
        public string TenSanPham{ get; set; }
        public string Hang { get; set; }
        public string Dong { get; set; }
        public string SerialSanPham{ get; set; }
        public int SoLuong { get; set; }
        public decimal DonGia { get; set; }
        public decimal GiamGia { get; set; }
        public decimal ThanhTien => SoLuong * DonGia - GiamGia;
    }
}
