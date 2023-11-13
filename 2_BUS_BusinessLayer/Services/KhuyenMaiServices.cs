using _1_DAL_DataAccessLayer.IRepositories;
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
    public class KhuyenMaiServices : IKhuyenMaiServices
    {
        IKhuyenMaiRepository _khuyenMaiRepository;
        public KhuyenMaiServices()
        {
            _khuyenMaiRepository = new KhuyenMaiRepository();
        }
        public string AddKhuyenMai(KhuyenMai khuyenMai)
        {
            if (_khuyenMaiRepository.AddKhuyenMai(khuyenMai))
            {
                return "Thêm thành công";
            }
            return "Thêm thất bại";
        }

        public string ChuyenTrangThai(KhuyenMai khuyenMai)
        {
            _khuyenMaiRepository.ChuyenTrangThai(khuyenMai);
            return "Thành công";
        }

        public List<KhuyenMai> GetAllKhuyenMai()
        {
            List<KhuyenMai> lstKhuyenMai = new List<KhuyenMai>();
            lstKhuyenMai = (from x in _khuyenMaiRepository.GetAllKhuyenMai()
                            select x).ToList();
            return lstKhuyenMai;

        }

        public KhuyenMai GetKhuyenMaiById(Guid idKhuyenMai)
        {
            throw new NotImplementedException();
        }

        public string UpdateKhuyenMai(KhuyenMai khuyenMai)
        {
            if (_khuyenMaiRepository.UpdateKhuyenMai(khuyenMai))
            {
                return "Sửa thành công";
            }
            return "Sửa thất bại";
        }
    }
}
