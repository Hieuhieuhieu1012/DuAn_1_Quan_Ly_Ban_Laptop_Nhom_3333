using _1_DAL_DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DAL_DataAccessLayer.IRepositories
{
    public interface IManHinhRepositories
    {
        bool AddManHinh(ManHinh manHinh);
        bool UpdateManHinh(ManHinh manHinh);
        bool DeleteManHinh(Guid idManHinh);
        ManHinh GetManHinhById(Guid idManHinh);
        List<ManHinh> GetAllManHinh();
    }
}
