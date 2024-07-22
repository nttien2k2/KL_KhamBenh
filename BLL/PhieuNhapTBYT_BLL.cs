using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class PhieuNhapTBYT_BLL
    {
        PhieuNhapTBYT_DAL pnTBYT_dal = new PhieuNhapTBYT_DAL();
        public bool insertPhieuNhapTBYT(PhieuNhapTBYT_DTO pnTBYT)
        {
            return pnTBYT_dal.insertPhieuNhap(pnTBYT);
        }
        public int getMaPhieuNhap()
        {
            return pnTBYT_dal.getMaPhieuNhap();
        }
    }
}
