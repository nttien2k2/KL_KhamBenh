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
    public class BenhNhan_DAL : DbContext
    {
        private readonly DbContext conn;
        public DataTable getBenhNhan()
        {
            string query = "SELECT * FROM BenhNhan";
            SqlDataAdapter da = new SqlDataAdapter(query, Connect);
            DataTable dtPatients = new DataTable();
            da.Fill(dtPatients);
            return dtPatients;
        }
        public bool insertBenhNhan(BenhNhan_DTO benhnhan)
        {
            try
            {
                //conn.OpenConnect();
                string query = "INSERT INTO BenhNhan (HoTen, SDT, DiaChi, Email, NgaySinh, AnhDaiDien, GioiTinh) " +
                               "VALUES (@HoTen, @SDT, @DiaChi, @Email, @NgaySinh, @AnhDaiDien, @GioiTinh)";
                SqlCommand cmd = new SqlCommand(query, conn.Connect);

                cmd.Parameters.AddWithValue("@HoTen", benhnhan.HoTenBN);
                cmd.Parameters.AddWithValue("@SDT", benhnhan.SDT);
                cmd.Parameters.AddWithValue("@DiaChi", benhnhan.DiaChi);
                cmd.Parameters.AddWithValue("@Email", benhnhan.Email);
                cmd.Parameters.AddWithValue("@NgaySinh", benhnhan.NgaySinh);
                cmd.Parameters.AddWithValue("@AnhDaiDien", "patient_image.png");
                cmd.Parameters.AddWithValue("@GioiTinh", benhnhan.GioiTinh);

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

        public bool updateBenhNhan(BenhNhan_DTO benhnhan)
        {
            try
            {
                //conn.OpenConnect();
                string query = "UPDATE BenhNhan SET " +
                               "HoTenBN = @HoTenBN, " +
                               "SDT = @SDT, " +
                               "DiaChi = @DiaChi, " +
                               "Email = @Email, " +
                               "NgaySinh = @NgaySinh, " +
                               "AnhDaiDien = @AnhDaiDien, " +
                               "GioiTinh = @GioiTinh " +
                               "WHERE MaBN = @MaBN";
                SqlCommand cmd = new SqlCommand(query, conn.Connect);

                cmd.Parameters.AddWithValue("@MaBN", benhnhan.MaBN);
                cmd.Parameters.AddWithValue("@HoTenBN", benhnhan.HoTenBN);
                cmd.Parameters.AddWithValue("@SDT", benhnhan.SDT);
                cmd.Parameters.AddWithValue("@DiaChi", benhnhan.DiaChi);
                cmd.Parameters.AddWithValue("@Email", benhnhan.Email);
                cmd.Parameters.AddWithValue("@NgaySinh", benhnhan.NgaySinh);
                cmd.Parameters.AddWithValue("@AnhDaiDien", "patient_image_updated.png");
                cmd.Parameters.AddWithValue("@GioiTinh", benhnhan.GioiTinh);

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

        public bool deleteBenhNhan(int maBN)
        {
            try
            {
                //conn.OpenConnect();
                string query = "DELETE FROM BenhNhan WHERE MaBN = @MaBN";
                SqlCommand cmd = new SqlCommand(query, conn.Connect);

                cmd.Parameters.AddWithValue("@MaBN", maBN);

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

        public DataTable search(string search)
        {
            string query = "SELECT * FROM BENHNHAN WHERE SDT LIKE @SDT";
            SqlDataAdapter da = new SqlDataAdapter(query, Connect);
            da.SelectCommand.Parameters.AddWithValue("@SDT", "%" + search + "%");
            DataTable dtBenhNhan = new DataTable();
            da.Fill(dtBenhNhan);
            return dtBenhNhan;
        }

    }
}
