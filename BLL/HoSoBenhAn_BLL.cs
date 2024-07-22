using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;
using DTO;

namespace BLL
{
    public class HoSoBenhAn_BLL
    {
        HoSoBenhAn_DAL hsba_dal = new HoSoBenhAn_DAL();
        public DataTable getHoSoBenhAn1(int MaBN)
        {
            return hsba_dal.getHoSoBenhAn1(MaBN);
        }
        public bool insertHpSoBenhAn(HoSoBenhAn_DTO hsba)
        {
            return hsba_dal.insertHoSoBenhAn(hsba);
        }
        public bool updateHoSoBenhAn(HoSoBenhAn_DTO hsba)
        {
            return hsba_dal.updateHSBA(hsba);
        }
    }
}
