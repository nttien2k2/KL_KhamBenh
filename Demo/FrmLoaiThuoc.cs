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
    public partial class FrmLoaiThuoc : Form
    {
        LoaiThuoc_BLL loait_bll = new LoaiThuoc_BLL();
        public FrmLoaiThuoc()
        {
            InitializeComponent();
        }


        private void Load_LoaiThuoc()
        {
            var loaiThuocList = loait_bll.getLoaiThuoc();
            dtgv_Thuoc.Rows.Clear();
            for (int i = 0; i < loaiThuocList.Rows.Count; i++)
            {
                DataRow row = loaiThuocList.Rows[i];
                
                dtgv_Thuoc.Rows.Add(
                    row["MaLoaiThuoc"],
                    row["TenLoaiThuoc"],
                    row["MoTa"]
                );
            }
        }

        private void toolStripBtn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void toolStripBtn_Luu_Click(object sender, EventArgs e)
        {
            if (txt_TenLoaiThuoc.Text == "" || txt_MaLoaiThuoc.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!!!");
                return;
            }

            LoaiThuoc_DTO loaiThuoc = new LoaiThuoc_DTO();
            loaiThuoc.MaLoaiThuoc = int.Parse(txt_MaLoaiThuoc.Text);
            loaiThuoc.TenLoaiThuoc = txt_TenLoaiThuoc.Text;
            loaiThuoc.MoTa = txt_MoTa.Text;

            if (loait_bll.updateLoaiThuoc(loaiThuoc))
            {
                MessageBox.Show("Cập nhật thông tin loại thuốc thành công");
                RefreshLoaiThuoc();
            }
            else
            {
                MessageBox.Show("Cập nhật thông tin loại thuốc thất bại");
            }
        }

        private void toolStripBtn_Xoa_Click(object sender, EventArgs e)
        {
            if (txt_MaLoaiThuoc.Text == "")
            {
                MessageBox.Show("Vui lòng chọn loại thuốc cần xóa!!");
                return;
            }
            int maLoaiThuoc = int.Parse(txt_MaLoaiThuoc.Text);
            if (loait_bll.deleteLoaiThuoc(maLoaiThuoc))
            {
                MessageBox.Show("Xóa loại thuốc có tên: " + txt_TenLoaiThuoc.Text + " thành công");
                RefreshLoaiThuoc();
            }
            else
            {
                MessageBox.Show("Xóa thất bại!!");
            }
        }
        private void btn_Them_Click(object sender, EventArgs e)
        {
            if (txt_TenLoaiThuoc.Text == "" || txt_MoTa.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin loại thuốc!");
                return;
            }

            LoaiThuoc_DTO loaiThuoc = new LoaiThuoc_DTO();
            loaiThuoc.TenLoaiThuoc = txt_TenLoaiThuoc.Text;
            loaiThuoc.MoTa = txt_MoTa.Text;

            if (loait_bll.insertLoaiThuoc(loaiThuoc))
            {
                MessageBox.Show("Thêm loại thuốc thành công");
                RefreshLoaiThuoc();
            }
            else
            {
                MessageBox.Show("Thêm loại thuốc thất bại");
            }
        }

        private void RefreshLoaiThuoc()
        {
            txt_MaLoaiThuoc.Clear();
            txt_TenLoaiThuoc.Clear();
            txt_MoTa.Clear();
            Load_LoaiThuoc();
        }

        private void toolStripBtn_Refresh_Click(object sender, EventArgs e)
        {
            RefreshLoaiThuoc();
        }

        private void dtgv_Thuoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dtgv_Thuoc.Rows.Count)
            {
                DataGridViewRow row = dtgv_Thuoc.Rows[e.RowIndex];

                foreach (DataGridViewCell cell in row.Cells)
                {
                    // Kiểm tra xem cột có dữ liệu hay không
                    if (cell.Value != null)
                    {
                        txt_MaLoaiThuoc.Text = row.Cells["MaLoaiThuoc"].Value.ToString();
                        txt_TenLoaiThuoc.Text = row.Cells["TenLoaiThuoc"].Value.ToString();
                        txt_MoTa.Text = row.Cells["MoTa"].Value.ToString();
                    }
                }
            }
        }

        private void FrmLoaiThuoc_Load(object sender, EventArgs e)
        {
            Load_LoaiThuoc();
        }
    }
}
