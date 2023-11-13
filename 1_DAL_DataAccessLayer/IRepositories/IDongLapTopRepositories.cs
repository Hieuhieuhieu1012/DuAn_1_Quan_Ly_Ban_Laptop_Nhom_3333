using _1_DAL_DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DAL_DataAccessLayer.IRepositories
{
    public interface IDongLapTopRepositories
    {
        bool AddDongLapTop(DongLaptop dongLaptop);
        bool UpdateDongLapTop(DongLaptop dongLaptop);
        DongLaptop GetDongLapTopById(Guid idDongLaptop);
        List<DongLaptop> GetAllDongLaptop();
    }
}
