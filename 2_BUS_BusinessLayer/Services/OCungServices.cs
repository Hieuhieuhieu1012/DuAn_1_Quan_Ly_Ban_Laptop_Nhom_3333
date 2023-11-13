using _1_DAL_DataAccessLayer.IRepositories;
using _1_DAL_DataAccessLayer.Models;
using _1_DAL_DataAccessLayer.Repositories;
using _2_BUS_BusinessLayer.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_BUS_BusinessLayer.Services
{
    public class OCungServices : IOCungServices
    {
        IOCungReposittories _oCungReposittories;
        public OCungServices()
        {
            _oCungReposittories = new OCungRepositories();
        }
        public string AddOCung(OCung oCung)
        {
            if (_oCungReposittories.AddOCung(oCung))
            {
                return "Thêm thành công";
            }
            return "Thêm thất bại";
        }

        public string DeleteOCung(Guid idOCung)
        {
            if (_oCungReposittories.DeleteOCung(idOCung))
            {
                return "Xoá thành công";
            }
            return "Xoá thất bại";
        }

        public List<OCung> GetAllOCungs()
        {
            List<OCung> lstOCung = new List<OCung>();
            lstOCung = (from x in _oCungReposittories.GetAllOCungs()
                        select x).ToList();
            return lstOCung;
        }

        public string UpdateOCung(OCung oCung)
        {
            if (_oCungReposittories.UpdateOCung(oCung))
            {
                return "Sửa thành công";
            }
            return "Sửa thất bại";
        }
    }
}
