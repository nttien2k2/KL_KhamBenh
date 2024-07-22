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

namespace Demo
{
    public partial class FrmPhongBan : Form
    {
        PhongBan_BLL pb_bll = new PhongBan_BLL();
        public FrmPhongBan()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Load_PhongBan()
        {
            var phongbanList = pb_bll.getPhongBan();
            dtgv_PhongBan.Rows.Clear();
            for (int i = 0; i < phongbanList.Rows.Count; i++)
            {
                DataRow row = phongbanList.Rows[i];
                dtgv_PhongBan.Rows.Add(
                    row["MaPhongBan"],
                    row["TenPhongBan"],
                    row["VietTat"],
                    row["TrangThai"]
                );
            }
        }

        private void FrmPhongBan_Load(object sender, EventArgs e)
        {
            Load_PhongBan();
        }

        private void dtgv_PhongBan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dtgv_PhongBan.Rows.Count)
            {
                DataGridViewRow row = dtgv_PhongBan.Rows[e.RowIndex];

                foreach (DataGridViewCell cell in row.Cells)
                {
                    // Kiểm tra xem cột có dữ liệu hay không
                    if (cell.Value != null)
                    {
                        txt_MaPhongBan.Text = row.Cells["MaPhongBan"].Value.ToString();
                        txt_TenPhongBan.Text = row.Cells["TenPhongBan"].Value.ToString();
                        txt_VietTat.Text = row.Cells["VietTat"].Value.ToString();
                        ckb_TrangThai.Checked = (bool)row.Cells["TrangThai"].Value;
                    }
                }
            }
        }

        private void btn_ThemPB_Click(object sender, EventArgs e)
        {
            if (txt_TenPhongBan.Text == "" || txt_VietTat.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin phòng ban!");
                return;
            }

            PhongBan_DTO phongBan = new PhongBan_DTO();
            //phongBan.MaPhongBan = txt_MaPhongBan.Text;
            phongBan.TenPhongBan = txt_TenPhongBan.Text;
            phongBan.VietTat = txt_VietTat.Text;
            phongBan.TrangThai = ckb_TrangThai.Checked;

            if (pb_bll.insertPhongBan(phongBan))
            {
                MessageBox.Show("Thêm phòng ban thành công");
                RefreshPhongBan();
            }
            else
            {
                MessageBox.Show("Thêm phòng ban thất bại");
            }
        }
        private void toolStripBtn_Luu_Click(object sender, EventArgs e)
        {
            if (txt_TenPhongBan.Text == "" || txt_MaPhongBan.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!!!");
                return;
            }

            PhongBan_DTO pb = new PhongBan_DTO();
            pb.MaPhongBan = int.Parse(txt_MaPhongBan.Text);
            pb.TenPhongBan = txt_TenPhongBan.Text;
            pb.VietTat = txt_VietTat.Text;
            pb.TrangThai = ckb_TrangThai.Checked;

            if (pb_bll.updatePhongBan(pb))
            {
                MessageBox.Show("Cập nhật thông tin phòng ban thành công");
                RefreshPhongBan();
            }
            else
            {
                MessageBox.Show("Cập nhật thông tin phòng ban thất bại");
            }
        }

        private void toolStripBtn_Xoa_Click(object sender, EventArgs e)
        {
            if (txt_MaPhongBan.Text == "")
            {
                MessageBox.Show("Vui lòng chọn phòng ban cần xóa!!");
                return;
            }
            int maPhongBan = int.Parse(txt_MaPhongBan.Text);
            if (pb_bll.deletePhongBan(maPhongBan))
            {
                MessageBox.Show("Xóa phòng ban có tên : " + txt_TenPhongBan.Text + " thành công");
                RefreshPhongBan();
            }
            else
            {
                MessageBox.Show("Xóa thất bại!!");
            }
        }
        public void RefreshPhongBan()
        {
            txt_MaPhongBan.Clear();
            txt_TenPhongBan.Clear();
            txt_VietTat.Clear();

            Load_PhongBan();
        }

        private void toolStripBtn_Refresh_Click(object sender, EventArgs e)
        {
            RefreshPhongBan();
        }

        private void pn_Left_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
