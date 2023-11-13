using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;
using _1_DAL_DataAccessLayer.Models;

namespace _1_DAL_DataAccessLayer.IRepositories
{
    public interface ISerialLaptopRepository
    {
        public bool AddSerialLaptop(SerialLaptop obj);
        public bool AddLstSerialLaptop(List<SerialLaptop> lst);
        public bool UpdateStatusSerial(string serial);
        public bool UpdateSerialLaptop(SerialLaptop obj);
        public bool DeleteSerialLaptop(Guid Id);
        public List<SerialLaptop> GetLstSerialLaptopFromDb();
    }
}
