using _1_DAL_DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DAL_DataAccessLayer.IRepositories
{
    public interface IHoaDonRepository
    {
        bool AddHoaDon(HoaDon hoaDon);
        bool UpdateHoaDon(HoaDon hoaDon);
        HoaDon GetHoaDonById(Guid idHoaDon);
        List<HoaDon> GetAllHoaDon();
    }
}
