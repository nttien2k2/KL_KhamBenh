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
    public class DichVu_DAL : DbContext
    {
        private readonly DbContext conn = new DbContext();

        public DataTable getDichVu()
        {
            string query = "select dv.MaDichVu, dv.TenDichVu, dv.Gia, ck.TenChuyenKhoa from DichVu dv join ChuyenKhoa ck on dv.MaChuyenKhoa = ck.MaChuyenKhoa";
            SqlDataAdapter da = new SqlDataAdapter(query, Connect);
            DataTable dtDichVu = new DataTable();
            da.Fill(dtDichVu);
            return dtDichVu;
        }
        public bool insertDichVu(DichVu_DTO dichVu)
        {
            try
            {
                //conn.OpenConnect();
                string query = "INSERT INTO DichVu (TenDichVu, Gia, MaChuyenKhoa) " +
                               "VALUES (@TenDichVu, @Gia, @MaChuyenKhoa)";
                SqlCommand cmd = new SqlCommand(query, conn.Connect);

                //cmd.Parameters.AddWithValue("@MaDichVu", dichVu.MaDichVu);
                cmd.Parameters.AddWithValue("@TenDichVu", dichVu.TenDichVu);
                cmd.Parameters.AddWithValue("@Gia", dichVu.Gia);
                cmd.Parameters.AddWithValue("@MaChuyenKhoa", dichVu.MaChuyenKhoa);

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
        public bool updateDichVu(DichVu_DTO dichVu)
        {
            try
            {
                //conn.OpenConnect();
                string query = "UPDATE DichVu " +
                               "SET TenDichVu = @TenDichVu, " +
                                   "Gia = @Gia, " +
                                   "MaChuyenKhoa = @MaChuyenKhoa " +
                               "WHERE MaDichVu = @MaDichVu";
                SqlCommand cmd = new SqlCommand(query, conn.Connect);

                cmd.Parameters.AddWithValue("@MaDichVu", dichVu.MaDichVu);
                cmd.Parameters.AddWithValue("@TenDichVu", dichVu.TenDichVu);
                cmd.Parameters.AddWithValue("@Gia", dichVu.Gia);
                cmd.Parameters.AddWithValue("@MaChuyenKhoa", dichVu.MaChuyenKhoa);

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

        public bool deleteDichVu(int maDichVu)
        {
            try
            {
                //conn.OpenConnect();
                string query = "DELETE FROM DichVu WHERE MaDichVu = @MaDichVu";
                SqlCommand cmd = new SqlCommand(query, conn.Connect);

                cmd.Parameters.AddWithValue("@MaDichVu", maDichVu);

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
        public DataTable getThongTinDichVu(int maKhamBenh)
        {
            string query = "SELECT kb.MaKhamBenh, bn.HoTenBN, dv.TenDichVu, dv.Gia, ctdv.KetQua, ctdv.ChiTiet, ctdv.NgayThucHien, llv.NgayBatDau AS NgayKham " +
                           "FROM KhamBenh kb " +
                           "JOIN BenhNhan bn ON kb.MaBN = bn.MaBN " +
                           "JOIN CT_DichVu ctdv ON kb.MaKhamBenh = ctdv.MaKhamBenh " +
                           "JOIN DichVu dv ON ctdv.MaDichVu = dv.MaDichVu " +
                           "JOIN LichLamViec llv ON kb.MaLichLamViec = llv.MaLichLamViec " +
                           "WHERE kb.MaKhamBenh = @MaKhamBenh";

            using (SqlCommand cmd = new SqlCommand(query, Connect))
            {
                cmd.Parameters.AddWithValue("@MaKhamBenh", maKhamBenh);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dtTTDichVu = new DataTable();
                da.Fill(dtTTDichVu);
                return dtTTDichVu;
            }
        }
        public int getMaDichByTenDichvu(string tenDichVu)
        {
            string query = "SELECT MaDichVu FROM DichVu WHERE TenDichVu = @TenDichVu";
            SqlCommand cmd = new SqlCommand(query, Connect);
            cmd.Parameters.AddWithValue("@TenDichVu", tenDichVu);

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
    }
}
