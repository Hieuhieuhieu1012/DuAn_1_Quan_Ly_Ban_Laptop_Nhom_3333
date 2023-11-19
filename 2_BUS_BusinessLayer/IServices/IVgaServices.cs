using _1_DAL_DataAccessLayer.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_BUS_BusinessLayer.IServices
{
    public interface IVgaServices
    {
        string AddVga(Vga vga);
        string UpdateVga(Vga vga);
        string DeleteVga(Guid idVga);
        //Vga GetVgaById(Guid idVga);
        List<Vga> GetAllVga();
    }
}
