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
    public class NhaCungCapRepository : INhaCungCapRepository
    {
        QlBanLaptopContext _lapTopContext;
        public NhaCungCapRepository()
        {
            _lapTopContext = new QlBanLaptopContext();
        }
        public bool AddNhaCungCap(NhaCungCap nhaCungCap)
        {
            try
            {
                if (nhaCungCap != null)
                {
                    nhaCungCap.Id = Guid.NewGuid();
                    _lapTopContext.Add(nhaCungCap);
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

        public bool DeleteNhaCungCap(Guid idNhaCungCap)
        {
            var ketqua = _lapTopContext.NhaCungCaps.Find(idNhaCungCap);
            if (ketqua != null)
            {
                _lapTopContext.Remove(ketqua);
                _lapTopContext.SaveChanges();
                return true;
            }
            return false;
        }

        public List<NhaCungCap> GetAllNhaCungCap()
        {
            return _lapTopContext.NhaCungCaps.ToList();
        }

        public NhaCungCap GetNhaCungCapById(Guid idNhaCungCap)
        {
            var ketqua = _lapTopContext.NhaCungCaps.Find(idNhaCungCap);
            return ketqua;
        }

        public bool UpdateNhaCungCap(NhaCungCap nhaCungCap)
        {
            var ketqua = _lapTopContext.NhaCungCaps.FirstOrDefault(c => c.Id == nhaCungCap.Id);
            if (ketqua != null)
            {
                ketqua.Ma = nhaCungCap.Ma;
                ketqua.Ten = nhaCungCap.Ten;
                _lapTopContext.Update(ketqua);
                _lapTopContext.SaveChanges();
                return true;
            }
            return false;
        }
    }
}
