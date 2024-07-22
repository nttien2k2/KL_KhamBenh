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
    public class ChuyenKhoa_BLL
    {
        ChuyenKhoa_DAL ck_dal = new ChuyenKhoa_DAL();
        public DataTable getChuyenKhoa()
        {
            return ck_dal.getChuyenKhoa();
        }
        public bool insertChuyenKhoa(ChuyenKhoa_DTO ck)
        {
            return ck_dal.insertChuyenKhoa(ck);
        }
        public bool updateChuyenKhoa(ChuyenKhoa_DTO ck)
        {
            return ck_dal.updateChuyenKhoa(ck);
        }
        public bool deleteChuyenKhoa(int maCK)
        {
            return ck_dal.deleteChuyenKhoa(maCK);
        }
    }
}
