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
    public class DongLaptopServices : IDongLaptopServices
    {
        IDongLapTopRepositories _dongLapTopRepositories;
        public DongLaptopServices()
        {
            _dongLapTopRepositories = new DongLapTopReposittoies();
        }
        public string AddDongLapTop(DongLaptop dongLaptop)
        {
            if (_dongLapTopRepositories.AddDongLapTop(dongLaptop))
            {
                return "Thêm thành công";
            }
            return "Thêm thất bại";
        }


        public List<DongLaptop> GetAllDongLaptop()
        {
            List<DongLaptop> lstDongLapTop = new List<DongLaptop>();
            lstDongLapTop = (from x in _dongLapTopRepositories.GetAllDongLaptop()
                             select x).ToList();
            return lstDongLapTop;
        }

        public string UpdateDongLapTop(DongLaptop dongLaptop)
        {
            if (_dongLapTopRepositories.UpdateDongLapTop(dongLaptop))
            {
                return "Sửa thành công";
            }
            return "Sửa thất bại";
        }
    }
}
