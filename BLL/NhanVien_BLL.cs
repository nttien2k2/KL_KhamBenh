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
    public class NhanVien_BLL
    {
        NhanVien_DAL nv_dal = new NhanVien_DAL();
        Export_DAL export_dal = new Export_DAL();
        public DataTable getNhanVien()
        {
            return nv_dal.getNhanVien();
        }
        public DataTable getNV()
        {
            return nv_dal.getNV();
        }
        public NhanVien_DTO getNhanVienSDT(string sdt)
        {
            return nv_dal.getNhanVienSDT(sdt);
        }
        public DataTable loadCbb_ChucDanh()
        {
            return nv_dal.loadcbo_ChucDanh();
        }

        public bool insertNhanVien(NhanVien_DTO nv)
        {
            return nv_dal.insertNhanVien(nv);
        }
        public bool updateNhanVien(NhanVien_DTO nv)
        {
            return nv_dal.updateNhanVien(nv);
        }
        public bool deleteNhanVien(string sdt)
        {
            return nv_dal.deleteNhanVien(sdt);
        }
        public DataTable search(string search)
        {
            return nv_dal.search(search);
        }
        public int countNhanVien()
        {
            return nv_dal.countNhanVien();
        }
        public int countNhanVienBySearch(string search)
        {
            return nv_dal.countNhanVienBySearch(search);
        }
        public string getNhanVienBySDT(string sdt)
        {
            return nv_dal.getNhanVienBySDT(sdt);
        }
        public bool xoaTaiKhoanNhanVien(string sdt)
        {
            return nv_dal.XoaTaiKhoanNhanVien(sdt);

        }
        public bool insertNhomQuyen(string roleName)
        {
            return nv_dal.insertNhomQuyen(roleName);
        }
        public bool deleteNhomQuyen(string roleName)
        {
            return nv_dal.deleteNhomQuyen(roleName);
        }
        public bool doiMatKhau(NhanVien_DTO nv)
        {
            return nv_dal.doiMatKhau(nv);
        }
    }
}
