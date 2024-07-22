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
using MaterialSkin;
using MaterialSkin.Controls;
using DAL;
using DTO;

namespace Demo
{
    public partial class FrmLogin : MaterialForm
    {
        public FrmLogin()
        {
            InitializeComponent();
            //this.StartPosition = FormStartPosition.CenterScreen;
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.LightBlue300, Primary.LightBlue500, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }
        DbContext conn = new DbContext();

        private void btn_DangNhap_Click(object sender, EventArgs e)
        {
            NhanVien_DTO nv = new NhanVien_DTO();
            nv.SDT = txt_TaiKhoan.Text;
            nv.MatKhau = txt_MatKhau.Text;

            if (string.IsNullOrEmpty(nv.SDT) || string.IsNullOrEmpty(nv.MatKhau))
            {
                MessageBox.Show("Tài khoản và mật khẩu không được rỗng");
                return;
            }

            if (!conn.check_TaiKhoan(nv))
            {
                MessageBox.Show("Tài khoản chưa được đăng ký");
                return;
            }
            //conn.StrUserName = txt_TaiKhoan.Text;
            //conn.StrPassWord = txt_MatKhau.Text;
            //switch (conn.check_Quyen(tk))
            //{
            //    case 1:
            //        conn.StrUserName = "admin";
            //        conn.StrPassWord = "123";
            //        break;
            //    case 2:
            //        conn.StrUserName = "BacSi";
            //        conn.StrPassWord = "123";
            //        break;
            //    default:
            //        conn.StrUserName = "Duoc";
            //        conn.StrPassWord = "123";
            //        break;
            //}

            try
            {
                //conn.OpenConnect(tk,mk);
                conn.OpenConnect();
                MessageBox.Show("Đăng nhập thành công");

                FrmMain fm = new FrmMain(nv); 
                fm.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                conn.CloseConnect();
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi");
            }
        }
    }
}
