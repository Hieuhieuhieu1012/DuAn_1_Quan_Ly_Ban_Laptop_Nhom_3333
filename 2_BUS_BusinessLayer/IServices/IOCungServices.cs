using _1_DAL_DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_BUS_BusinessLayer.IServices
{
    public interface IOCungServices
    {
        string AddOCung(OCung oCung);
        string UpdateOCung(OCung oCung);
        string DeleteOCung(Guid idOCung);
        //OCung GetOCungById(Guid idOCung);
        List<OCung> GetAllOCungs();
    }
}
