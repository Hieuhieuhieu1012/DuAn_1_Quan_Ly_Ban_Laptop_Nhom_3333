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
    public class NhanVienRepository : INhanVienRepository
    {
        QlBanLaptopContext _lapTopContext;
        public NhanVienRepository()
        {
            _lapTopContext = new QlBanLaptopContext();
        }
        public bool AddNhanVien(NhanVien nhanVien)
        {
            try
            {
                if(nhanVien != null)
                {
                    nhanVien.Id = Guid.NewGuid();
                    _lapTopContext.Add(nhanVien);
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

        public bool DoiTrangThai(List<NhanVien> lstNhanVien)
        {
            foreach (var item in lstNhanVien)
            {
                if (item.TrangThai == true)
                {
                    item.TrangThai = false;
                    _lapTopContext.NhanViens.Update(item);
                    _lapTopContext.SaveChanges();
                }
            }
            return true;
        }

        public List<NhanVien> GetAllNhanVien()
        {
            return _lapTopContext.NhanViens.ToList();
        }

        public NhanVien GetNhanVienById(Guid idNhanVien)
        {
            var ketqua = _lapTopContext.NhanViens.Find(idNhanVien);
            return ketqua;
        }

       
        public bool UpdateNhanVien(Guid idNhanVien, NhanVien nhanVien)
        {
            var ketqua = _lapTopContext.NhanViens.Find(idNhanVien);
            if(ketqua != null)
            {
                ketqua.Hoten = nhanVien.Hoten;
                ketqua.Email = nhanVien.Email;
                ketqua.DiaChi = nhanVien.DiaChi;
                ketqua.SoDienThoai = nhanVien.SoDienThoai;
                ketqua.MatKhau = nhanVien.MatKhau;
                ketqua.ChucVu = nhanVien.ChucVu;
                ketqua.HinhAnh = nhanVien.HinhAnh;
                ketqua.CCCD = nhanVien.CCCD;
                _lapTopContext.Update(ketqua);
                _lapTopContext.SaveChanges();
                return true;
            }
            return false;
        }
        public bool UpdateNV( NhanVien nhanVien)
        {
            _lapTopContext.NhanViens.Update(nhanVien);
            _lapTopContext.SaveChanges();            
            return true;
            
        }
    }
}
