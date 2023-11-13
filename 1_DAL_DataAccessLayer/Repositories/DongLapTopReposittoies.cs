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
    public class DongLapTopReposittoies : IDongLapTopRepositories
    {
        QlBanLaptopContext _lapTopContext;
        public DongLapTopReposittoies()
        {
            _lapTopContext = new QlBanLaptopContext();
        }
        public bool AddDongLapTop(DongLaptop dongLaptop)
        {
            try
            {
                if (dongLaptop != null)
                {
                    dongLaptop.Id = Guid.NewGuid();
                    _lapTopContext.Add(dongLaptop);
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

        public List<DongLaptop> GetAllDongLaptop()
        {
            return _lapTopContext.DongLaptops.ToList();
        }

        public DongLaptop GetDongLapTopById(Guid idDongLaptop)
        {
            var ketqua = _lapTopContext.DongLaptops.Find(idDongLaptop);
            return ketqua;
        }

        public bool UpdateDongLapTop(DongLaptop dongLaptop)
        {
            var ketqua = _lapTopContext.DongLaptops.FirstOrDefault(c=>c.Id == dongLaptop.Id);
            if (ketqua != null)
            {
                ketqua.Ma = dongLaptop.Ma;
                ketqua.Ten = dongLaptop.Ten;
                _lapTopContext.Update(ketqua);
                _lapTopContext.SaveChanges();
                return true;
            }
            return false;
        }
    }
}
