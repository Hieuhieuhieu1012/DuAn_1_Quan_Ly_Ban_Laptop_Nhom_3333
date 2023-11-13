using _1_DAL_DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_BUS_BusinessLayer.IServices
{
    public interface IManHinhServices
    {
        string AddManHinh(ManHinh manHinh);
        string UpdateManHinh(ManHinh manHinh);
        string DeleteManHinh(Guid idManHinh);
        //ManHinh GetManHinhById(Guid idManHinh);
        List<ManHinh> GetAllManHinh();
    }
}
