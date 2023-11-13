using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DAL_DataAccessLayer.Models
{
    public class DongLaptop
    {
        public Guid Id { get; set; }
        public string Ma { get; set; }
        public string Ten { get; set; }

        public Guid IdHangLaptop { get; set; }
        public HangLaptop? HangLaptop { get; set; }

        public ICollection<Laptop> Laptops { get; set; }

    }
}
