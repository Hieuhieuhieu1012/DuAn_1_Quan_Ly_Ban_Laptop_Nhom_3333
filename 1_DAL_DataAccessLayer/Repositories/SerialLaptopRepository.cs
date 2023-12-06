using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1_DAL_DataAccessLayer.Context;
using _1_DAL_DataAccessLayer.IRepositories;
using _1_DAL_DataAccessLayer.Models;

namespace _1_DAL_DataAccessLayer.Repositories
{
    public class SerialLaptopRepository : ISerialLaptopRepository
    {
        private QlBanLaptopContext _context;

        public SerialLaptopRepository()
        {
            _context = new QlBanLaptopContext();
        }
        public bool AddSerialLaptop(SerialLaptop obj)
        {
            try
            {
                obj.Id = Guid.NewGuid();
                _context.SerialLaptop.Add(obj);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }

        public bool AddLstSerialLaptop(List<SerialLaptop> lst)
        {
            try
            {
                foreach (var serial in lst)
                {
                    serial.Id = Guid.NewGuid();
                }

                _context.AddRange(lst);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool UpdateStatusSerial(string serial)
        {
            try
            {
                var serialLaptop = _context.SerialLaptop.FirstOrDefault(x => x.Serial == serial);
                if (serialLaptop != null)
                {
                    if (serialLaptop.TrangThai)
                    {
                        serialLaptop.TrangThai = false;
                        _context.SerialLaptop.Update(serialLaptop);
                        _context.SaveChanges();
                        return true;
                    }

                    serialLaptop.TrangThai = true;
                    _context.SerialLaptop.Update(serialLaptop);
                    _context.SaveChanges();
                    return true;
                }

                return false;
            }
            catch (Exception )
            {
                return false;
            }
        }

        public bool UpdateSerialLaptop(SerialLaptop obj)
        {
            try
            {
                var serial = _context.SerialLaptop.FirstOrDefault(c => c.Id == obj.Id);
                serial.Serial = obj.Serial;
                _context.SerialLaptop.Update(serial);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool DeleteSerialLaptop(Guid Id)
        {
            try
            {
                var serial = _context.SerialLaptop.FirstOrDefault(c => c.Id == Id);
                _context.Remove(serial);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public IQueryable<SerialLaptop> GetLstSerialLaptopFromDb()
        {
            return _context.SerialLaptop.AsQueryable();
        }
    }
}
