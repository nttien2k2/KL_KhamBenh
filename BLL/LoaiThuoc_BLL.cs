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
    public class LoaiThuoc_BLL
    {
        LoaiThuoc_DAL lt_dal = new LoaiThuoc_DAL();
        public DataTable getLoaiThuoc()
        {
            return lt_dal.getLoaiThuoc();
        }
        public bool insertLoaiThuoc(LoaiThuoc_DTO loaiThuoc)
        {
            return lt_dal.insertLoaiThuoc(loaiThuoc);
        }
        public bool updateLoaiThuoc(LoaiThuoc_DTO loaiThuoc)
        {
            return lt_dal.updateLoaiThuoc(loaiThuoc);
        }
        public bool deleteLoaiThuoc(int maLT)
        {
            return lt_dal.deleteLoaiThuoc(maLT);
        }
    }
}
