using _1_DAL_DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DAL_DataAccessLayer.IRepositories
{
    public interface ILapTopRepository
    {
        bool AddLapTop(Laptop lapTop);
        bool UpdateLapTop(Laptop lapTop);
        bool UpdateKhuyenMaiLaptop(Guid idLaptop, Guid? idKhuyenMai);
        Laptop GetLapTopById(Guid idLapTop);
        bool UpdateStatusLaptop(List<Laptop> lstLaptops);
        List<Laptop> GetAllLaptopNoSerial();
        List<Laptop> GetAllLapTop();
    }
}
