using _1_DAL_DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_BUS_BusinessLayer.IServices
{
    public  interface INhanVienService
    {
        public string AddNhanVien(NhanVien nhanVien);
        public string UpdateNhanVien(Guid idNhanVien, NhanVien nhanVien);
        public bool UpdateNV( NhanVien nhanVien);
        public string  DoiTrangThai(List<NhanVien> lstNhanVien);
        NhanVien GetNhanVienById(Guid idNhanVien);
        List<NhanVien> GetAllNhanViens();

    }
}
