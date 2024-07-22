using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using BLL;


namespace Demo
{
    public partial class FrmPhanQuyen : Form
    {
        NhanVien_BLL nv_bll = new NhanVien_BLL();
        public FrmPhanQuyen()
        {
            InitializeComponent();
        }
        DbContext conn = new DbContext();
        private void PhanQuyen_Load(object sender, EventArgs e)
        {
            loadcboNhanVien();
            loadcbo_Bang();
            //loadcbo_Quyen();
            loadcbo_NhomQuyen();
            loadcbo_TaiKhoan();
        }
        public void loadcboNhanVien()
        {
            string query = "SELECT * FROM NhanVien";
            string tableName = "NhanVien";
            conn.getDataAdapter(query, tableName);

        }
        public void loadcbo_Bang()
        {
            string query = "SELECT TABLE_NAME FROM QL_KHAMBENH.INFORMATION_SCHEMA.TABLES WHERE TABLE_TYPE = 'BASE TABLE' ORDER BY\r\n  TABLE_NAME ASC";
            string tableName = "QL_KHAMBENH.INFORMATION_SCHEMA.TABLES";
            conn.getDataAdapter(query, tableName);

        }

        public void loadcbo_TaiKhoan()
        {
            string query = "select name from sys.sql_logins where default_database_name = 'QL_KHAMBENH'";
            string tableName = "sys.sql_logins";
            conn.getDataAdapter(query, tableName);
        }
        public void loadcbo_NhomQuyen()
        {
            //cbb_NhomQuyen.Items.Clear();
            string query = "SELECT name FROM sys.database_principals WHERE type = 'R' AND is_fixed_role = 0 AND name <> 'public'";
            string tableName = "sys.database_principals";
            conn.getDataAdapter(query, tableName);
            cbb_NhomQuyen.DataSource = conn.DSet.Tables[tableName];
            cbb_NhomQuyen.DisplayMember = "name";
            cbb_NhomQuyen.ValueMember = "name";
        }

        private void btn_CapQuyenUser_Click(object sender, EventArgs e)
        {
            //string quyen = cbb_Quyen.SelectedItem?.ToString().Trim();
            //string nhanvien = cbb_NhanVien.SelectedItem?.ToString().Trim();
            //string bang = cbb_Bang.SelectedItem?.ToString().Trim();
            //string tk = cbb_TaiKhoan.SelectedItem?.ToString().Trim();

            //if (string.IsNullOrEmpty(quyen) || string.IsNullOrEmpty(nhanvien) || string.IsNullOrEmpty(bang) || string.IsNullOrEmpty(tk))
            //{
            //    MessageBox.Show("Vui lòng chọn đầy đủ thông tin cần cấp quyền!");
            //    return;
            //}

            //try
            //{
            //    conn.OpenConnect();
            //    string query = string.Format("GRANT {0} ON {1} TO {2}", quyen, cbb_Bang.SelectedValue.ToString().Trim(), cbb_TaiKhoan.SelectedValue.ToString().Trim());
            //    SqlCommand cmd = new SqlCommand(query, conn.Connect);
            //    cmd.ExecuteNonQuery();
            //    conn.CloseConnect();
            //    MessageBox.Show("Cấp quyền thành công");
            //}
            //catch
            //{
            //    MessageBox.Show("Cấp quyền thất bại");
            //}
        }

        //Chưa xử lý trường hợp không có quyền thì sao ?
        private void btn_XoaQuyen_Click(object sender, EventArgs e)
        {
            //string quyen = cbb_Quyen.SelectedItem?.ToString().Trim();
            ////string nhanvien = cbb_NhanVien.SelectedItem?.ToString().Trim();
            //string bang = cbb_Bang.SelectedItem?.ToString().Trim();
            //string tk = cbb_TaiKhoan.SelectedItem?.ToString().Trim();
            //if (string.IsNullOrEmpty(quyen) || string.IsNullOrEmpty(bang) || string.IsNullOrEmpty(tk))
            //{
            //    MessageBox.Show("Vui lòng chọn đầy đủ thông tin cần thu hồi quyền!");
            //    return;
            //}
            //try
            //{
            //    conn.OpenConnect();
            //    string query = String.Format("deny {0}  ON {1} to {2}", quyen, cbb_Bang.SelectedValue.ToString().Trim(), cbb_TaiKhoan.SelectedValue.ToString().Trim());
            //    SqlCommand cmd = new SqlCommand(query, conn.Connect);
            //    cmd.ExecuteNonQuery();
            //    conn.CloseConnect();
            //    MessageBox.Show("Thu hồi quyền thành công");
            //}
            //catch
            //{
            //    MessageBox.Show("Thu hồi quyền Thất bại");
            //}
        }

        private void btn_XoaTaiKhoan_Click(object sender, EventArgs e)
        {
            //if(cbb_TaiKhoan.SelectedIndex == -1)
            //{
            //    MessageBox.Show("Vui lòng chọn tài khoản để xóa!", "Lỗi");
            //    return;
            //}    
            //string sdt = cbb_TaiKhoan.SelectedValue.ToString();
            //if(nv_bll.xoaTaiKhoanNhanVien(sdt))
            //{
            //    MessageBox.Show("Xóa tài khoản thành công!!","Thông báo");
            //}
            //else
            //{
            //    MessageBox.Show("Xóa tài khoản thất bại!!", "Thông báo");

            //}
        }

        private void toolStripBtn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void btn_ThemNhomQuyen_Click(object sender, EventArgs e)
        {
            //if(txt_NhomQuyen.Text == "")
            //{
            //    MessageBox.Show("Vui lòng nhập tên nhóm quyền muốn thêm!","Lỗi");
            //    return;
            //}    
            //string roleName = txt_NhomQuyen.Text;
            //if(nv_bll.insertNhomQuyen(roleName))
            //{
            //    MessageBox.Show("Thêm nhóm quyền thành công!!", "Thông báo");
            //    Refresh();
            //}
            //else
            //{
            //    MessageBox.Show("Thêm nhóm quyền thất bại!!", "Thông báo");

            //}
        }
        public void Refresh()
        {
            //txt_NhomQuyen.Clear();
            loadcboNhanVien();
            loadcbo_Bang();
            //loadcbo_Quyen();
            loadcbo_TaiKhoan();
        }

        private void btn_XoaNhomQuyen_Click(object sender, EventArgs e)
        {
            if (cbb_NhomQuyen.SelectedIndex <= -1)
            {
                MessageBox.Show("Vui lòng nhập tên nhóm quyền muốn xóa!", "Lỗi");
                return;
            }
            string roleName = cbb_NhomQuyen.SelectedValue.ToString();
            if (nv_bll.deleteNhomQuyen(roleName))
            {
                MessageBox.Show("Xóa nhóm quyền thành công!!", "Thông báo");
                Refresh();
            }
            else
            {
                MessageBox.Show("Xóa nhóm quyền thất bại!!", "Thông báo");

            }
        }

        private void toolStripBtn_Refresh_Click(object sender, EventArgs e)
        {
            Refresh();  
        }
    }
}
