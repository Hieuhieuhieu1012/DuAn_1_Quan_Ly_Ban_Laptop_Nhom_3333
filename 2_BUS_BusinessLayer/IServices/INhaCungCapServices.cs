using _1_DAL_DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_BUS_BusinessLayer.IServices
{
    public interface INhaCungCapServices
    {
        string AddNhaCungCap(NhaCungCap nhaCungCap);
        string UpdateNhaCungCap(NhaCungCap nhaCungCap);
        string DeleteNhaCungCap(Guid idNhaCungCap);
        //NhaCungCap GetNhaCungCapById(Guid idNhaCungCap);
        List<NhaCungCap> GetAllNhaCungCap();
    }
}
