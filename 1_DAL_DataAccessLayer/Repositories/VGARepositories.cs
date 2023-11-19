using _1_DAL_DataAccessLayer.Context;
using _1_DAL_DataAccessLayer.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DAL_DataAccessLayer.Repositories
{
    public class VGARepositories : IVgaRepositories
    {
        QlBanLaptopContext _lapTopContext;
        public VGARepositories()
        {
            _lapTopContext = new QlBanLaptopContext();
        }
        public bool AddVga(Vga vga)
        {
            try
            {
                if (vga != null)
                {
                    vga.Id = Guid.NewGuid();
                    _lapTopContext.Add(vga);
                    _lapTopContext.SaveChanges();
                    return true;
                }
                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool DeleteVga(Guid idVga)
        {
            var ketqua = _lapTopContext.Vgas.Find(idVga);
            if (ketqua != null)
            {
                _lapTopContext.Remove(ketqua);
                _lapTopContext.SaveChanges();
                return true;
            }
            return false;
        }

        public List<Vga> GetAllVga()
        {
            return _lapTopContext.Vgas.ToList();
        }

        public Vga GetVgaById(Guid idVga)
        {
            var ketqua = _lapTopContext.Vgas.Find(idVga);
            return ketqua;
        }

        public bool UpdateVga(Vga vga)
        {
            var ketqua = _lapTopContext.Vgas.FirstOrDefault(c => c.Id == vga.Id);
            if (ketqua != null)
            {
                ketqua.Ma = vga.Ma;
                ketqua.Ten = vga.Ten;
                _lapTopContext.Update(ketqua);
                _lapTopContext.SaveChanges();
                return true;
            }
            return false;
        }
    }
}
