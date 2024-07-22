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
    public class PhongBan_BLL
    {
        PhongBan_DAL pb_dal = new PhongBan_DAL();
        public DataTable getPhongBan()
        {
            return pb_dal.getPhongBan();
        }
        public DataTable loadCbb_PhongBan()
        {
            return pb_dal.loadcbo_PhongBan();
        }
        public bool insertPhongBan(PhongBan_DTO pb)
        {
            return pb_dal.insertPhongBan(pb);
        }
        public bool updatePhongBan(PhongBan_DTO pb)
        {
            return pb_dal.updatePhongBan(pb);
        }
        public bool deletePhongBan(int maPB)
        {
            return pb_dal.deletePhongBan(maPB);
        }
    }
}
