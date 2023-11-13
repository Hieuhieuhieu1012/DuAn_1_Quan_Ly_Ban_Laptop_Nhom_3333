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
    public class CpuServices : ICpuServices
    {
        ICpuRepositories _cpuRepositories;
        public CpuServices()
        {
            _cpuRepositories = new CpuRepositories();
        }
        public string AddCpu(Cpu cpu)
        {
            if (_cpuRepositories.AddCpu(cpu))
            {
                return "Thêm thành công";   
            }
            return "Thêm thất bại";
        }

        public string DeleteCpu(Guid idCpu)
        {
            if (_cpuRepositories.DeleteCpu(idCpu))
            {
                return "Xoá thành công";
            }
            return "Xoá thất bại";
        }

        public List<Cpu> GetAllCpu()
        {
            List<Cpu> lstCpu = new List<Cpu>();
            lstCpu = 
                (from x in _cpuRepositories.GetAllCpu()
                 select x).ToList();
            return lstCpu;
        }

        public string UpdateCpu(Cpu cpu)
        {
            if (_cpuRepositories.UpdateCpu(cpu))
            {
                return "Sửa thành công";
            }
            return "Sửa thất bại";
        }
    }
}
