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
    public class LoaiThuoc_DAL : DbContext
    {
        private readonly DbContext conn = new DbContext();
        public DataTable getLoaiThuoc()
        {
            //conn.OpenConnect();
            string query = "SELECT * FROM LoaiThuoc";
            SqlDataAdapter da = new SqlDataAdapter(query,conn.Connect);
            DataTable dtLoaiThuoc = new DataTable();
            da.Fill(dtLoaiThuoc);
            return dtLoaiThuoc;
        }
        public bool insertLoaiThuoc(LoaiThuoc_DTO loaiThuoc)
        {
            try
            {
                //conn.OpenConnect();
                string query = "INSERT INTO LoaiThuoc (TenLoaiThuoc, MoTa) " +
                               "VALUES (@TenLoaiThuoc, @MoTa)";
                SqlCommand cmd = new SqlCommand(query, conn.Connect);

                cmd.Parameters.AddWithValue("@TenLoaiThuoc", loaiThuoc.TenLoaiThuoc);
                cmd.Parameters.AddWithValue("@MoTa", loaiThuoc.MoTa);

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
        public bool updateLoaiThuoc(LoaiThuoc_DTO loaiThuoc)
        {
            try
            {
                //conn.OpenConnect();
                string query = "UPDATE LoaiThuoc " +
                               "SET TenLoaiThuoc = @TenLoaiThuoc, " +
                                   "MoTa = @MoTa " +
                               "WHERE MaLoaiThuoc = @MaLoaiThuoc";
                SqlCommand cmd = new SqlCommand(query, conn.Connect);

                cmd.Parameters.AddWithValue("@MaLoaiThuoc", loaiThuoc.MaLoaiThuoc);
                cmd.Parameters.AddWithValue("@TenLoaiThuoc", loaiThuoc.TenLoaiThuoc);
                cmd.Parameters.AddWithValue("@MoTa", loaiThuoc.MoTa);

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
        public bool deleteLoaiThuoc(int maLoaiThuoc)
        {
            try
            {
                //conn.OpenConnect();
                string query = "DELETE FROM LoaiThuoc WHERE MaLoaiThuoc = @MaLoaiThuoc";
                SqlCommand cmd = new SqlCommand(query, conn.Connect);

                cmd.Parameters.AddWithValue("@MaLoaiThuoc", maLoaiThuoc);

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
