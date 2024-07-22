using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class CT_PhieuNhapTBYT_DAL :DbContext
    {
        private readonly DbContext conn = new DbContext();

        public bool insertCT_PhieuNhap(CT_PhieuNhapTBYT_DTO ctPhieuNhap)
        {
            try
            {
                string query = "INSERT INTO CT_PhieuNhap_TBYT (MaTBYT, MaPhieuNhap, SoLuong, DonGia) " +
                               "VALUES (@MaThuoc, @MaPhieuNhap, @SoLuong, @DonGia)";
                SqlCommand cmd = new SqlCommand(query, Connect);

                cmd.Parameters.AddWithValue("@MaThuoc", ctPhieuNhap.MaTBYT);
                cmd.Parameters.AddWithValue("@MaPhieuNhap", ctPhieuNhap.MaPhieuNhap);
                cmd.Parameters.AddWithValue("@SoLuong", ctPhieuNhap.SoLuong);
                cmd.Parameters.AddWithValue("@DonGia", ctPhieuNhap.DonGia);

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
