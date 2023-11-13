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
    public class ManHinhServices : IManHinhServices
    {
        IManHinhRepositories _manHinhRepositories;
        public ManHinhServices()
        {
            _manHinhRepositories = new ManHinhRepositories();
        }
        public string AddManHinh(ManHinh manHinh)
        {
            if (_manHinhRepositories.AddManHinh(manHinh))
            {
                return "Thêm thành công";
            }
            return "Thêm thất bại";
        }

        public string DeleteManHinh(Guid idManHinh)
        {
            if (_manHinhRepositories.DeleteManHinh(idManHinh))
            {
                return "Xoá thành công";
            }
            return "Xoá thất bại";
        }

        public List<ManHinh> GetAllManHinh()
        {
            List<ManHinh> lstManHinh = new List<ManHinh>();
            lstManHinh = (from x in _manHinhRepositories.GetAllManHinh()
                          select x).ToList();
            return lstManHinh;
        }

        public string UpdateManHinh(ManHinh manHinh)
        {
            if (_manHinhRepositories.UpdateManHinh(manHinh))
            {
                return "Sửa thành công";
            }
            return "Sửa thất bại";
        }
    }
}
