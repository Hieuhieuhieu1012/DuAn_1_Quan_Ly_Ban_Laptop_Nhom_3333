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
    public class KhachhangService: IKhachHangService
    {
        private KhachHangRepository _khachHangRepository;

        public KhachhangService()
        {
            _khachHangRepository= new KhachHangRepository();

        }

        public string AddKhachHang(KhachHang khachHang)
        {
            if (_khachHangRepository.AddKhachHang(khachHang))
            {
                return "Thêm thành công";
            }
            return "Thêm thất bại";
        }

        public string UpdateKhachHang(KhachHang khachHang)
        {
            if (_khachHangRepository.UpdateKhachHang(khachHang))
            {
                return "Sửa thành công";
            }
            return "Sửa thất bại";
        }

        public List<KhachHang> GetAllKhachHangs()
        {
            return _khachHangRepository.GetAllKhachHang();
        }

        public List<KhachHang> GetByKhachHangs(string msg)
        {
            var lst = _khachHangRepository.GetAllKhachHang().
                Where(c => c.SoDienThoai.ToLower().Contains(msg.ToLower()) ||
                               c.Hoten.ToLower().Contains(msg.ToLower())).ToList();
            return lst;
        }

        public KhachHang GetKhachHangById(Guid idKhachHang)
        {
            throw new NotImplementedException();
        }

    }
}
