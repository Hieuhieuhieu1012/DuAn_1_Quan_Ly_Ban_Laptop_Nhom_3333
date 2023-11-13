using _1_DAL_DataAccessLayer.Context;
using _1_DAL_DataAccessLayer.IRepositories;
using _1_DAL_DataAccessLayer.Models;
using Microsoft.EntityFrameworkCore.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DAL_DataAccessLayer.Repositories
{
    public class KhuyenMaiRepository : IKhuyenMaiRepository
    {
        QlBanLaptopContext _lapTopContext;
        public KhuyenMaiRepository()
        {
            _lapTopContext = new QlBanLaptopContext();
        }
        public bool AddKhuyenMai(KhuyenMai khuyenMai)
        {
            try
            {
                if (khuyenMai != null)
                {
                    _lapTopContext.Add(khuyenMai);
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

        public bool ChuyenTrangThai(KhuyenMai khuyenMai)
        {
            var ketqua = _lapTopContext.KhuyenMais.FirstOrDefault(c => c.Id == khuyenMai.Id);

            if (ketqua.TrangThai == 0 && ketqua.NgayKetThuc.Date < DateTime.Now.Date)
            {
                var laptop = _lapTopContext.Laptops.Where(c => c.IdKhuyenMai == khuyenMai.Id);
                ketqua.TrangThai = 2;
                foreach (var a in laptop)
                {
                    a.IdKhuyenMai = null;
                    _lapTopContext.Update(a);
                    _lapTopContext.SaveChanges();
                }
                _lapTopContext.Update(ketqua);
                _lapTopContext.SaveChanges();
                return true;
            }

            if (ketqua.TrangThai == 1 && ketqua.NgayBatDau.Date == DateTime.Now.Date)
            {
                ketqua.TrangThai = 0;
                _lapTopContext.Update(ketqua);
                _lapTopContext.SaveChanges();
                return true;
            }
            return true;


        }

        public List<KhuyenMai> GetAllKhuyenMai()
        {
            return _lapTopContext.KhuyenMais.ToList();
        }

        public KhuyenMai GetKhuyenMaiById(Guid idKhuyenMai)
        {
            var ketqua = _lapTopContext.KhuyenMais.Find(idKhuyenMai);
            return ketqua;
        }

        public bool UpdateKhuyenMai(KhuyenMai khuyenMai)
        {
            var ketqua = _lapTopContext.KhuyenMais.FirstOrDefault(c => c.Id == khuyenMai.Id);
            if (ketqua != null)
            {
                ketqua.Ten = khuyenMai.Ten;
                ketqua.LoaiKhuyenMai = khuyenMai.LoaiKhuyenMai;
                ketqua.GiaTri = khuyenMai.GiaTri;
                ketqua.TrangThai = khuyenMai.TrangThai;
                ketqua.NgayBatDau = khuyenMai.NgayBatDau;
                ketqua.NgayKetThuc = khuyenMai.NgayKetThuc;
                _lapTopContext.Update(ketqua);
                _lapTopContext.SaveChanges();
                return true;
            }
            return false;
        }
    }
}
