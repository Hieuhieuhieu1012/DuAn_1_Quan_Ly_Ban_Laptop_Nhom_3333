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
    public class MauSacRepositories : IMauSacRepository
    {
        QlBanLaptopContext _lapTopContext;
        public MauSacRepositories()
        {
            _lapTopContext = new QlBanLaptopContext();
        }
        public bool AddMauSac(MauSac mauSac)
        {
            try
            {
                if (mauSac != null)
                {
                    mauSac.Id = Guid.NewGuid();
                    _lapTopContext.Add(mauSac);
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

        public bool DeleteMauSac(Guid idMauSac)
        {
            var ketqua = _lapTopContext.MauSacs.Find(idMauSac);
            if (ketqua != null)
            {
                _lapTopContext.Remove(ketqua);
                _lapTopContext.SaveChanges();
                return true;
            }
            return false;
        }

        public List<MauSac> GetAllMauSac()
        {
            return _lapTopContext.MauSacs.ToList();
        }

        public MauSac GetMauSacById(Guid idMauSac)
        {
            var ketqua = _lapTopContext.MauSacs.Find(idMauSac);
            return ketqua;
        }

        public bool UpdateMauSac(MauSac mauSac)
        {
            var ketqua = _lapTopContext.MauSacs.FirstOrDefault(c=>c.Id == mauSac.Id);
            if (ketqua != null)
            {
                ketqua.Ma = mauSac.Ma;
                ketqua.Ten = mauSac.Ten;
                _lapTopContext.Update(ketqua);
                _lapTopContext.SaveChanges();
                return true;
            }
            return false;
        }
    }
}
