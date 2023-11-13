using _1_DAL_DataAccessLayer.Context;
using _1_DAL_DataAccessLayer.IRepositories;
using _1_DAL_DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DAL_DataAccessLayer.Repositories
{
    public class OCungRepositories : IOCungReposittories
    {
        QlBanLaptopContext _lapTopContext;
        public OCungRepositories()
        {
            _lapTopContext = new QlBanLaptopContext();
        }
        public bool AddOCung(OCung oCung)
        {
            try
            {
                if (oCung != null)
                {
                    oCung.Id = Guid.NewGuid();
                    _lapTopContext.Add(oCung);
                    _lapTopContext.SaveChanges();
                    return true;
                }
                return false;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }

        public bool DeleteOCung(Guid idOCung)
        {
            var ketqua = _lapTopContext.OCungs.Find(idOCung);
            if (ketqua != null)
            {
                _lapTopContext.Remove(ketqua);
                _lapTopContext.SaveChanges();
                return true;
            }
            return false;
        }

        public List<OCung> GetAllOCungs()
        {
            return _lapTopContext.OCungs.ToList();
        }

        public OCung GetOCungById(Guid idOCung)
        {
            var ketqua = _lapTopContext.OCungs.Find(idOCung);
            return ketqua;
        }

        public bool UpdateOCung(OCung oCung)
        {
            var ketqua = _lapTopContext.OCungs.FirstOrDefault(c=>c.Id == oCung.Id);
            if (ketqua != null)
            {
                ketqua.Ma = oCung.Ma;
                ketqua.Ten = oCung.Ten;
                ketqua.Loai = oCung.Loai;
                ketqua.DungLuong = oCung.DungLuong;
                _lapTopContext.Update(ketqua);
                _lapTopContext.SaveChanges();
                return true;
            }
            return false;
        }
    }
}
