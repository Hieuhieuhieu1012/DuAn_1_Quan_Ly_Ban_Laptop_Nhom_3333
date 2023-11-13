using _1_DAL_DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_BUS_BusinessLayer.IServices
{
    public interface IRamServices
    {
        string AddRam(Ram ram);
        string UpdateRam(Ram ram);
        string DeleteRam(Guid idRam);
        //Ram GetRamById(Guid idRam);
        List<Ram> GetAllRam();
    }
}
