using _1_DAL_DataAccessLayer.Context;
using _1_DAL_DataAccessLayer.IRepositories;
using _1_DAL_DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DAL_DataAccessLayer.Repositories
{
    public class CpuRepositories : ICpuRepositories
    {
        QlBanLaptopContext _lapTopContext;
        public CpuRepositories()
        {
            _lapTopContext = new QlBanLaptopContext();
        }
        public bool AddCpu(Cpu cpu)
        {
            try
            {
                if (cpu != null)
                {
                    cpu.Id = Guid.NewGuid();
                    _lapTopContext.Add(cpu);
                    _lapTopContext.SaveChanges();
                    return true;
                }
                return false;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }

        public bool DeleteCpu(Guid idCpu)
        {
            var ketqua = _lapTopContext.Cpus.Find(idCpu);
            if (ketqua != null)
            {
                _lapTopContext.Remove(ketqua);
                _lapTopContext.SaveChanges();
                return true;
            }
            return false;
        }

        public List<Cpu> GetAllCpu()
        {
            return _lapTopContext.Cpus.ToList();
        }

        public Cpu GetCpuById(Guid idCpu)
        {
            var ketqua = _lapTopContext.Cpus.Find(idCpu);
            return ketqua;
        }

        public bool UpdateCpu(Cpu cpu)
        {
            var ketqua = _lapTopContext.Cpus.FirstOrDefault(c => c.Id == cpu.Id);
            if (ketqua != null)
            {
                ketqua.Ma = cpu.Ma;
                ketqua.Ten = cpu.Ten;
                _lapTopContext.Update(ketqua);
                _lapTopContext.SaveChanges();
                return true;
            }
            return false;
        }
    }
}
