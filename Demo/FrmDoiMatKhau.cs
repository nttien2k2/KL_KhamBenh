using BLL;
using Demo;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class FrmDoiMatKhau : Form
    {
        NhanVien_BLL nv_bll = new NhanVien_BLL();
        public FrmDoiMatKhau()
        {
            InitializeComponent();
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            string sdt = txt_SDT.Text;
            string mk1 = txt_MatKhau.Text;
            string mk2 = txt_ConfrimMatKhau.Text;
            if(nv_bll.getNhanVienBySDT(sdt) == null)
            {
                MessageBox.Show("Số điện thoại chưa được đăng ký. Vui lòng kiểm tra lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_SDT.Clear();
                txt_MatKhau.Clear();
                txt_ConfrimMatKhau.Clear();
                return;
            }
            if (mk1 != mk2)
            {
                MessageBox.Show("Mật khẩu nhập lại không khớp. Vui lòng kiểm tra lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_SDT.Clear();
                txt_MatKhau.Clear();
                txt_ConfrimMatKhau.Clear();
                return;
            }
            NhanVien_DTO nv = new NhanVien_DTO();
            nv.SDT = sdt;
            nv.MatKhau = mk2;
            if(nv_bll.doiMatKhau(nv))
            {
                MessageBox.Show("Bạn đã đổi mật khẩu thành công!!!", "Thông báo");
                FrmLogin f = new FrmLogin();
                f.Show();
                this.Hide();
            }else
            {
                MessageBox.Show("Đổi mật khẩu thất bại!!!", "Thông báo");
            }


        }
    }
}
