using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DAL_DataAccessLayer.Models
{
    public class OCung
    {
        public Guid Id { get; set; }
        public string Ma { get; set; }
        public string Ten { get; set; }
        public string Loai { get; set; }
        public int DungLuong { get; set; }

        public ICollection<Laptop> Laptops { get; set; }

    }
}
