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
    public class MauSacServices : IMauSacServices
    {
        IMauSacRepository _mauSacRepository;
        public MauSacServices()
        {
            _mauSacRepository = new MauSacRepositories();
        }
        public string AddMauSac(MauSac mauSac)
        {
            if (_mauSacRepository.AddMauSac(mauSac))
            {
                return "Thêm thành công";
            }
            return "Thêm thất bại";
        }

        public string DeleteMauSac(Guid idMauSac)
        {
            if (_mauSacRepository.DeleteMauSac(idMauSac))
            {
                return "Xoá thành công";
            }
            return "Xoá thất bại";
        }

        public List<MauSac> GetAllMauSac()
        {
            List<MauSac> lstMauSac = new List<MauSac>();
            lstMauSac = (from x in _mauSacRepository.GetAllMauSac()
                         select x).ToList();
            return lstMauSac;
        }

        public string UpdateMauSac(MauSac mauSac)
        {
            if (_mauSacRepository.UpdateMauSac(mauSac))
            {
                return "Sửa thành công";
            }
            return "Sửa thất bại";
        }
    }
}
