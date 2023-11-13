using _1_DAL_DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DAL_DataAccessLayer.IRepositories
{
    public interface IMauSacRepository
    {
        bool AddMauSac(MauSac mauSac);
        bool UpdateMauSac(MauSac mauSac);
        bool DeleteMauSac(Guid idMauSac);
        MauSac GetMauSacById(Guid idMauSac);
        List<MauSac> GetAllMauSac();
    }
}
