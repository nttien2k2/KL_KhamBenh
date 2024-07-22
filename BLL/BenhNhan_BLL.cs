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
    public class BenhNhan_BLL
    {
        BenhNhan_DAL bn_dal = new BenhNhan_DAL();
        public DataTable getBenhNhan()
        {
            return bn_dal.getBenhNhan();
        }
        public bool insertBenhNhan(BenhNhan_DTO bn)
        {
            return bn_dal.insertBenhNhan(bn);
        }
        public bool updateNhanVien(BenhNhan_DTO bn)
        {
            return bn_dal.updateBenhNhan(bn);
        }
        public bool deleteNhanVien(int maBN)
        {
            return bn_dal.deleteBenhNhan(maBN);
        }
        public DataTable search(string search)
        {
            return bn_dal.search(search);
        }
    }
}
