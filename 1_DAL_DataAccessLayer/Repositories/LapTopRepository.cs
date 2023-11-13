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
    public class LapTopRepository : ILapTopRepository
    {
        QlBanLaptopContext _lapTopContext;
        public LapTopRepository()
        {
            _lapTopContext = new QlBanLaptopContext();
        }
        public bool AddLapTop(Laptop lapTop)
        {
            try
            {
                if(lapTop != null)
                {
                    lapTop.Id = Guid.NewGuid();
                    _lapTopContext.Add(lapTop);
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

        public List<Laptop> GetAllLapTop()
        {
            return _lapTopContext.Laptops.ToList();
        }

        public bool UpdateStatusLaptop(List<Laptop> lstLaptops)
        {
            foreach (var x in lstLaptops)
            {
                if (x.TrangThai == true)
                {
                    x.TrangThai = false;
                    _lapTopContext.Laptops.Update(x);
                    _lapTopContext.SaveChanges();
                }
                else
                {
                    x.TrangThai = true;
                    _lapTopContext.Laptops.Update(x);
                    _lapTopContext.SaveChanges();
                }
            }
            return true;
        }

        public bool UpdateKhuyenMaiLaptop(Guid idLaptop, Guid? idKhuyenMai)
        {
            var laptop = _lapTopContext.Laptops.FirstOrDefault(x => x.Id == idLaptop);
            if (laptop != null)
            {
                laptop.IdKhuyenMai = idKhuyenMai;
                _lapTopContext.Laptops.Update(laptop);
                _lapTopContext.SaveChanges();
                return true;
            }

            return false;
        }

        public Laptop GetLapTopById(Guid idLapTop)
        {
            var ketqua = _lapTopContext.Laptops.Find(idLapTop);
            return ketqua;
        }

        public bool UpdateLapTop(Laptop lapTop)
        {
            var ketqua = _lapTopContext.Laptops.FirstOrDefault(c=>c.Id == lapTop.Id);
            if (ketqua != null)
            {
                ketqua.IdHangLaptop = lapTop.IdHangLaptop;
                ketqua.IdDongLaptop = lapTop.IdDongLaptop;
                ketqua.IdCpu = lapTop.IdCpu;
                ketqua.IdVga = lapTop.IdVga;
                ketqua.IdRam = lapTop.IdRam;
                ketqua.IdOCung = lapTop.IdOCung;
                ketqua.IdMauSac = lapTop.IdMauSac;
                ketqua.IdManHinh = lapTop.IdManHinh;
                ketqua.IdNhaCungCap = lapTop.IdNhaCungCap;
                ketqua.ManHinh = lapTop.ManHinh;
                ketqua.Mota = lapTop.Mota;
                ketqua.MauSac = lapTop.MauSac;
                ketqua.TrongLuong = lapTop.TrongLuong;
                ketqua.GiaNhap = lapTop.GiaNhap;
                ketqua.GiaBan = lapTop.GiaBan;
                ketqua.NamBh = lapTop.NamBh;
                ketqua.TrangThai = lapTop.TrangThai;
                ketqua.HinhAnh = lapTop.HinhAnh;
                _lapTopContext.Update(ketqua);
                _lapTopContext.SaveChanges();
                return true;
            }
            return false;
        }

        public List<Laptop> GetAllLaptopNoSerial()
        {
            return _lapTopContext.Laptops.ToList();
        }
    }
}
