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
    public class LoaiTBYT_DAL : DbContext
    {
        private readonly DbContext conn = new DbContext();
        public DataTable getLoaiTBYT()
        {
            //conn.OpenConnect();
            string query = "SELECT * FROM LoaiTBYT";
            SqlDataAdapter da = new SqlDataAdapter(query, Connect);
            DataTable dtLoaiTBYT = new DataTable();
            da.Fill(dtLoaiTBYT);
            return dtLoaiTBYT;
        }
        public bool insertLoaiTBYT(LoaiTBYT_DTO loaiTBYT)
        {
            try
            {
                //conn.OpenConnect();
                string query = "INSERT INTO LoaiTBYT (TenLoaiTBYT, MoTa) " +
                               "VALUES (@TenLoaiTBYT, @MoTa)";
                SqlCommand cmd = new SqlCommand(query, conn.Connect);

                cmd.Parameters.AddWithValue("@TenLoaiTBYT", loaiTBYT.TenLoaiTBYT);
                cmd.Parameters.AddWithValue("@MoTa", loaiTBYT.MoTa);

                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                // Log the exception
            }
            finally
            {
                conn.CloseConnect();
            }
            return false;
        }
        public bool updateLoaiTBYT(LoaiTBYT_DTO loaiTBYT)
        {
            try
            {
                //conn.OpenConnect();
                string query = "UPDATE LoaiTBYT " +
                               "SET TenLoaiTBYT = @TenLoaiTBYT, " +
                                   "MoTa = @MoTa " +
                               "WHERE MaLoaiTBYT = @MaLoaiTBYT";
                SqlCommand cmd = new SqlCommand(query, conn.Connect);

                cmd.Parameters.AddWithValue("@MaLoaiTBYT", loaiTBYT.MaLoaiTBYT);
                cmd.Parameters.AddWithValue("@TenLoaiTBYT", loaiTBYT.TenLoaiTBYT);
                cmd.Parameters.AddWithValue("@MoTa", loaiTBYT.MoTa);

                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                // Log the exception
            }
            finally
            {
                conn.CloseConnect();
            }
            return false;
        }
        public bool deleteLoaiTBYT(int maLoaiTBYT)
        {
            try
            {
                //conn.OpenConnect();
                string query = "DELETE FROM LoaiTBYT WHERE MaLoaiTBYT = @MaLoaiTBYT";
                SqlCommand cmd = new SqlCommand(query, conn.Connect);

                cmd.Parameters.AddWithValue("@MaLoaiTBYT", maLoaiTBYT);

                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                // Log the exception
            }
            finally
            {
                conn.CloseConnect();
            }
            return false;
        }

    }
}
