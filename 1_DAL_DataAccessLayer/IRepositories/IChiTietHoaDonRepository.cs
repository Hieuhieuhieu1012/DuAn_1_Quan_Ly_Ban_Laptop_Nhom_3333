using _1_DAL_DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DAL_DataAccessLayer.IRepositories
{
    public interface IChiTietHoaDonRepository
    {
        bool AddChiTietHoaDon(ChiTietHoaDon chiTietHoaDon);
        bool UpdateChiTietHoaDon(ChiTietHoaDon chiTietHoaDon);
        //bool DeleteChiTietHoaDon(Guid idChiTietHoaDon);
        ChiTietHoaDon GetChiTietHoaDonById(Guid idChiTietHoaDon);
        List<ChiTietHoaDon> GetAllChiTietHoaDon();
    }
}
