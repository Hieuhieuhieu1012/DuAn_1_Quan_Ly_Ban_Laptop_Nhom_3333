using _1_DAL_DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DAL_DataAccessLayer.IRepositories
{
    public interface IHangLapTopRepositories
    {
        bool AddHangLaptop(HangLaptop hangLaptop);
        bool UpdateHangLaptop(HangLaptop hangLaptop);
        bool DeleteHangLaptop(Guid idHangLaptop);
        HangLaptop GetHangLaptopById(Guid idHangLaptop);
        List<HangLaptop> GetAllHangLaptops();
    }
}
