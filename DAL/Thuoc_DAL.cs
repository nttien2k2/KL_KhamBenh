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
    public class Thuoc_DAL : DbContext
    {
        private readonly DbContext conn = new DbContext();
        public DataTable getThuoc()
        {
            //conn.OpenConnect();
            string query = @"SELECT 
                                Thuoc.MaThuoc,
                                Thuoc.TenThuoc,
                                Thuoc.DonGia,
                                Thuoc.DangGiaBan,
                                Thuoc.HamLuong,
                                Thuoc.DonViTinh,
                                Thuoc.TacDungPhu,
                                Thuoc.NhaSanXuat,
                                Thuoc.NuocSanXuat,
                                Thuoc.HinhAnh,
                                Thuoc.SoLuong,
                                Thuoc.TacDung,
                                Thuoc.NgayApDungDonGia,
                                Thuoc.Lo,
                                Thuoc.BietDuoc,
                                LoaiThuoc.TenLoaiThuoc,
                                LoaiThuoc.MoTa
                            FROM Thuoc
                            LEFT JOIN LoaiThuoc ON Thuoc.MaLoaiThuoc = LoaiThuoc.MaLoaiThuoc";
            SqlDataAdapter da = new SqlDataAdapter(query, Connect);
            DataTable dtThuoc = new DataTable();
            da.Fill(dtThuoc);
            return dtThuoc;
        }
        public DataTable getThuocByLoai(int maLoaiThuoc)
        {
            //conn.OpenConnect();
            string query = @"select * from Thuoc 
                                where MaLoaiThuoc = @MaLoaiThuoc";
            SqlDataAdapter da = new SqlDataAdapter(query, Connect);
            da.SelectCommand.Parameters.AddWithValue("@MaLoaiThuoc", maLoaiThuoc);
            DataTable dtThuoc = new DataTable();
            da.Fill(dtThuoc);
            return dtThuoc;
        }
        public int getMaThuocByTenThuoc(string tenThuoc)
        {
            string query = "SELECT MaThuoc FROM Thuoc WHERE TenThuoc = @TenThuoc";
            SqlCommand cmd = new SqlCommand(query, Connect);
            cmd.Parameters.AddWithValue("@TenThuoc", tenThuoc);

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
        public DataTable getKho()
        {
            try
            {
                //conn.Open();
                string query = @"
                SELECT 
                    T.MaThuoc,
                    T.TenThuoc,
                    T.DonGiaBan,
                    T.DonViTinh,
                    ISNULL(SUM(CT.SoLuong), 0) AS TongSoLuong
                FROM 
                    Thuoc T
                LEFT JOIN 
                    CT_PhieuNhapThuoc CT ON T.MaThuoc = CT.MaThuoc
                GROUP BY 
                    T.MaThuoc, T.TenThuoc, T.DonGiaBan,
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
                throw new Exception("Lỗi khi truy vấn dữ liệu kho thuốc: " + ex.Message);
            }
            finally
            {
                conn.CloseConnect();
            }
        }
        //Thêm thuốc
        public bool insertThuoc(Thuoc_DTO thuoc)
        {
            try
            {
                //conn.OpenConnect();
                string query = "INSERT INTO Thuoc (TenThuoc, DonGia, DangGiaBan, HamLuong, DonViTinh, TacDungPhu, NhaSanXuat, NuocSanXuat, HinhAnh, SoLuong, TacDung, NgayApDungDonGia, Lo, BietDuoc, MaLoaiThuoc) " +
                               "VALUES (@TenThuoc, @DonGia, @DangGiaBan, @HamLuong, @DonViTinh, @TacDungPhu, @NhaSanXuat, @NuocSanXuat, @HinhAnh, @SoLuong, @TacDung, @NgayApDungDonGia, @Lo, @BietDuoc, @MaLoaiThuoc)";
                SqlCommand cmd = new SqlCommand(query, Connect);

                cmd.Parameters.AddWithValue("@TenThuoc", thuoc.TenThuoc);
                cmd.Parameters.AddWithValue("@DonGia", thuoc.DonGia);
                cmd.Parameters.AddWithValue("@DangGiaBan", thuoc.DangGiaBan);
                cmd.Parameters.AddWithValue("@HamLuong", thuoc.HamLuong);
                cmd.Parameters.AddWithValue("@DonViTinh", thuoc.DonViTinh);
                cmd.Parameters.AddWithValue("@TacDungPhu", thuoc.TacDungPhu);
                cmd.Parameters.AddWithValue("@NhaSanXuat", thuoc.NhaSanXuat);
                cmd.Parameters.AddWithValue("@NuocSanXuat", thuoc.NuocSanXuat);
                //cmd.Parameters.AddWithValue("@HinhAnh", thuoc.HinhAnh);
                cmd.Parameters.AddWithValue("@HinhAnh", "thuoc.jpg");
                cmd.Parameters.AddWithValue("@SoLuong", thuoc.SoLuong);
                cmd.Parameters.AddWithValue("@TacDung", thuoc.TacDung);
                cmd.Parameters.AddWithValue("@NgayApDungDonGia", thuoc.NgayApDungDonGia);
                cmd.Parameters.AddWithValue("@Lo", thuoc.Lo);
                cmd.Parameters.AddWithValue("@BietDuoc", thuoc.BietDuoc);
                cmd.Parameters.AddWithValue("@MaLoaiThuoc", thuoc.MaLoaiThuoc);

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
        //
        //Cập nhật thuốc
        public bool updateThuoc(Thuoc_DTO thuoc)
        {
            try
            {
                //conn.OpenConnect();
                string query = "UPDATE Thuoc " +
                               "SET TenThuoc = @TenThuoc, " +
                               "DonGia = @DonGia, " +
                               "DangGiaBan = @DangGiaBan, " +
                               "HamLuong = @HamLuong, " +
                               "DonViTinh = @DonViTinh, " +
                               "TacDungPhu = @TacDungPhu, " +
                               "NhaSanXuat = @NhaSanXuat, " +
                               "NuocSanXuat = @NuocSanXuat, " +
                               "HinhAnh = @HinhAnh, " +
                               "SoLuong = @SoLuong, " +
                               "TacDung = @TacDung, " +
                               "NgayApDungDonGia = @NgayApDungDonGia, " +
                               "Lo = @Lo, " +
                               "BietDuoc = @BietDuoc, " +
                               "MaLoaiThuoc = @MaLoaiThuoc " +
                               "WHERE MaThuoc = @MaThuoc";
                SqlCommand cmd = new SqlCommand(query, Connect);

                cmd.Parameters.AddWithValue("@MaThuoc", thuoc.MaThuoc);
                cmd.Parameters.AddWithValue("@TenThuoc", thuoc.TenThuoc);
                cmd.Parameters.AddWithValue("@DonGia", thuoc.DonGia);
                cmd.Parameters.AddWithValue("@DangGiaBan", thuoc.DangGiaBan);
                cmd.Parameters.AddWithValue("@HamLuong", thuoc.HamLuong);
                cmd.Parameters.AddWithValue("@DonViTinh", thuoc.DonViTinh);
                cmd.Parameters.AddWithValue("@TacDungPhu", thuoc.TacDungPhu);
                cmd.Parameters.AddWithValue("@NhaSanXuat", thuoc.NhaSanXuat);
                cmd.Parameters.AddWithValue("@NuocSanXuat", thuoc.NuocSanXuat);
                cmd.Parameters.AddWithValue("@HinhAnh", thuoc.HinhAnh);
                cmd.Parameters.AddWithValue("@SoLuong", thuoc.SoLuong);
                cmd.Parameters.AddWithValue("@TacDung", thuoc.TacDung);
                cmd.Parameters.AddWithValue("@NgayApDungDonGia", thuoc.NgayApDungDonGia);
                cmd.Parameters.AddWithValue("@Lo", thuoc.Lo);
                cmd.Parameters.AddWithValue("@BietDuoc", thuoc.BietDuoc);
                cmd.Parameters.AddWithValue("@MaLoaiThuoc", thuoc.MaLoaiThuoc);

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
        //
        //Xóa thuốc
        public bool deleteThuoc(int maThuoc)
        {
            try
            {
                //conn.OpenConnect();
                string query = "DELETE FROM Thuoc WHERE MaThuoc = @MaThuoc";
                SqlCommand cmd = new SqlCommand(query, Connect);
                cmd.Parameters.AddWithValue("@MaThuoc", maThuoc);

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
        //
    }
}
