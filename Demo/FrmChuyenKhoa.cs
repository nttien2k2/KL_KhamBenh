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
    public partial class FrmChuyenKhoa : Form
    {
        ChuyenKhoa_BLL ck_bll = new ChuyenKhoa_BLL();
        public FrmChuyenKhoa()
        {
            InitializeComponent();
        }

        private void toolStripBtn_Luu_Click(object sender, EventArgs e)
        {
            if (txt_TenChuyenKhoa.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!!!");
                return;
            }

            ChuyenKhoa_DTO ck = new ChuyenKhoa_DTO();
            ck.MaChuyenKhoa = int.Parse(txt_MaChuyenKhoa.Text);
            ck.TenChuyenKhoa = txt_TenChuyenKhoa.Text;
            ck.VietTat = txt_VietTat.Text;

            if (ck_bll.updateChuyenKhoa(ck))
            {
                MessageBox.Show("Cập nhật thông tin chuyên khoa thành công");
                RefreshChuyenKhoa();
            }
            else
            {
                MessageBox.Show("Cập nhật thông tin chuyên khoa thất bại");
            }
        }

        private void toolStripBtn_Xoa_Click(object sender, EventArgs e)
        {
            if (txt_MaChuyenKhoa.Text == "")
            {
                MessageBox.Show("Vui lòng chọn chuyên khoa cần xóa!!");
                return;
            }
            int maChuyenKhoa = int.Parse(txt_MaChuyenKhoa.Text);
            if (ck_bll.deleteChuyenKhoa(maChuyenKhoa))
            {
                MessageBox.Show("Xóa chuyên khoa có tên: " + txt_TenChuyenKhoa.Text + " thành công");
                RefreshChuyenKhoa();
            }
            else
            {
                MessageBox.Show("Xóa thất bại!!");
            } 
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            if (txt_TenChuyenKhoa.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!!!");
            }
            else
            {
                ChuyenKhoa_DTO ck = new ChuyenKhoa_DTO();
                ck.TenChuyenKhoa = txt_TenChuyenKhoa.Text;
                ck.VietTat = txt_VietTat.Text;

                if (ck_bll.insertChuyenKhoa(ck))
                {
                    MessageBox.Show("Thêm chuyên khoa thành công");
                    RefreshChuyenKhoa();
                }
                else
                {
                    MessageBox.Show("Thêm chuyên khoa thất bại");
                }
            }
        }
        private void toolStripBtn_Refresh_Click(object sender, EventArgs e)
        {
            RefreshChuyenKhoa();
        }

        private void RefreshChuyenKhoa()
        {
            txt_MaChuyenKhoa.Clear();
            txt_TenChuyenKhoa.Clear();
            txt_VietTat.Clear();
            Load_ChuyenKhoa();
        }
        private void Load_ChuyenKhoa()
        {
            var chuyenKhoaList = ck_bll.getChuyenKhoa();
            dtgv_ChuyenKhoa.Rows.Clear(); 
            for (int i = 0; i < chuyenKhoaList.Rows.Count; i++)
            {
                DataRow row = chuyenKhoaList.Rows[i];
                dtgv_ChuyenKhoa.Rows.Add(
                    row["MaChuyenKhoa"],
                    row["TenChuyenKhoa"],
                    row["VietTat"]
                );
            }
        }
        private void toolStripBtn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmChuyenKhoa_Load(object sender, EventArgs e)
        {
            Load_ChuyenKhoa();
        }

        private void dtgv_ChuyenKhoa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dtgv_ChuyenKhoa.Rows.Count)
            {
                DataGridViewRow row = dtgv_ChuyenKhoa.Rows[e.RowIndex];

                foreach (DataGridViewCell cell in row.Cells)
                {
                    // Kiểm tra xem cột có dữ liệu hay không
                    if (cell.Value != null)
                    {
                        txt_MaChuyenKhoa.Text = row.Cells["MaChuyenKhoa"].Value.ToString();
                        txt_TenChuyenKhoa.Text = row.Cells["TenChuyenKhoa"].Value.ToString();
                        txt_VietTat.Text = row.Cells["VietTat"].Value.ToString();
                    }
                }
            }
        }


    }
}
