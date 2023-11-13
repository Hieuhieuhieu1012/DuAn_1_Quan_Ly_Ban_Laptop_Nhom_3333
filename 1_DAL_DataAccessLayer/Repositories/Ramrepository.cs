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
    public class Ramrepository : IRamRepository
    {
        QlBanLaptopContext _lapTopContext;
        public Ramrepository()
        {
            _lapTopContext = new QlBanLaptopContext();
        }
        public bool AddRam(Ram ram)
        {
            try
            {
                if (ram != null)
                {
                    ram.Id = Guid.NewGuid();
                    _lapTopContext.Add(ram);
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

        public bool DeleteRam(Guid idRam)
        {
            var ketqua = _lapTopContext.Rams.Find(idRam);
            if (ketqua != null)
            {
                _lapTopContext.Remove(ketqua);
                _lapTopContext.SaveChanges();
                return true;
            }
            return false;
        }

        public List<Ram> GetAllRam()
        {
            return _lapTopContext.Rams.ToList();
        }

        public Ram GetRamById(Guid idRam)
        {
            var ketqua = _lapTopContext.Rams.Find(idRam);
            return ketqua;
        }

        public bool UpdateRam(Ram ram)
        {
            var ketqua = _lapTopContext.Rams.FirstOrDefault(c => c.Id == ram.Id);
            if (ketqua != null)
            {
                ketqua.Ma = ram.Ma;
                ketqua.Ten = ram.Ten;
                ketqua.DungLuong = ram.DungLuong;
                _lapTopContext.Update(ketqua);
                _lapTopContext.SaveChanges();
                return true;
            }
            return false;
        }
    }
}
