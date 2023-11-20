using _1_DAL_DataAccessLayer.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DAL_DataAccessLayer.IRepositories
{
    public interface IVgaRepositories
    {
        bool AddVga(Vga vga);
        bool UpdateVga(Vga vga);
        bool DeleteVga(Guid idVga);
        Vga GetVgaById(Guid idVga);
        List<Vga> GetAllVga();
    }
}
