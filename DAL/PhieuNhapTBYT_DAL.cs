using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class PhieuNhapTBYT_DAL :DbContext
    {
        private readonly DbContext conn = new DbContext();
        public int getMaPhieuNhap()
        {
            string query = "SELECT TOP 1 MaPhieuNhap FROM PhieuNhapThietBiYTe ORDER BY MaPhieuNhap DESC";
            SqlCommand cmd = new SqlCommand(query, Connect);
            int maPhieuNhap = (int)cmd.ExecuteScalar();
            return maPhieuNhap;
        }

        public bool insertPhieuNhap(PhieuNhapTBYT_DTO phieuNhap)
        {
            try
            {
                string query = "INSERT INTO PhieuNhapThietBiYTe (NgayNhap, TongGiaTri, MaNV) " +
                               "VALUES (@NgayNhap, @TongGiaTri, @MaNV)";
                SqlCommand cmd = new SqlCommand(query, Connect);

                cmd.Parameters.AddWithValue("@NgayNhap", phieuNhap.NgayNhap);
                cmd.Parameters.AddWithValue("@TongGiaTri", phieuNhap.TongGiaTri);
                cmd.Parameters.AddWithValue("@MaNV", phieuNhap.MaNV);

                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                conn.CloseConnect();
            }
            return false;
        }
    }
}
