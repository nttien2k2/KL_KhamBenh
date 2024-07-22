using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class HoSoBenhAn_DAL : DbContext
    {
        DbContext conn = new DbContext();
        public DataTable getHoSoBenhAn(int MaBN)
        {
            //conn.OpenConnect();
            string query = "SELECT hs.NgayKham, hs.ChanDoanBanDau, hs.DieuTri, hs.GhiChu, hs.LyDoKham, hs.KetQuaKham, hs " +
                   "FROM BenhNhan bn " +
                   "JOIN HoSoBenhAn hs ON bn.MaBN = hs.MaBN " +
                   "WHERE bn.MaBN = @MaBN";

            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand(query, Connect);
            cmd.Parameters.AddWithValue("@MaBN", MaBN);
            da.SelectCommand = cmd;

            DataTable dtHoSoBenhAn = new DataTable();
            da.Fill(dtHoSoBenhAn);
            conn.CloseConnect();
            return dtHoSoBenhAn;
        }
        public DataTable getHoSoBenhAn1(int MaBN)
        {
            // conn.OpenConnect(); // Uncomment this if you need to open the connection here.
            string query = "SELECT kb.MaKhamBenh, hs.NgayKham, hs.ChanDoanBanDau, hs.DieuTri, hs.GhiChu, hs.LyDoKham, hs.KetQuaKham " +
                  "FROM BenhNhan bn " +
                  "JOIN KhamBenh kb ON bn.MaBN = kb.MaBN " +
                  "JOIN HoSoBenhAn hs ON bn.MaBN = hs.MaBN " +
                  "WHERE bn.MaBN = @MaBN";

            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand(query, Connect);
            cmd.Parameters.AddWithValue("@MaBN", MaBN);
            da.SelectCommand = cmd;

            DataTable dtHoSoBenhAn = new DataTable();
            da.Fill(dtHoSoBenhAn);
            // conn.CloseConnect(); // Uncomment this if you need to close the connection here.
            return dtHoSoBenhAn;
        }


        public bool insertHoSoBenhAn(HoSoBenhAn_DTO hoSoBenhAn)
        {
            try
            {
                conn.OpenConnect();  // Mở kết nối đến cơ sở dữ liệu
                string query = "INSERT INTO HoSoBenhAn (MaBN, MaNV, NgayKham, ChanDoanBanDau, DieuTri, GhiChu, LyDoKham, KetQuaKham) " +
                               "VALUES (@MaBN, @MaNV, @NgayKham, @ChanDoanBanDau, @DieuTri, @GhiChu, @LyDoKham, @KetQuaKham)";
                SqlCommand cmd = new SqlCommand(query, conn.Connect);

                cmd.Parameters.AddWithValue("@MaBN", hoSoBenhAn.MaBN);
                cmd.Parameters.AddWithValue("@MaNV", hoSoBenhAn.MaNV);
                cmd.Parameters.AddWithValue("@NgayKham", hoSoBenhAn.NgayKham);
                cmd.Parameters.AddWithValue("@ChanDoanBanDau", hoSoBenhAn.ChanDoanBanDau);
                cmd.Parameters.AddWithValue("@DieuTri", hoSoBenhAn.DieuTri);
                cmd.Parameters.AddWithValue("@GhiChu", hoSoBenhAn.GhiChu);
                cmd.Parameters.AddWithValue("@LyDoKham", hoSoBenhAn.LyDoKham);
                cmd.Parameters.AddWithValue("@KetQuaKham", hoSoBenhAn.KetQuaKham);

                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                // Ghi lại lỗi hoặc xử lý lỗi nếu cần
            }
            finally
            {
                conn.CloseConnect();  // Đảm bảo kết nối được đóng lại
            }
            return false;
        }
        public bool updateHSBA(HoSoBenhAn_DTO hoSoBenhAn)
        {
            try
            {
                conn.OpenConnect();  // Mở kết nối đến cơ sở dữ liệu
                string query = "UPDATE HoSoBenhAn " +
                               "SET MaNV = @MaNV, NgayKham = @NgayKham, ChanDoanBanDau = @ChanDoanBanDau, DieuTri = @DieuTri, GhiChu = @GhiChu, LyDoKham = @LyDoKham, KetQuaKham = @KetQuaKham " +
                               "WHERE MaBN = @MaBN";
                SqlCommand cmd = new SqlCommand(query, conn.Connect);

                cmd.Parameters.AddWithValue("@MaBN", hoSoBenhAn.MaBN);
                cmd.Parameters.AddWithValue("@MaNV", hoSoBenhAn.MaNV);
                cmd.Parameters.AddWithValue("@NgayKham", hoSoBenhAn.NgayKham);
                cmd.Parameters.AddWithValue("@ChanDoanBanDau", hoSoBenhAn.ChanDoanBanDau);
                cmd.Parameters.AddWithValue("@DieuTri", hoSoBenhAn.DieuTri);
                cmd.Parameters.AddWithValue("@GhiChu", hoSoBenhAn.GhiChu);
                cmd.Parameters.AddWithValue("@LyDoKham", hoSoBenhAn.LyDoKham);
                cmd.Parameters.AddWithValue("@KetQuaKham", hoSoBenhAn.KetQuaKham);

                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error updating HoSoBenhAn: " + ex.Message);

            }
            finally
            {
                conn.CloseConnect();  // Đảm bảo kết nối được đóng lại
            }
            return false;
        }


    }
}
