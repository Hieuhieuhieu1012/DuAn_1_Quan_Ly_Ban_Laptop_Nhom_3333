using _1_DAL_DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_BUS_BusinessLayer.IServices
{
    public interface IMauSacServices
    {
        string AddMauSac(MauSac mauSac);
        string UpdateMauSac(MauSac mauSac);
        string DeleteMauSac(Guid idMauSac);
        //MauSac GetMauSacById(Guid idMauSac);
        List<MauSac> GetAllMauSac();
    }
}
