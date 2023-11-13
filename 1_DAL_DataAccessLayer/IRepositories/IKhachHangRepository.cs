using _1_DAL_DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DAL_DataAccessLayer.IRepositories
{
    public interface IKhachHangRepository
    {
        bool AddKhachHang(KhachHang khachHang);
        bool UpdateKhachHang(KhachHang khachHang);
        KhachHang GetKhachHangById(Guid idKhachHang);
        List<KhachHang> GetAllKhachHang();
    }
}
