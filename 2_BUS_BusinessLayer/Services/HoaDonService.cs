using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1_DAL_DataAccessLayer.IRepositories;
using _1_DAL_DataAccessLayer.Models;
using _1_DAL_DataAccessLayer.Repositories;
using _2_BUS_BusinessLayer.IServices;
using _2_BUS_BusinessLayer.ViewModel;

namespace _2_BUS_BusinessLayer.Services
{
    public class HoaDonService : IHoaDonSerevice
    {
        private IKhachHangRepository _khachHangRepository;
        private INhanVienRepository _nhanVienRepository;
        private IHoaDonRepository _hoaDonRepository;
        private ILapTopRepository _lapTopRepo;

        public HoaDonService()
        {
            _lapTopRepo = new LapTopRepository();
            _khachHangRepository = new KhachHangRepository();
            _nhanVienRepository = new NhanVienRepository();
            _hoaDonRepository = new HoaDonRepository();
        }
        public string AddHoaDon(HoaDonView obj)
        {
            var hoaDon = new HoaDon()
            {
                Id = obj.Id,
                IdNhanVien = obj.IdNhanVien,
                IdKhachHang = obj.IdKhachHang,
                Ma = obj.MaHd,
                HinhThucTT = obj.HTThanhToan,
                TrangThai = obj.TrangThaiHD,
                NgayTao = obj.NgayTao,
                NgayThanhToan = obj.NgayThanhToan,
                DiaChiNhanHang = obj.DcNhanHang,
                GhiChu = obj.GhiChu,
                TongTien = obj.TongTien,
            };
            if (_hoaDonRepository.AddHoaDon(hoaDon))
            {
                return "Them thanh cong";
            }

            return "Them that bai";
        }



        public string RemoveHoaDon(Guid id)
        {
            throw new NotImplementedException();
        }

        public string UpdateHoaDon(HoaDonView obj)
        {
            var hoaDon = _hoaDonRepository.GetHoaDonById(obj.Id);
            hoaDon.IdNhanVien = obj.IdNhanVien;
            hoaDon.IdKhachHang = obj.IdKhachHang;
            hoaDon.Ma = obj.MaHd;
            hoaDon.HinhThucTT = obj.HTThanhToan;
            hoaDon.NgayTao = obj.NgayTao;
            hoaDon.NgayThanhToan = obj.NgayThanhToan;
            hoaDon.TrangThai = obj.TrangThaiHD;
           hoaDon.DiaChiNhanHang = obj.DcNhanHang;
           hoaDon.GhiChu = obj.GhiChu;
           hoaDon.TongTien = obj.TongTien;

           if (_hoaDonRepository.UpdateHoaDon(hoaDon))
           {
               return "Sửa thành công";
           }

           return "Sửa thất bại";
        }

        public string UpdateStatusHoaDon(Guid id)
        {
            throw new NotImplementedException();
        }

        public List<HoaDonView> GetAllHoaDonViews()
        {
            var lst = (from a in _hoaDonRepository.GetAllHoaDon()
                join b in _nhanVienRepository.GetAllNhanVien() on a.IdNhanVien equals b.Id
                join c in _khachHangRepository.GetAllKhachHang() on a.IdKhachHang equals c.Id
                select new HoaDonView()
                {
                    Id = a.Id,
                    IdNhanVien = b.Id,
                    IdKhachHang = c.Id,
                    TenNhanVien = b.Hoten,
                    TenKhachHang = c.Hoten,
                           SDT = c.SoDienThoai,
                           MaHd = a.Ma,
                    HTThanhToan = a.HinhThucTT,
                    NgayTao = a.NgayTao,
                           TrangThaiHD = a.TrangThai,
                    NgayThanhToan = a.NgayThanhToan,
                    //  TrangThai = a.TrangThai,
                    DcNhanHang = a.DiaChiNhanHang,
                    GhiChu = a.GhiChu,
                    TongTien = a.TongTien
                }).ToList();

            return lst;
        }

        public string AutoGenerateMa()
        {
            Random random = new Random();
            int numGenerate =  random.Next(1000,9999);
            string maHD;
            maHD = $"HD{numGenerate}";
            if (_hoaDonRepository.GetAllHoaDon().Any(c=>c.Ma == maHD))
            {
                AutoGenerateMa();
            }

            return maHD;
            //int countHD = _hoaDonRepository.GetAllHoaDon().Count;

            //for (numGenerate = 0; numGenerate <= countHD; numGenerate++)
            //{
            //    numGenerate++;
            //    maHD = $"HD{numGenerate.ToString().PadLeft(6, '0')}";
            //    if (_hoaDonRepository.GetAllHoaDon().All(c => c.Ma != maHD))
            //    {
            //        return maHD;
            //    }
            //}

            //numGenerate = countHD + 1;
            //maHD = $"HD{numGenerate.ToString().PadLeft(6, '0')}";
            //return maHD;

        }
    }
}
