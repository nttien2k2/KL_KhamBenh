using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ChuyenKhoa_DAL : DbContext
    {
        private readonly DbContext conn = new DbContext();
        public DataTable getChuyenKhoa()
        {
            string query = "SELECT * FROM ChuyenKhoa";
            SqlDataAdapter da = new SqlDataAdapter(query, Connect);
            DataTable dtChuyenKhoa = new DataTable();
            da.Fill(dtChuyenKhoa);
            return dtChuyenKhoa;
        }
        public bool insertChuyenKhoa(ChuyenKhoa_DTO ck)
        {
            try
            {
                //conn.OpenConnect();
                string query = "INSERT INTO ChuyenKhoa (TenChuyenKhoa, VietTat) " +
                               "VALUES (@TenChuyenKhoa, @VietTat)";
                SqlCommand cmd = new SqlCommand(query, conn.Connect);
                cmd.Parameters.AddWithValue("@TenChuyenKhoa", ck.TenChuyenKhoa);
                cmd.Parameters.AddWithValue("@VietTat", ck.VietTat);

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
        public bool updateChuyenKhoa(ChuyenKhoa_DTO ck)
        {
            try
            {
                //conn.OpenConnect();
                string query = "UPDATE ChuyenKhoa " +
                               "SET TenChuyenKhoa = @TenChuyenKhoa, " +
                                   "VietTat = @VietTat " +
                               "WHERE MaChuyenKhoa = @MaChuyenKhoa";
                SqlCommand cmd = new SqlCommand(query, conn.Connect);

                cmd.Parameters.AddWithValue("@MaChuyenKhoa", ck.MaChuyenKhoa);
                cmd.Parameters.AddWithValue("@TenChuyenKhoa", ck.TenChuyenKhoa);
                cmd.Parameters.AddWithValue("@VietTat", ck.VietTat);

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
        public bool deleteChuyenKhoa(int maChuyenKhoa)
        {
            try
            {
                //conn.OpenConnect();
                string query = "DELETE FROM ChuyenKhoa WHERE MaChuyenKhoa = @MaChuyenKhoa";
                SqlCommand cmd = new SqlCommand(query, conn.Connect);

                cmd.Parameters.AddWithValue("@MaChuyenKhoa", maChuyenKhoa);

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
