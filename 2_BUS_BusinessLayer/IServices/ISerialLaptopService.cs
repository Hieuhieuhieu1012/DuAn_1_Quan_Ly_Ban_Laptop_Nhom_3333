using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1_DAL_DataAccessLayer.Models;
using _2_BUS_BusinessLayer.ViewModel;

namespace _2_BUS_BusinessLayer.IServices
{
    public interface ISerialLaptopService
    {
        public string UpdateStatusSerial(string seial);
        public string AddListSerial(List<SerialLaptop> list);
        public string AddSerialLaptop(SerialLaptop obj);
        public List<SerialLaptop> GetSerialLaptopList();
        public List<LaptopView> GetAllLaptopView();
    }
}
