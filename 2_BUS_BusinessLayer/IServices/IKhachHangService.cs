using _1_DAL_DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _2_BUS_BusinessLayer.ViewModel;

namespace _2_BUS_BusinessLayer.IServices
{
    public interface  IKhachHangService
    {
        public string  AddKhachHang(KhachHang khachHang);
        public string UpdateKhachHang(KhachHang khachHang);
        KhachHang GetKhachHangById(Guid idKhachHang);
        List<KhachHang> GetAllKhachHangs();
    }
}
