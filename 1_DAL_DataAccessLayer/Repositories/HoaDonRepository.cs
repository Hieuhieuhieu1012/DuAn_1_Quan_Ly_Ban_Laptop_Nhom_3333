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
    public class HoaDonRepository : IHoaDonRepository
    {
        QlBanLaptopContext _lapTopContext;
        public HoaDonRepository()
        {
            _lapTopContext = new QlBanLaptopContext();
        }
        public bool AddHoaDon(HoaDon hoaDon)
        {
            try
            {
                if (hoaDon != null)
                {
                    _lapTopContext.Add(hoaDon);
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

        public bool AddHoaDonThenCtHoaDon(HoaDon hoaDon, List<ChiTietHoaDon> chiTietHDs)
        {
            using (var dbContextTransaction  = _lapTopContext.Database.BeginTransaction())
            {
                try
                {
                    hoaDon.Id = Guid.NewGuid();
                    _lapTopContext.HoaDons.Add(hoaDon);
                    _lapTopContext.SaveChanges();

                    foreach (var a in chiTietHDs)
                    {
                        a.IdHoaDon = hoaDon.Id;
                    }
                    _lapTopContext.ChiTietHoaDons.AddRange(chiTietHDs);
                    _lapTopContext.SaveChanges();

                    dbContextTransaction.Commit();
                    return true;
                }
                catch (Exception e)
                {
                    dbContextTransaction.Rollback();
                    return false;
                    throw;
                }
            }
        }

        public IQueryable<HoaDon> GetAllHoaDon()
        {
            return _lapTopContext.HoaDons.AsQueryable();
        }

        public HoaDon GetHoaDonById(Guid idHoaDon)
        {
            var ketqua = _lapTopContext.HoaDons.Find(idHoaDon);
            return ketqua;
        }

        public bool UpdateHoaDon(HoaDon hoaDon)
        {
            var ketqua = _lapTopContext.HoaDons.FirstOrDefault(c=>c.Id == hoaDon.Id);
            if (ketqua != null)
            {
                ketqua.Ma = hoaDon.Ma;
                ketqua.HinhThucTT = hoaDon.HinhThucTT;
                ketqua.NgayTao = hoaDon.NgayTao;
                ketqua.NgayThanhToan = hoaDon.NgayThanhToan;
                ketqua.DiaChiNhanHang = hoaDon.DiaChiNhanHang;
                ketqua.GhiChu = hoaDon.GhiChu;
                ketqua.TongTien = hoaDon.TongTien;
                _lapTopContext.Update(ketqua);
                _lapTopContext.SaveChanges();
                return true;
            }
            return false;
        }
    }
}
