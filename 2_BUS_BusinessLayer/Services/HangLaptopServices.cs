using _1_DAL_DataAccessLayer.IRepositories;
using _1_DAL_DataAccessLayer.Models;
using _1_DAL_DataAccessLayer.Repositories;
using _2_BUS_BusinessLayer.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_BUS_BusinessLayer.Services
{
    public class HangLaptopServices : IHangLaptopServices
    {
        IHangLapTopRepositories _hangLapTopRepositories;
        public HangLaptopServices()
        {
            _hangLapTopRepositories = new HangLaptopRepositories();
        }
        public string AddHangLaptop(HangLaptop hangLaptop)
        {
            if (_hangLapTopRepositories.AddHangLaptop(hangLaptop))
            {
                return "Thêm thành công";
            }
            return "Thêm thất bại";
        }

        public string DeleteHangLaptop(Guid idHangLaptop)
        {
            if (_hangLapTopRepositories.DeleteHangLaptop(idHangLaptop))
            {
                return "Xoá thành công";
            }
            return "Xoá thất bại";
        }

        public List<HangLaptop> GetAllHangLaptops()
        {
            List<HangLaptop> lstHangLaptop = new List<HangLaptop>();
            lstHangLaptop = (from x in _hangLapTopRepositories.GetAllHangLaptops()
                             select x).ToList();
            return lstHangLaptop;
        }

        public string UpdateHangLaptop(HangLaptop hangLaptop)
        {
            if (_hangLapTopRepositories.UpdateHangLaptop(hangLaptop))
            {
                return "Sửa thành công";
            }
            return "Sửa thất bại";
        }
    }
}
