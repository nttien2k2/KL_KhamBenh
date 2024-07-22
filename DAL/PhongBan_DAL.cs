using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class PhongBan_DAL : DbContext
    {
        private readonly DbContext conn = new DbContext();

        public DataTable getPhongBan()
        {
            string query = "SELECT * FROM PHONGBAN";
            SqlDataAdapter da = new SqlDataAdapter(query, Connect);
            DataTable dtPhongBan = new DataTable();
            da.Fill(dtPhongBan);
            return dtPhongBan;
        }
        public DataTable loadcbo_PhongBan()
        {
            string query = "SELECT * FROM PhongBan";
            SqlDataAdapter da = new SqlDataAdapter(query, Connect);
            DataTable dtPhongBan = new DataTable();
            da.Fill(dtPhongBan);
            return dtPhongBan;

        }
        public bool insertPhongBan(PhongBan_DTO phongBan)
        {
            try
            {
                //conn.OpenConnect();
                string query = "INSERT INTO PhongBan (TenPhongBan, VietTat, TrangThai) " +
                               "VALUES (@TenPhongBan, @VietTat, @TrangThai)";
                SqlCommand cmd = new SqlCommand(query, conn.Connect);

                //cmd.Parameters.AddWithValue("@MaPhongBan", phongBan.MaPhongBan);
                cmd.Parameters.AddWithValue("@TenPhongBan", phongBan.TenPhongBan);
                cmd.Parameters.AddWithValue("@VietTat", phongBan.VietTat);
                cmd.Parameters.AddWithValue("@TrangThai", phongBan.TrangThai);

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
        public bool updatePhongBan(PhongBan_DTO phongBan)
        {
            try
            {
                //conn.OpenConnect();
                string query = "UPDATE PhongBan " +
                               "SET TenPhongBan = @TenPhongBan, " +
                                   "VietTat = @VietTat, " +
                                   "TrangThai = @TrangThai " +
                               "WHERE MaPhongBan = @MaPhongBan";
                SqlCommand cmd = new SqlCommand(query, conn.Connect);

                cmd.Parameters.AddWithValue("@MaPhongBan", phongBan.MaPhongBan);
                cmd.Parameters.AddWithValue("@TenPhongBan", phongBan.TenPhongBan);
                cmd.Parameters.AddWithValue("@VietTat", phongBan.VietTat);
                cmd.Parameters.AddWithValue("@TrangThai", phongBan.TrangThai);

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
        public bool deletePhongBan(int maPhongBan)
        {
            try
            {
                //conn.OpenConnect();
                string query = "DELETE FROM PhongBan WHERE MaPhongBan = @MaPhongBan";
                SqlCommand cmd = new SqlCommand(query, conn.Connect);

                cmd.Parameters.AddWithValue("@MaPhongBan", maPhongBan);

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
