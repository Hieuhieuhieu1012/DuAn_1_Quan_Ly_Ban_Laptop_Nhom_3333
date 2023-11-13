using _1_DAL_DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DAL_DataAccessLayer.IRepositories
{
    public interface IKhuyenMaiRepository
    {
        bool AddKhuyenMai(KhuyenMai khuyenMai);
        bool UpdateKhuyenMai(KhuyenMai khuyenMai);
        bool ChuyenTrangThai(KhuyenMai khuyenMai);
        KhuyenMai GetKhuyenMaiById(Guid idKhuyenMai);
        List<KhuyenMai> GetAllKhuyenMai();
    }
}
