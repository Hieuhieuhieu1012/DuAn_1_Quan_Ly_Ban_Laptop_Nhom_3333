using _1_DAL_DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DAL_DataAccessLayer.IRepositories
{
    public interface IOCungReposittories
    {
        bool AddOCung(OCung oCung);
        bool UpdateOCung(OCung oCung);
        bool DeleteOCung(Guid idOCung);
        OCung GetOCungById(Guid idOCung);
        List<OCung> GetAllOCungs();
    }
}
