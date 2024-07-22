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
    public partial class FrmLoaiTBYT : Form
    {
        LoaiTBYT_BLL loaitbyt_bll = new LoaiTBYT_BLL();
        public FrmLoaiTBYT()
        {
            InitializeComponent();
        }

        private void dtgv_LoaiTBYT_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dtgv_LoaiTBYT.Rows.Count)
            {
                DataGridViewRow row = dtgv_LoaiTBYT.Rows[e.RowIndex];

                foreach (DataGridViewCell cell in row.Cells)
                {
                    // Kiểm tra xem cột có dữ liệu hay không
                    if (cell.Value != null)
                    {
                        txt_MaLoaiTBYT.Text = row.Cells["MaLoaiTBYT"].Value.ToString();
                        txt_TenLoaiTBYT.Text = row.Cells["TenLoaiTBYT"].Value.ToString();
                        txt_MoTa.Text = row.Cells["MoTa"].Value.ToString();
                    }
                }
            }
        }
        public void Load_LoaiTBYT()
        {
            var loaiTBYTList = loaitbyt_bll.getLoaiTBYT();
            dtgv_LoaiTBYT.Rows.Clear();
            for (int i = 0; i < loaiTBYTList.Rows.Count; i++)
            {
                DataRow row = loaiTBYTList.Rows[i];

                dtgv_LoaiTBYT.Rows.Add(
                    row["MaLoaiTBYT"],
                    row["TenLoaiTBYT"],
                    row["MoTa"]
                );
            }
        }

        private void FrmLoaiTBYT_Load(object sender, EventArgs e)
        {
            Load_LoaiTBYT();
        }


        private void toolStripBtn_Luu_Click(object sender, EventArgs e)
        {
            if (txt_TenLoaiTBYT.Text == "" || txt_MaLoaiTBYT.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!!!");
                return;
            }

            LoaiTBYT_DTO loaiTBYT = new LoaiTBYT_DTO();
            loaiTBYT.MaLoaiTBYT = int.Parse(txt_MaLoaiTBYT.Text);
            loaiTBYT.TenLoaiTBYT = txt_TenLoaiTBYT.Text;
            loaiTBYT.MoTa = txt_MoTa.Text;

            if (loaitbyt_bll.updateLoaiTBYT(loaiTBYT))
            {
                MessageBox.Show("Cập nhật thông tin loại TBYT thành công");
                RefreshLoaiTBYT();
            }
            else
            {
                MessageBox.Show("Cập nhật thông tin loại TBYT thất bại");
            }
        }

        private void toolStripBtn_Xoa_Click(object sender, EventArgs e)
        {
            if (txt_MaLoaiTBYT.Text == "")
            {
                MessageBox.Show("Vui lòng chọn loại TBYT cần xóa!!");
                return;
            }
            int maLoaiTBYT = int.Parse(txt_MaLoaiTBYT.Text);
            if (loaitbyt_bll.deleteLoaiTBYT(maLoaiTBYT))
            {
                MessageBox.Show("Xóa loại TBYT có tên: " + txt_TenLoaiTBYT.Text + " thành công");
                RefreshLoaiTBYT();
            }
            else
            {
                MessageBox.Show("Xóa thất bại!!");
            }
        }

        private void toolStripBtn_Refresh_Click(object sender, EventArgs e)
        {
            RefreshLoaiTBYT();
        }

        private void toolStripBtn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void RefreshLoaiTBYT()
        {
            txt_MaLoaiTBYT.Clear();
            txt_TenLoaiTBYT.Clear();
            txt_MoTa.Clear();
            Load_LoaiTBYT();
        }

        private void btn_ThemTBYT_Click(object sender, EventArgs e)
        {
            if (txt_TenLoaiTBYT.Text == "" || txt_MoTa.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin loại TBYT!");
                return;
            }

            LoaiTBYT_DTO loaiTBYT = new LoaiTBYT_DTO();
            loaiTBYT.TenLoaiTBYT = txt_TenLoaiTBYT.Text;
            loaiTBYT.MoTa = txt_MoTa.Text;

            if (loaitbyt_bll.insertLoaiTBYT(loaiTBYT))
            {
                MessageBox.Show("Thêm loại TBYT thành công");
                RefreshLoaiTBYT();
            }
            else
            {
                MessageBox.Show("Thêm loại TBYT thất bại");
            }
        }
    }
}
