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
    public class LaptopService : ILaptopService

    {
        private IHangLapTopRepositories _hangLapTopRepositories;
        private IDongLapTopRepositories _dongLapTopRepositories;
        private ICpuRepositories _cpuRepositories;
        private IVgaRepositories _vgaRepositories;
        private IRamRepository _ramRepository;
        private IOCungReposittories _oCungReposittories;
        private IManHinhRepositories _manHinhRepositories;
        private IMauSacRepository _mauSacRepository;
        private ISerialLaptopRepository _serialLaptopRepository;
        private INhaCungCapRepository _nhaCungCapRepository;
        private ILapTopRepository _sanPhamLapTopRepository;
        private IKhuyenMaiRepository _khuyenMaiRepository;

        public LaptopService()
        {
            _hangLapTopRepositories = new HangLaptopRepositories();
            _dongLapTopRepositories = new DongLapTopReposittoies();
            _cpuRepositories = new CpuRepositories();
            _vgaRepositories = new VGARepositories();
            _ramRepository = new Ramrepository();
            _oCungReposittories = new OCungRepositories();
            _manHinhRepositories = new ManHinhRepositories();
            _mauSacRepository = new MauSacRepositories();
            _serialLaptopRepository = new SerialLaptopRepository();
            _nhaCungCapRepository = new NhaCungCapRepository();
            _sanPhamLapTopRepository = new LapTopRepository();
            _khuyenMaiRepository = new KhuyenMaiRepository();

        }
        public string AddLaptop(LaptopView obj)
        {
            Laptop laptop = new Laptop()
            {
                Id = obj.Id,
                IdHangLaptop = obj.IdHangLaptop,
                IdDongLaptop = obj.IdDongLaptop,
                IdNhaCungCap = obj.IdNhaCungCap,
                IdCpu = obj.IdCpu,
                IdRam = obj.IdRam,
                IdVga = obj.IdVga,
                IdOCung = obj.IdOCung,
                IdMauSac = obj.IdMauSac,
                IdManHinh = obj.IdManHinh,

                Ten = obj.Ten,
                Mota = obj.Mota,
                TrongLuong = obj.TrongLuong,
                GiaNhap = obj.GiaNhap,
                GiaBan = obj.GiaBan,
                NamBh = obj.NamBh,
                TrangThai = obj.TrangThai,
                HinhAnh = obj.Anh
            };
            if (_sanPhamLapTopRepository.AddLapTop(laptop))
            {
                return "Thêm thành công";
            }

            return "Thêm thất bại";
        }

        public string UpdateLaptop(LaptopView obj)
        {
            var laptop = _sanPhamLapTopRepository.GetAllLapTop().FirstOrDefault(c => c.Id == obj.Id);

            laptop.Id = obj.Id;
            laptop.IdHangLaptop = obj.IdHangLaptop;
            laptop.IdDongLaptop = obj.IdDongLaptop;
            laptop.IdCpu = obj.IdCpu;
            laptop.IdVga = obj.IdVga;
            laptop.IdRam = obj.IdRam;
            laptop.IdOCung = obj.IdOCung;
            laptop.IdMauSac = obj.IdMauSac;
            laptop.IdManHinh = obj.IdManHinh;
            laptop.IdNhaCungCap = obj.IdNhaCungCap;

            laptop.Ten = obj.Ten;
            laptop.Mota = obj.Mota;
            laptop.TrangThai = obj.TrangThai;
            laptop.TrongLuong = obj.TrongLuong;
            laptop.GiaBan = obj.GiaBan;
            laptop.GiaNhap = obj.GiaNhap;
            laptop.NamBh = obj.NamBh;
            laptop.HinhAnh = obj.Anh;

            if (_sanPhamLapTopRepository.UpdateLapTop(laptop))
            {
                return "Sửa thành công";
            }

            return "Sửa thất bại";
        }

        public string UpdateStatusLaptop(List<Laptop> lstLaptops)
        {

            if (_sanPhamLapTopRepository.UpdateStatusLaptop(lstLaptops))
            {
                return "Chuyển thành công";
            }

            return "Chuyển thất bại";
        }

        public string UpdateKhuyeMaiLaptop(Guid idLaptop, Guid? idKhuyenMai)
        {
            if (_sanPhamLapTopRepository.UpdateKhuyenMaiLaptop(idLaptop, idKhuyenMai))
            {
                return "Thành công";
            }

            return "Thấi bại";
        }

        public List<Laptop> GetLaptopFromDb()
        {
            return _sanPhamLapTopRepository.GetAllLapTop();
        }

        public List<LaptopView> GetAllLaptop()
        {
            #region Demo2
            //List<LaptopView> list = new List<LaptopView>();
            //list = (from sanPham in _sanPhamLapTopRepository.GetAllLapTop()
            //        join hangLaptop in _hangLapTopRepositories.GetAllHangLaptops() on sanPham.IdHangLaptop equals hangLaptop.Id
            //        join dongLaptop in _dongLapTopRepositories.GetAllDongLaptop() on sanPham.IdDongLaptop equals dongLaptop.Id
            //        join cpu in _cpuRepositories.GetAllCpu() on sanPham.IdCpu equals cpu.Id
            //        join vga in _vgaRepositories.GetAllVga() on sanPham.IdVga equals vga.Id
            //        join ram in _ramRepository.GetAllRam() on sanPham.IdRam equals ram.Id
            //        join oCung in _oCungReposittories.GetAllOCungs() on sanPham.IdOCung equals oCung.Id
            //        join mauSac in _mauSacRepository.GetAllMauSac() on sanPham.IdMauSac equals mauSac.Id
            //        join manHinh in _manHinhRepositories.GetAllManHinh() on sanPham.IdManHinh equals manHinh.Id
            //        join nhaCungCap in _nhaCungCapRepository.GetAllNhaCungCap() on sanPham.IdNhaCungCap equals nhaCungCap.Id
            //        join serialLaptop in _serialLaptopRepository.GetLstSerialLaptopFromDb().Where(c => c.TrangThai) on sanPham.Id equals serialLaptop.IdLaptop

            //        group sanPham by new
            //        {
            //            sanPham.Ten,
            //            hangLaptopTen = hangLaptop.Ten,
            //            dongLaptopTen = dongLaptop.Ten,
            //            cpuTen = cpu.Ten,
            //            vgaTen = vga.Ten,
            //            ramTen = ram.Ten,
            //            oCungTen = oCung.Ten,
            //            mauSacMa = mauSac.Ma,
            //            manHinhMa = manHinh.Ma,
            //            nhaCungCapTen = nhaCungCap.Ten,

            //        } into grp
            //        select new LaptopView
            //        {
            //            IdHangLaptop = grp.First().IdHangLaptop,
            //            IdDongLaptop = grp.First().IdDongLaptop,
            //            IdCpu = grp.First().IdCpu,
            //            IdVga = grp.First().IdVga,
            //            IdRam = grp.First().IdRam,
            //            IdOCung = grp.First().IdOCung,
            //            IdMauSac = grp.First().IdMauSac,
            //            IdManHinh = grp.First().IdManHinh,
            //            IdNhaCungCap = grp.First().IdNhaCungCap,

            //            HangLaptop = grp.Key.hangLaptopTen,
            //            DongLaptop = grp.Key.dongLaptopTen,
            //            Ten = grp.Key.Ten,
            //            Cpu = grp.Key.cpuTen,
            //            Vga = grp.Key.vgaTen,
            //            Ram = grp.Key.ramTen,
            //            OCung = grp.Key.oCungTen,
            //            MauSac = grp.Key.mauSacMa,
            //            ManHinh = grp.Key.manHinhMa,
            //            NhaCungCap = grp.Key.nhaCungCapTen,
            //            Mota = grp.First().Mota,
            //            TrongLuong = grp.First().TrongLuong,
            //            GiaBan = grp.First().GiaBan,
            //            GiaNhap = grp.First().GiaNhap,
            //            NamBh = grp.First().NamBh,
            //            SoLuongTon = grp.Count(),
            //            Anh = grp.First().HinhAnh,
            //            //ListSerial = grp.Select(c=>c.SerialLaptop.Serial).ToList()
            //        }).ToList();

            //return list;
            #endregion
            List<LaptopView> list = new List<LaptopView>();
            list = (from sanPham in _sanPhamLapTopRepository.GetAllLapTop()
                join hangLaptop in _hangLapTopRepositories.GetAllHangLaptops() on sanPham.IdHangLaptop equals hangLaptop
                    .Id
                join dongLaptop in _dongLapTopRepositories.GetAllDongLaptop() on sanPham.IdDongLaptop equals dongLaptop
                    .Id
                join cpu in _cpuRepositories.GetAllCpu() on sanPham.IdCpu equals cpu.Id
                join vga in _vgaRepositories.GetAllVga() on sanPham.IdVga equals vga.Id
                join ram in _ramRepository.GetAllRam() on sanPham.IdRam equals ram.Id
                join oCung in _oCungReposittories.GetAllOCungs() on sanPham.IdOCung equals oCung.Id
                join mauSac in _mauSacRepository.GetAllMauSac() on sanPham.IdMauSac equals mauSac.Id
                join manHinh in _manHinhRepositories.GetAllManHinh() on sanPham.IdManHinh equals manHinh.Id
                join nhaCungCap in _nhaCungCapRepository.GetAllNhaCungCap() on sanPham.IdNhaCungCap equals nhaCungCap.Id
                //join khuyenMai in _khuyenMaiRepository.GetAllKhuyenMai() on sanPham.IdKhuyenMai equals khuyenMai.Id
                select new LaptopView
                {
                    Id = sanPham.Id,
                    IdHangLaptop = hangLaptop.Id,
                    IdDongLaptop = dongLaptop.Id,
                    IdCpu = cpu.Id,
                    IdVga = vga.Id,
                    IdRam = ram.Id,
                    IdOCung = oCung.Id,
                    IdMauSac = mauSac.Id,
                    IdManHinh = manHinh.Id,
                    IdNhaCungCap = nhaCungCap.Id,
                    IdKhuyenMai = sanPham.IdKhuyenMai,
                    Ten = sanPham.Ten,
                    HangLaptop = hangLaptop.Ten,
                    DongLaptop = dongLaptop.Ten,
                    Cpu = cpu.Ten,
                    Vga = vga.Ten,
                    Ram = ram.Ten,
                    OCung = oCung.Ten,
                    MauSac = mauSac.Ten,
                    ManHinh = manHinh.Ten,
                    NhaCungCap = nhaCungCap.Ten,
                    Mota = sanPham.Mota,
                    TrongLuong = sanPham.TrongLuong,
                    GiaBan = sanPham.GiaBan,
                    GiaNhap = sanPham.GiaNhap,
                    NamBh = sanPham.NamBh,
                    TrangThai = sanPham.TrangThai,
                    SoLuongTon =
                        _serialLaptopRepository.GetLstSerialLaptopFromDb().Count(c => c.IdLaptop == sanPham.Id && c.TrangThai),
                    Anh = sanPham.HinhAnh,
                }).ToList();

            return list;
        }

      
    }
}
