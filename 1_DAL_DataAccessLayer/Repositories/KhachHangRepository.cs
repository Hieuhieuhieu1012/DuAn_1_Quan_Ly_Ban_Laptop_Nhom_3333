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
    public class KhachHangRepository : IKhachHangRepository
    {
        QlBanLaptopContext _laptopContext;
        public KhachHangRepository()
        {
            _laptopContext = new QlBanLaptopContext();
        }
        public bool AddKhachHang(KhachHang khachHang)
        {
            try
            {
                if(khachHang != null)
                {
                    khachHang.Id = Guid.NewGuid();
                    _laptopContext.Add(khachHang);
                    _laptopContext.SaveChanges();
                    return true;
                }
                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public List<KhachHang> GetAllKhachHang()
        {
            return _laptopContext.KhachHangs.ToList();
        }

        public KhachHang GetKhachHangById(Guid idKhachHang)
        {
            var ketqua = _laptopContext.KhachHangs.Find(idKhachHang);
            return ketqua;
        }

        public bool UpdateKhachHang(KhachHang khachHang)
        {
            var ketqua = _laptopContext.KhachHangs.FirstOrDefault(c=>c.Id == khachHang.Id);
            if(ketqua != null)
            {
                ketqua.Hoten = khachHang.Hoten;
                ketqua.Ma = khachHang.Ma;
                ketqua.SoDienThoai = khachHang.SoDienThoai;
                ketqua.Email = khachHang.Email;
                ketqua.DiaChi = khachHang.DiaChi;
                ketqua.GioiTinh = khachHang.GioiTinh;
                _laptopContext.Update(ketqua);
                _laptopContext.SaveChanges();
                return true;
            }
            return false;
        }
    }
}
