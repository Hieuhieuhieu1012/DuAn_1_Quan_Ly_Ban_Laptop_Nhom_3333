using _1_DAL_DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_BUS_BusinessLayer.IServices
{
    public interface IKhuyenMaiServices
    {
        string AddKhuyenMai(KhuyenMai khuyenMai);
        string UpdateKhuyenMai(KhuyenMai khuyenMai);
        string ChuyenTrangThai(KhuyenMai khuyenMai);
        KhuyenMai GetKhuyenMaiById(Guid idKhuyenMai);
        List<KhuyenMai> GetAllKhuyenMai();
    }
}
