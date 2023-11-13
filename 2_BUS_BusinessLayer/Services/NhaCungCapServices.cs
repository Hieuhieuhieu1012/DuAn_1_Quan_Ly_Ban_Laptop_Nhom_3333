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
    public class NhaCungCapServices : INhaCungCapServices
    {
        INhaCungCapRepository _nhaCungCapRepository;
        public NhaCungCapServices()
        {
            _nhaCungCapRepository = new NhaCungCapRepository();
        }
        public string AddNhaCungCap(NhaCungCap nhaCungCap)
        {
            if (_nhaCungCapRepository.AddNhaCungCap(nhaCungCap))
            {
                return "Thêm thành công";
            }
            return "Thêm thất bại";
        }

        public string DeleteNhaCungCap(Guid idNhaCungCap)
        {
            if (_nhaCungCapRepository.DeleteNhaCungCap(idNhaCungCap))
            {
                return "Xoá thành công";
            }
            return "Xoá thất bại";
        }

        public List<NhaCungCap> GetAllNhaCungCap()
        {
            List<NhaCungCap> lstNhaCungCap = new List<NhaCungCap>();
            lstNhaCungCap = (from x in _nhaCungCapRepository.GetAllNhaCungCap()
                             select x).ToList();
            return lstNhaCungCap;
        }

        public string UpdateNhaCungCap(NhaCungCap nhaCungCap)
        {
            if (_nhaCungCapRepository.UpdateNhaCungCap(nhaCungCap))
            {
                return "Sửa thành công";
            }
            return "Sửa thất bại";
        }
    }
}
