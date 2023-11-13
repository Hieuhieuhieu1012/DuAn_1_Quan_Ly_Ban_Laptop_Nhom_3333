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
    public class SerialLaptopService : ISerialLaptopService
    {
        private ISerialLaptopRepository _serialLaptopRes;
        private ILapTopRepository _lapTopRepository;
        private IHangLapTopRepositories _hangLaptopRepositories;
        private IDongLapTopRepositories _dongLapTopRepositories;

        public SerialLaptopService()
        {
            _serialLaptopRes = new SerialLaptopRepository();
            _lapTopRepository = new LapTopRepository();
            _hangLaptopRepositories = new HangLaptopRepositories();
            _dongLapTopRepositories = new DongLapTopReposittoies();
        }

        public string UpdateStatusSerial(string seial)
        {
            if (_serialLaptopRes.UpdateStatusSerial(seial))
            {
                return "Thanh cong";
            }

            return "Khong thanh cong";
        }

        public string AddListSerial(List<SerialLaptop> list)
        {
            if (_serialLaptopRes.AddLstSerialLaptop(list))
            {
                return "Thanh cong";
            }

            return "That bai";
        }

        public string AddSerialLaptop(SerialLaptop obj)
        {
            SerialLaptop serialLaptop = new SerialLaptop()
            {
                Id = obj.Id,
                IdLaptop = obj.IdLaptop,
                Serial = obj.Serial,
                TrangThai = obj.TrangThai,
            };
            if (_serialLaptopRes.AddSerialLaptop(obj))
            {
                return "Thêm thành công";
            }
            return "Thêm thất bại";
        }

        public List<LaptopView> GetAllLaptopView()
        {
            List<LaptopView> list = new List<LaptopView>();
            list = (from sanPham in _lapTopRepository.GetAllLapTop()
                    join hangLaptop in _hangLaptopRepositories.GetAllHangLaptops() on sanPham.IdHangLaptop equals hangLaptop
                        .Id
                    join dongLaptop in _dongLapTopRepositories.GetAllDongLaptop() on sanPham.IdDongLaptop equals dongLaptop
                        .Id
                    select new LaptopView
                    {
                        Id = sanPham.Id,
                        IdHangLaptop = hangLaptop.Id,
                        IdDongLaptop = dongLaptop.Id,

                        Ten = sanPham.Ten,
                        HangLaptop = hangLaptop.Ten,
                        DongLaptop = dongLaptop.Ten,
                    }).ToList();
            return list;
        }

        public List<SerialLaptop> GetSerialLaptopList()
        {
            return _serialLaptopRes.GetLstSerialLaptopFromDb();
        }
    }
}
