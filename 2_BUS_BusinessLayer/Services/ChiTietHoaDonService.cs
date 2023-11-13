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
    public class ChiTietHoaDonService : IChiTietHoaDonService
    {
        private IHoaDonRepository _hoaDonRepository;
        private IChiTietHoaDonRepository _chiTietHoaDonRepository;
        private ILapTopRepository _lapTopRepository;
        private ISerialLaptopRepository _serialLaptopRepository;
        private IHangLapTopRepositories _hangLaptopRepositories;
        private IDongLapTopRepositories _dongLapTopRepositories;

        public ChiTietHoaDonService()
        {
            _hoaDonRepository = new HoaDonRepository();
            _chiTietHoaDonRepository = new ChiTietHoaDonRepository();
            _lapTopRepository = new LapTopRepository();
            _serialLaptopRepository = new SerialLaptopRepository();
            _hangLaptopRepositories = new HangLaptopRepositories();
            _dongLapTopRepositories = new DongLapTopReposittoies();
        }
        public string AddChiTietHoaDon(ChiTietHoaDonView obj)
        {
            var chiTietHoaDon = new ChiTietHoaDon()
            {
                Id = obj.Id,
                IdHoaDon = obj.IdHoaDon,
                IdLaptop = obj.IdSanPham,
                IdLinhKien = obj.IdSanPham,
                Serial = obj.SerialSanPham,
                DonGia = obj.DonGia,
                SoLuong = obj.SoLuong,
                GiamGia = obj.GiamGia,
                ThanhTien = obj.ThanhTien,
            };

            if (_chiTietHoaDonRepository.AddChiTietHoaDon(chiTietHoaDon))
            {
                return "Thanh cong";
            }

            return "Khong thanh cong";
        }

        public string RemoveChiTietHoaDon(Guid id)
        {
            throw new NotImplementedException();
        }

        public string UpdateChiTietHoaDon(ChiTietHoaDonView obj)
        {
            var chiTietHoaDon = _chiTietHoaDonRepository.GetChiTietHoaDonById(obj.Id);
            if (chiTietHoaDon != null)
            {
                chiTietHoaDon.IdHoaDon = obj.IdHoaDon;
                chiTietHoaDon.IdLaptop = obj.IdSanPham;
                chiTietHoaDon.IdLinhKien = obj.IdSanPham;
                chiTietHoaDon.SoLuong = obj.SoLuong;
                chiTietHoaDon.DonGia = obj.DonGia;
                chiTietHoaDon.ThanhTien = obj.ThanhTien;

                if (_chiTietHoaDonRepository.UpdateChiTietHoaDon(chiTietHoaDon))
                {
                    return "Sửa thành công";
                }

                return "Sửa thất bại";
            }

            return "Sửa thất bại";
        }

        public string UpdateStatusChiTietHoaDon(Guid id)
        {
            throw new NotImplementedException();
        }

        public List<ChiTietHoaDonView> GetAllChiTietHoaDon()
        {
            var lst = (from a in _chiTietHoaDonRepository.GetAllChiTietHoaDon()
                join b in _hoaDonRepository.GetAllHoaDon() on a.IdHoaDon equals b.Id
                join c in _lapTopRepository.GetAllLapTop() on a.IdLaptop equals c.Id
                join e in _hangLaptopRepositories.GetAllHangLaptops() on c.IdHangLaptop equals e.Id
                join f in _dongLapTopRepositories.GetAllDongLaptop() on c.IdDongLaptop equals f.Id 
                       select new ChiTietHoaDonView()
                {
                    Id = a.Id,
                    IdHoaDon = b.Id,
                    IdSanPham = c.Id,
                    TenSanPham = c.Ten,
                    SerialSanPham = a.Serial,
                    Hang = e.Ten,
                    Dong = f.Ten,
                    SoLuong = a.SoLuong,
                    DonGia = a.DonGia,
                    GiamGia = a.GiamGia,
                }).ToList();

            return lst;
        }
        public List<ChiTietHoaDonView> GetAllCTHĐ(Guid id)
        {
            var lst = (from a in _chiTietHoaDonRepository.GetAllChiTietHoaDon()
                join b in _hoaDonRepository.GetAllHoaDon() on a.IdHoaDon equals b.Id
                join c in _lapTopRepository.GetAllLapTop() on a.IdLaptop equals c.Id
                join e in _hangLaptopRepositories.GetAllHangLaptops() on c.IdHangLaptop equals e.Id
                join f in _dongLapTopRepositories.GetAllDongLaptop() on c.IdDongLaptop equals f.Id 
                where a.IdHoaDon == id

                select new ChiTietHoaDonView()
                {
                    Id = a.Id,
                    IdHoaDon = b.Id,
                    IdSanPham = c.Id,
                    TenSanPham = c.Ten,
                    SerialSanPham = a.Serial,
                    Hang = e.Ten,
                    Dong = f.Ten,
                    SoLuong = a.SoLuong,
                    DonGia = a.DonGia,
                    GiamGia = a.GiamGia,
                }).ToList();

            return lst;
        }
    }
}
