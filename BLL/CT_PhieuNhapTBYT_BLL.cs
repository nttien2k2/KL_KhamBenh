using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class CT_PhieuNhapTBYT_BLL
    {
        CT_PhieuNhapTBYT_DAL CT_pnTBYT_dal = new CT_PhieuNhapTBYT_DAL();
        public bool insertCT_PhieuNhapTBYT(CT_PhieuNhapTBYT_DTO CT_pnTBYT)
        {
            return CT_pnTBYT_dal.insertCT_PhieuNhap(CT_pnTBYT);
        }
    }
}
