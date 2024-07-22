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
    public class LoaiTBYT_BLL
    {
        LoaiTBYT_DAL ltBYT_dal = new LoaiTBYT_DAL();
        public DataTable getLoaiTBYT()
        {
            return ltBYT_dal.getLoaiTBYT();
        }
        public bool insertLoaiTBYT(LoaiTBYT_DTO loaiTBYT)
        {
            return ltBYT_dal.insertLoaiTBYT(loaiTBYT);
        }
        public bool updateLoaiTBYT(LoaiTBYT_DTO loaiTBYT)
        {
            return ltBYT_dal.updateLoaiTBYT(loaiTBYT);
        }
        public bool deleteLoaiTBYT(int maLTBYT)
        {
            return ltBYT_dal.deleteLoaiTBYT(maLTBYT);
        }
    }
}
