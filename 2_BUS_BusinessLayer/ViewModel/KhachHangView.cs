using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_BUS_BusinessLayer.ViewModel
{
    public class KhachHangView
    {
        public Guid Id { get; set; }
        public string Ma { get; set; }
        public string Hoten { get; set; }
        public string Email { get; set; }
        public string SoDienThoai { get; set; }
        public string DiaChi { get; set; }
        public bool GioiTinh { get; set; }
    }
}
