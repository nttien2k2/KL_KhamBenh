using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class PhieuNhapThuoc_BLL
    {
        PhieuNhapThuoc_DAL pnThuoc_dal = new PhieuNhapThuoc_DAL();
        public bool insertPhieuNhapThuoc(PhieuNhapThuoc_DTO pnThuoc)
        {
            return pnThuoc_dal.insertPhieuNhap(pnThuoc);
        }
        public int getMaPhieuNhap()
        {
            return pnThuoc_dal.getMaPhieuNhap();
        }
    }
}
