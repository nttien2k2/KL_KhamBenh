using BLL;
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
    public partial class FrmCapNhatHSBA : Form
    {
        HoSoBenhAn_BLL hsba_bll = new HoSoBenhAn_BLL();
        NhanVien_BLL nv_bll = new NhanVien_BLL();
        BenhNhan_BLL bn_bll = new BenhNhan_BLL();
        public FrmCapNhatHSBA()
        {
            InitializeComponent();
            cbb_NhanVien.DataSource = nv_bll.getNV();
            cbb_NhanVien.DisplayMember = "HoTen";
            cbb_NhanVien.ValueMember = "MaNV";
            cbb_MaBN.DataSource = bn_bll.getBenhNhan();
            cbb_MaBN.DisplayMember = "SDT";
            cbb_MaBN.ValueMember = "MaBN";
        }

        private void btn_ThemPB_Click(object sender, EventArgs e)
        {
            
        }

        private void FrmCapNhatHSBA_Load(object sender, EventArgs e)
        {
            
        }

        private void toolStripBtn_Luu_Click(object sender, EventArgs e)
        {
            if (cbb_MaBN.Text == "" || cbb_NhanVien.Text == "" || txt_ChanDoanBanDau.Text == "" || txt_LyDoKham.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin hồ sơ bệnh án!");
                return;
            }
            DateTime ngaykham = dtPicker_NgayKham.Value;
            HoSoBenhAn_DTO hoSoBenhAn = new HoSoBenhAn_DTO();
            hoSoBenhAn.MaBN = int.Parse(cbb_MaBN.SelectedValue.ToString());
            hoSoBenhAn.MaNV = int.Parse(cbb_NhanVien.SelectedValue.ToString());
            //hoSoBenhAn.NgayKham = ngaykham;
            hoSoBenhAn.ChanDoanBanDau = txt_ChanDoanBanDau.Text;
            hoSoBenhAn.DieuTri = txt_DieuTri.Text;
            hoSoBenhAn.GhiChu = txt_GhiChu.Text;
            hoSoBenhAn.LyDoKham = txt_LyDoKham.Text;
            hoSoBenhAn.KetQuaKham = txt_KetQuaKham.Text;
            //hoSoBenhAn.MaBN = 1;
            //hoSoBenhAn.MaNV = 1;
            hoSoBenhAn.NgayKham = ngaykham;
            //hoSoBenhAn.ChanDoanBanDau = "Ho";
            //hoSoBenhAn.DieuTri = "Ho";
            //hoSoBenhAn.GhiChu = "Ho";
            //hoSoBenhAn.LyDoKham = "Ho";
            //hoSoBenhAn.KetQuaKham = "Ho";

            if (hsba_bll.updateHoSoBenhAn(hoSoBenhAn))
            {
                MessageBox.Show("Thêm hồ sơ bệnh án thành công");
                //RefreshHoSoBenhAn();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Thêm hồ sơ bệnh án thất bại");
            }
        }
    }
}
