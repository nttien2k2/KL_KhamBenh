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
    public class ThietBYT_DAL : DbContext
    {
        private readonly DbContext conn = new DbContext();

        public DataTable getTBYT()
        {
            string query = "SELECT * FROM ThietBiYT";
            SqlDataAdapter da = new SqlDataAdapter(query, Connect);
            DataTable dtTBYT = new DataTable();
            da.Fill(dtTBYT);
            return dtTBYT;
        }
        public DataTable getTBYTByLoai(int maLoaiTBYT)
        {
            //conn.OpenConnect();
            string query = @"select * from ThietBiYT 
                                where MaLoaiTBYT = @MaLoaiTBYT";
            SqlDataAdapter da = new SqlDataAdapter(query, Connect);
            da.SelectCommand.Parameters.AddWithValue("@MaLoaiTBYT", maLoaiTBYT);
            DataTable dtTBYT = new DataTable();
            da.Fill(dtTBYT);
            return dtTBYT;
        }
        public int getMaTBYTByTenTBYT(string tenTBYT)
        {
            string query = "SELECT MaTBYT FROM ThietBiYT WHERE TenTBYT = @TenTBYT";
            SqlCommand cmd = new SqlCommand(query, Connect);
            cmd.Parameters.AddWithValue("@TenTBYT", tenTBYT);

            object result = cmd.ExecuteScalar();
            if (result != null && result != DBNull.Value)
            {
                return Convert.ToInt32(result);
            }
            else
            {
                // Xử lý trường hợp không tìm thấy mã thuốc
                return -1; // hoặc trả về giá trị mặc định khác
            }
        }
        public bool insertTBYT(ThietBiYT_Dto tb)
        {
            try
            {
                //conn.OpenConnect();
                string query = "INSERT INTO ThietBiYT (TenTBYT, SoLuong, MaLoaiTBYT) " +
                               "VALUES (@TenTBYT, @SoLuong, @MaLoaiTBYT)";
                SqlCommand cmd = new SqlCommand(query, conn.Connect);

                cmd.Parameters.AddWithValue("@TenTBYT", tb.TenTBYT);
                cmd.Parameters.AddWithValue("@SoLuong", tb.SoLuong);
                cmd.Parameters.AddWithValue("@MaLoaiTBYT", tb.MaLoaiTBYT);

                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                // Log the exception or handle it
            }
            finally
            {
                conn.CloseConnect();
            }
            return false;
        }
        public bool updateTBYT(ThietBiYT_Dto tb)
        {
            try
            {
                //conn.OpenConnect();
                string query = "UPDATE TBYT " +
                               "SET TenTBYT = @TenTBYT, " +
                                   "SoLuong = @SoLuong, " +
                                   "MaLoaiTBYT = @MaLoaiTBYT " +
                               "WHERE MaTBYT = @MaTBYT";
                SqlCommand cmd = new SqlCommand(query, conn.Connect);

                cmd.Parameters.AddWithValue("@MaTBYT", tb.MaTBYT);
                cmd.Parameters.AddWithValue("@TenTBYT", tb.TenTBYT);
                cmd.Parameters.AddWithValue("@SoLuong", tb.SoLuong);
                cmd.Parameters.AddWithValue("@MaLoaiTBYT", tb.MaLoaiTBYT);

                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                // Log the exception or handle it
            }
            finally
            {
                conn.CloseConnect();
            }
            return false;
        }
        public bool deleteTBYT(int maTBYT)
        {
            try
            {
                //conn.OpenConnect();
                string query = "DELETE FROM TBYT WHERE MaTBYT = @MaTBYT";
                SqlCommand cmd = new SqlCommand(query, conn.Connect);

                cmd.Parameters.AddWithValue("@MaTBYT", maTBYT);

                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                // Log the exception or handle it
            }
            finally
            {
                conn.CloseConnect();
            }
            return false;
        }
        public DataTable getKho()
        {
            try
            {
                //conn.Open();
                string query = @"
                SELECT 
                    T.MaTBYT,
                    T.TenTBYT,
                    T.DonGia,
                    T.DonViTinh,
                    ISNULL(SUM(CT.SoLuong), 0) AS TongSoLuong
                FROM 
                    ThietBiYT T
                LEFT JOIN 
                    CT_PhieuNhap_TBYT CT ON T.MaTBYT = CT.MaTBYT
                GROUP BY 
                    T.MaTBYT, T.TenTBYT, T.DonGia,
                    T.DonViTinh";

                SqlCommand cmd = new SqlCommand(query, Connect);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                // Xử lý lỗi nếu cần
                throw new Exception("Lỗi khi truy vấn dữ liệu kho TBYT: " + ex.Message);
            }
            finally
            {
                conn.CloseConnect();
            }
        }
    }
}
