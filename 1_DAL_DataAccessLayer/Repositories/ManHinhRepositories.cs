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
    public class ManHinhRepositories : IManHinhRepositories
    {
        QlBanLaptopContext _lapTopContext;
        public ManHinhRepositories()
        {
            _lapTopContext = new QlBanLaptopContext();
        }
        public bool AddManHinh(ManHinh manHinh)
        {
            try
            {
                if (manHinh != null)
                {
                    manHinh.Id = Guid.NewGuid();
                    _lapTopContext.Add(manHinh);
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

        public bool DeleteManHinh(Guid idManHinh)
        {
            var ketqua = _lapTopContext.ManHinhs.Find(idManHinh);
            if (ketqua != null)
            {
                _lapTopContext.Remove(ketqua);
                _lapTopContext.SaveChanges();
                return true;
            }
            return false;
        }

        public List<ManHinh> GetAllManHinh()
        {
            return _lapTopContext.ManHinhs.ToList();
        }

        public ManHinh GetManHinhById(Guid idManHinh)
        {
            var ketqua = _lapTopContext.ManHinhs.Find(idManHinh);
            return ketqua;
        }

        public bool UpdateManHinh(ManHinh manHinh)
        {
            var ketqua = _lapTopContext.ManHinhs.FirstOrDefault(c=>c.Id == manHinh.Id);
            if (ketqua != null)
            {
                ketqua.Ten = manHinh.Ten;
                ketqua.Ma = manHinh.Ma;
                _lapTopContext.Update(ketqua);
                _lapTopContext.SaveChanges();
                return true;
            }
            return false;
        }
    }
}
