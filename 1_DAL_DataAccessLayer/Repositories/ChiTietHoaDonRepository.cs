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
    public class ChiTietHoaDonRepository : IChiTietHoaDonRepository
    {
        QlBanLaptopContext _lapTopContext;
        public ChiTietHoaDonRepository()
        {
            _lapTopContext = new QlBanLaptopContext();
        }
        public bool AddChiTietHoaDon(ChiTietHoaDon chiTietHoaDon)
        {
            try
            {
                if (chiTietHoaDon != null)
                {
                    _lapTopContext.Add(chiTietHoaDon);
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

        public bool DeleteChiTietHoaDon(Guid idChiTietHoaDon)
        {
            var ketqua = _lapTopContext.ChiTietHoaDons.Find(idChiTietHoaDon);
            if (ketqua != null)
            {
                _lapTopContext.Remove(ketqua);
                _lapTopContext.SaveChanges();

                return true;
            }
            return false;
        }

        //public bool DeleteChiTietHoaDon(ChiTietHoaDon chiTietHoaDon)
        //{
        //    var ketqua = _lapTopContext.ChiTietHoaDons;
        //    if (ketqua != null)
        //    {
        //        _lapTopContext.Remove(ketqua);
        //        _lapTopContext.SaveChanges();

        //        return true;
        //    }
        //    return false;
        //}

        public List<ChiTietHoaDon> GetAllChiTietHoaDon()
        {
            return _lapTopContext.ChiTietHoaDons.ToList();
        }

        public ChiTietHoaDon GetChiTietHoaDonById(Guid idChiTietHoaDon)
        {
            var ketqua = _lapTopContext.ChiTietHoaDons.Find(idChiTietHoaDon);
            return ketqua;
        }

        public bool UpdateChiTietHoaDon(ChiTietHoaDon chiTietHoaDon)
        {
            var ketqua = _lapTopContext.ChiTietHoaDons.FirstOrDefault(c => c.Id == chiTietHoaDon.Id);
            if (ketqua != null)
            {
                ketqua.SoLuong = chiTietHoaDon.SoLuong;
                ketqua.DonGia = chiTietHoaDon.DonGia;
                ketqua.ThanhTien = chiTietHoaDon.ThanhTien;
                _lapTopContext.Update(ketqua);
                _lapTopContext.SaveChanges();
                return true;
            }
            return false;
        }
    }
}
