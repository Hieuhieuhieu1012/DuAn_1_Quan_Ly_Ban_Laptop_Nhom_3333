using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _2_BUS_BusinessLayer.ViewModel;

namespace _2_BUS_BusinessLayer.IServices
{
    public interface IHoaDonSerevice
    {
        public string AddHoaDon(HoaDonView obj);
        public string RemoveHoaDon(Guid id);
        public string UpdateHoaDon(HoaDonView obj);
        public string UpdateStatusHoaDon(Guid id);
        public List<HoaDonView> GetAllHoaDonViews();
        public string AutoGenerateMa();

        List<HoaDonView> GetHoaDonChoViews();

    }
}
