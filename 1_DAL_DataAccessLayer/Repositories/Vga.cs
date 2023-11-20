using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1_DAL_DataAccessLayer.Models;

namespace _1_DAL_DataAccessLayer.Repositories
{
    public class Vga
    {
        public Guid Id { get; set; }
        public string Ma { get; set; }
        public string Ten { get; set; }

        public ICollection<Laptop> Laptops { get; set; }
    }
}
