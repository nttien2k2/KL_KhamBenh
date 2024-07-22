using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class DichVu_BLL
    {
        DichVu_DAL dv_dal = new DichVu_DAL();
        public DataTable getDichVu()
        {
            return dv_dal.getDichVu();
        }
        public int getDichVuByTen(string tenDV)
        {
            return dv_dal.getMaDichByTenDichvu(tenDV);
        }
        public DataTable getTTDichVu(int maKhamBenh)
        {
            return dv_dal.getThongTinDichVu(maKhamBenh);
        }
        public bool insertDichVu(DichVu_DTO dv)
        {
            return dv_dal.insertDichVu(dv);
        }
        public bool updateDichVu(DichVu_DTO dv)
        {
            return dv_dal.updateDichVu(dv);
        }
        public bool deleteDichVu(int maDV)
        {
            return dv_dal.deleteDichVu(maDV);
        }


    }
}
