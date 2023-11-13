using _1_DAL_DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_BUS_BusinessLayer.IServices
{
    public interface IDongLaptopServices
    {
        string AddDongLapTop(DongLaptop dongLaptop);
        string UpdateDongLapTop(DongLaptop dongLaptop);

        //DongLaptop GetDongLapTopById(Guid idDongLaptop);
        List<DongLaptop> GetAllDongLaptop();
    }
}
