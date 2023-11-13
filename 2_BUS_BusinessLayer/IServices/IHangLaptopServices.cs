using _1_DAL_DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_BUS_BusinessLayer.IServices
{
    public interface IHangLaptopServices
    {
        string AddHangLaptop(HangLaptop hangLaptop);
        string UpdateHangLaptop(HangLaptop hangLaptop);
        string DeleteHangLaptop(Guid idHangLaptop);
        //HangLaptop GetHangLaptopById(Guid idHangLaptop);
        List<HangLaptop> GetAllHangLaptops();
    }
}
