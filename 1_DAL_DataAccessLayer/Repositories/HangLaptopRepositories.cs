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
    public class HangLaptopRepositories : IHangLapTopRepositories
    {
        QlBanLaptopContext _lapTopContext;
        public HangLaptopRepositories()
        {
            _lapTopContext = new QlBanLaptopContext();
        }
        public bool AddHangLaptop(HangLaptop hangLaptop)
        {
            try
            {
                if (hangLaptop != null)
                {
                    hangLaptop.Id = Guid.NewGuid();
                    _lapTopContext.Add(hangLaptop);
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

        public bool DeleteHangLaptop(Guid idHangLaptop)
        {
            var ketqua = _lapTopContext.HangLaptops.Find(idHangLaptop);
            if (ketqua != null)
            {
                _lapTopContext.Remove(ketqua);
                _lapTopContext.SaveChanges();
                return true;
            }
            return false;
        }

        public List<HangLaptop> GetAllHangLaptops()
        {
            return _lapTopContext.HangLaptops.ToList();
        }

        public HangLaptop GetHangLaptopById(Guid idHangLaptop)
        {
            var ketqua = _lapTopContext.HangLaptops.Find(idHangLaptop);
            return ketqua;
        }

        public bool UpdateHangLaptop(HangLaptop hangLaptop)
        {
            var ketqua = _lapTopContext.HangLaptops.FirstOrDefault(c=>c.Id == hangLaptop.Id);
            if (ketqua != null)
            {
                ketqua.Ma = hangLaptop.Ma;
                ketqua.Ten = hangLaptop.Ten;
                _lapTopContext.Update(ketqua);
                _lapTopContext.SaveChanges();
                return true;
            }
            return false;
        }
    }
}
