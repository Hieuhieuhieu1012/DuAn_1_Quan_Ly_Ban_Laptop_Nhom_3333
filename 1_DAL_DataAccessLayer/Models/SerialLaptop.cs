using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DAL_DataAccessLayer.Models
{
    public class SerialLaptop
    {
        public Guid Id { get; set; }
        public Guid IdLaptop{ get; set; }
        public string Serial { get; set; }
        public bool TrangThai{ get; set; }

        public Laptop? Laptop { get; set; }
    }
}
