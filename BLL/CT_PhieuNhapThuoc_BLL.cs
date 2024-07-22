using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class CT_PhieuNhapThuoc_BLL
    {
        CT_PhieuNhapThuoc_DAL CT_pnThuoc_dal = new CT_PhieuNhapThuoc_DAL();
        public bool insertCT_PhieuNhapThuoc(CT_PhieuNhapThuoc_DTO CT_pnThuoc)
        {
            return CT_pnThuoc_dal.insertCT_PhieuNhap(CT_pnThuoc);
        }
    }
}
