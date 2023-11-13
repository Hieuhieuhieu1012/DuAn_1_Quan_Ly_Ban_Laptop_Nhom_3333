using _1_DAL_DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_BUS_BusinessLayer.IServices
{
    public interface ICpuServices
    {
        string AddCpu(Cpu cpu);
        string UpdateCpu(Cpu cpu);
        string DeleteCpu(Guid idCpu);
        //Cpu GetCpuById(Guid idCpu);
        List<Cpu> GetAllCpu();
    }
}
