using _1_DAL_DataAccessLayer.IRepositories;
using _1_DAL_DataAccessLayer.Repositories;
using _2_BUS_BusinessLayer.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_BUS_BusinessLayer.Services
{
    public class VgaServices : IVgaServices
    {
        IVgaRepositories _vgaRepository;
        public VgaServices()
        {
            _vgaRepository = new VGARepositories();
        }
        public string AddVga(Vga vga)
        {
            if (_vgaRepository.AddVga(vga))
            {
                return "Thêm thành công";
            }
            return "Thêm thất bại";
        }

        public string DeleteVga(Guid idVga)
        {
            if (_vgaRepository.DeleteVga(idVga))
            {
                return "Xoá thành công";
            }
            return "Xoá thất bại";
        }

        public List<Vga> GetAllVga()
        {
            List<Vga> lstVga = new List<Vga>();
            lstVga =
                (from x in _vgaRepository.GetAllVga()
                 select x).ToList();
            return lstVga;
        }

        public string UpdateVga(Vga vga)
        {
            if (_vgaRepository.UpdateVga(vga))
            {
                return "Sửa thành công";
            }
            return "Sửa thất bại";
        }
    }
}
