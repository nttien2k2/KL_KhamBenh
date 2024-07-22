using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace BLL
{
    public class Export_BLL
    {
        Export_DAL export_dal = new Export_DAL();
        //NhanVien_DAL nv_dal = new NhanVien_DAL();

        public void exportDSNhanVien(DataTable dataTable, string sheetName, string title)
        {
            export_dal.ExportDSNhanVien(dataTable,sheetName,title);
        }
    }
}
