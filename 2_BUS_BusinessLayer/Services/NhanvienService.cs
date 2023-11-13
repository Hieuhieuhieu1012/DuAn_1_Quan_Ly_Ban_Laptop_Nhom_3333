using _1_DAL_DataAccessLayer.Models;
using _1_DAL_DataAccessLayer.Repositories;
using _2_BUS_BusinessLayer.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_BUS_BusinessLayer.Services
{
    public class NhanvienService : INhanVienService
    {
        private NhanVienRepository _nhanVienRepository;

        public NhanvienService()
        {
            _nhanVienRepository = new NhanVienRepository();

        }

        public string AddNhanVien(NhanVien nhanVien)
        {
            if (_nhanVienRepository.AddNhanVien(nhanVien))
            {
                return "Thêm thành công";
            }
            return "Thêm thất bại";
        }

        public string UpdateNhanVien(Guid idNhanVien, NhanVien nhanVien)
        {
            if (_nhanVienRepository.UpdateNhanVien(idNhanVien, nhanVien))
            {
                return "Sửa thành công";
            }
            return "Sửa thất bại";
        }
        

        public List<NhanVien> GetAllNhanViens()
        {
            return _nhanVienRepository.GetAllNhanVien();
        }

        public List<NhanVien> GetByNhanViens(string msg)
        {
            var lst = _nhanVienRepository.GetAllNhanVien().
                Where(c => c.SoDienThoai.ToLower().Contains(msg.ToLower()) ||
                               c.Hoten.ToLower().Contains(msg.ToLower())).ToList();
            return lst;
        }

        public NhanVien GetNhanVienById(Guid idNhanVien)
        {
            throw new NotImplementedException();
        }

        public bool UpdateNV(NhanVien nhanVien)
        {
                var a = _nhanVienRepository.GetAllNhanVien().FirstOrDefault(c => c.Id == nhanVien.Id);
                a.Hoten = nhanVien.Hoten;
                a.Email = nhanVien.Email;
                a.DiaChi = nhanVien.DiaChi;
                a.SoDienThoai = nhanVien.SoDienThoai;
                a.MatKhau = nhanVien.MatKhau;
                a.ChucVu = nhanVien.ChucVu;
                a.HinhAnh = nhanVien.HinhAnh;
                a.CCCD = nhanVien.CCCD;
            _nhanVienRepository.UpdateNV(a);
            return true;
        }

        public string DoiTrangThai(List<NhanVien> lstNhanVien)
        {
            if (_nhanVienRepository.DoiTrangThai(lstNhanVien))
            {
                return "Thành công";
            }

            return "Không thành công";
        }
    }
}
