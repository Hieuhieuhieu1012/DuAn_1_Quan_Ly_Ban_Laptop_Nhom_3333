using _2_BUS_BusinessLayer.IServices;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_BUS_BusinessLayer.Services
{
    public struct DoanhThuByDay
    {
        public string Date { get; set; }
        public decimal DoanhThu { get; set; }
    }
    public class ThongKeService
    {
        private DateTime _startDate;
        private DateTime _endDate;
        private int _numberDay;

        public int NumCustomers { get; private set; }
        public int NumNhaCungCaps { get; private set; }
        public int NumProducts { get; private set; }
        public List<KeyValuePair<string, int>> TopProductList { get; private set; }
        public List<KeyValuePair<string, int>> UnderStockList { get; private set; }
        public List<DoanhThuByDay> DoanhThuByDaysList { get; private set; }
        public int NumHoaDons { get; set; }
        public decimal TongDoanhThu { get; set; }
        public decimal TongLoiNhuan { get; set; }

        private IKhachHangService _khachHangService;
        private IHoaDonSerevice _hoaDonSerevice;
        private IChiTietHoaDonService _chiTietHoaDonService;
        private ILaptopService _laptopService;
        private INhaCungCapServices _nhaCungCapServices;

        public ThongKeService()
        {
            
            _khachHangService = new KhachhangService();
            _hoaDonSerevice = new HoaDonService();
            _chiTietHoaDonService = new ChiTietHoaDonService();
            _laptopService = new LaptopService();
            _nhaCungCapServices = new NhaCungCapServices();
        }

        private void GetNumberItems()
        {
            NumCustomers = _khachHangService.GetAllKhachHangs().Count;
            NumNhaCungCaps = _nhaCungCapServices.GetAllNhaCungCap().Count;
            NumProducts = _laptopService.GetAllLaptop().Count(c=>c.TrangThai == true);
            NumHoaDons = _hoaDonSerevice.GetAllHoaDonViews().Count(c => c.NgayTao >= _startDate && c.NgayTao <= _endDate);
        }
        private void AnalisysHoaDon()
        {

            DoanhThuByDaysList = new List<DoanhThuByDay>();
            TongDoanhThu = 0;
            TongLoiNhuan = 0;

            var hoaDonByDayList = new List<KeyValuePair<DateTime, decimal>>();
            var lst = (from a in _hoaDonSerevice.GetAllHoaDonViews()
                       where a.NgayTao >= _startDate && a.NgayTao <= _endDate
                       group a by a.NgayTao into g
                       select new
                       {
                           Ngay = g.Key,
                           DoanhThu = g.Sum(c => c.TongTien)
                       }).ToList();

            foreach (var a in lst)
            {
                hoaDonByDayList.Add(new KeyValuePair<DateTime, decimal>(a.Ngay, a.DoanhThu));
                TongDoanhThu += a.DoanhThu;
            }
            hoaDonByDayList = hoaDonByDayList.OrderBy(c=>c.Key).ToList();

            //Group by Hours
            if (_numberDay <= 1)
            {
                DoanhThuByDaysList = (from a in hoaDonByDayList
                                      group a by a.Key.ToString("hh tt") into hoaDon
                                      select new DoanhThuByDay
                                      {
                                          Date = hoaDon.Key,
                                          DoanhThu = hoaDon.Sum(c => c.Value)
                                      }).ToList();
            }
            //Group by day
            else if (_numberDay <= 30)
            {
                DoanhThuByDaysList = (from a in hoaDonByDayList
                                      group a by a.Key.ToString("dd MMMM") into hoaDon
                                      select new DoanhThuByDay
                                      {
                                          Date = hoaDon.Key,
                                          DoanhThu = hoaDon.Sum(c => c.Value)
                                      }).ToList();
            }
            //Group by Weeks
            else
            {
                DoanhThuByDaysList = (from a in hoaDonByDayList
                                      group a by CultureInfo.CurrentCulture.Calendar.GetWeekOfYear(a.Key, CalendarWeekRule.FirstDay, DayOfWeek.Monday) into hoaDon
                                      select new DoanhThuByDay
                                      {
                                          Date = "Week " + hoaDon.Key.ToString(),
                                          DoanhThu = hoaDon.Sum(c => c.Value)
                                      }).ToList();
            }
        }
        private void AnalisisSanPham()
        {
            TopProductList = new List<KeyValuePair<string, int>>();
            UnderStockList = new List<KeyValuePair<string, int>>();

            TopProductList = (from a in _chiTietHoaDonService.GetAllChiTietHoaDon()
                              group a by new { a.Hang, a.Dong, a.TenSanPham }
                into g
                              orderby g.Sum(c => c.SoLuong) descending
                              select new KeyValuePair<string, int>($"{g.Key.Hang} {g.Key.Dong} {g.Key.TenSanPham}", g.Sum(c => c.SoLuong))).Take(5).ToList();

            UnderStockList = (from a in _laptopService.GetAllLaptop()
                              where a.TrangThai == true && a.SoLuongTon < 3
                              select new KeyValuePair<string, int>($"{a.HangLaptop} {a.DongLaptop} {a.Ten}", a.SoLuongTon)).ToList();

        }

        private List<KeyValuePair<string, int>> UnderStock()
        {
            return UnderStockList;
        }


        public bool LoadData(DateTime startDate, DateTime endDate)
        {
            endDate = new DateTime(endDate.Year, endDate.Month, endDate.Day, endDate.Hour, endDate.Minute, 59);
            if (startDate != _startDate || endDate != _endDate)
            {
                _startDate = startDate;
                _endDate = endDate;
                _numberDay = (endDate - startDate).Days;

                GetNumberItems();
                AnalisysHoaDon();
                AnalisisSanPham();
                return true;
            }

            return false;
        }
    }
}
