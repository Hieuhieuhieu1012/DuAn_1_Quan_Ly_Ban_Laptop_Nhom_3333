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
    public class RamServices : IRamServices
    {
        IRamRepository _ramRepository;
        public RamServices()
        {
            _ramRepository = new Ramrepository();
        }
        public string AddRam(Ram ram)
        {
            if (_ramRepository.AddRam(ram))
            {
                return "Thêm thành công";
            }
            return "Thêm thất bại";
        }

        public string DeleteRam(Guid idRam)
        {
            if (_ramRepository.DeleteRam(idRam))
            {
                return "Xoá thành công";
            }
            return "Xoá thất bại";
        }

        public List<Ram> GetAllRam()
        {
            List<Ram> lstRam = new List<Ram>();
            lstRam = (from x in _ramRepository.GetAllRam()
                      select x).ToList();
            return lstRam;
        }

        public string UpdateRam(Ram ram)
        {
            if (_ramRepository.UpdateRam(ram))
            {
                return "Sửa thành công";
            }
            return "Sửa thất bại";
        }
    }
}
