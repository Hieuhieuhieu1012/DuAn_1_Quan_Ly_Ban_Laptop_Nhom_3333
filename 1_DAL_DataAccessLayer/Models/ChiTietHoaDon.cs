using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Migrations.Operations;

namespace _1_DAL_DataAccessLayer.Models
{
    public class ChiTietHoaDon
    {
        public Guid Id { get; set; }
        public Guid? IdLaptop { get; set; }
        public Guid? IdLinhKien { get; set; }
        public Guid IdHoaDon { get; set; }
        public string Serial{ get; set; }
        public int SoLuong { get; set; }
        public decimal DonGia { get; set; }
        public decimal GiamGia { get; set; }
        public decimal ThanhTien { get; set; }
        public Laptop? Laptop { get; set; }
        public HoaDon? HoaDon { get; set; }



    }
}
