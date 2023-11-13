using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _2_BUS_BusinessLayer.ViewModel;

namespace _2_BUS_BusinessLayer.IServices
{
    public interface IChiTietHoaDonService
    {
        public string AddChiTietHoaDon(ChiTietHoaDonView obj);
        public string RemoveChiTietHoaDon(Guid id);
        public string UpdateChiTietHoaDon(ChiTietHoaDonView obj);
        public string UpdateStatusChiTietHoaDon(Guid id);
        public List<ChiTietHoaDonView> GetAllChiTietHoaDon();
        public List<ChiTietHoaDonView> GetAllCTHĐ(Guid id);

    }
}
