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
    public partial class FrmDichVu : Form
    {
        DichVu_BLL dv_bll = new DichVu_BLL();
        ChuyenKhoa_BLL ck_bll = new ChuyenKhoa_BLL();
        public FrmDichVu()
        {
            InitializeComponent();
        }

        private void toolStripBtn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void Load_DichVu()
        {
            var dichvuList = dv_bll.getDichVu();
            dtgv_DichVu.Rows.Clear();
            for (int i = 0; i < dichvuList.Rows.Count; i++)
            {
                DataRow row = dichvuList.Rows[i];
                dtgv_DichVu.Rows.Add(
                    row["TenChuyenKhoa"],
                    row["MaDichVu"],
                    row["TenDichVu"],
                    row["Gia"]
                    
                );
            }
        }
        private void dtgv_DichVu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dtgv_DichVu.Rows.Count)
            {
                DataGridViewRow row = dtgv_DichVu.Rows[e.RowIndex];

                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value != null)
                    {
                        txt_MaDichVu.Text = row.Cells["MaDichVu"].Value.ToString();
                        txt_TenDichVu.Text = row.Cells["TenDichVu"].Value.ToString();
                        txt_Gia.Text = row.Cells["Gia"].Value.ToString();
                        cbb_ChuyenKhoa.Text = row.Cells["TenChuyenKhoa"].Value.ToString();
                    }
                }
            }
        }
        public void RefreshDichVu()
        {
            txt_MaDichVu.Clear();
            txt_TenDichVu.Clear();
            txt_Gia.Clear();
            Load_DichVu();
        }

        private void FrmDichVu_Load(object sender, EventArgs e)
        {
            Load_DichVu();
            cbb_ChuyenKhoa.DataSource = ck_bll.getChuyenKhoa();
            cbb_ChuyenKhoa.DisplayMember = "TenChuyenKhoa";
            cbb_ChuyenKhoa.ValueMember = "MaChuyenKhoa";
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            if (txt_TenDichVu.Text == "" || txt_Gia.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin dịch vụ!");
                return;
            }

            DichVu_DTO dichVu = new DichVu_DTO();
            dichVu.TenDichVu = txt_TenDichVu.Text;
            dichVu.Gia = decimal.Parse(txt_Gia.Text);
            dichVu.MaChuyenKhoa = int.Parse(cbb_ChuyenKhoa.SelectedValue.ToString());

            if (dv_bll.insertDichVu(dichVu))
            {
                MessageBox.Show("Thêm dịch vụ thành công");
                RefreshDichVu();
            }
            else
            {
                MessageBox.Show("Thêm dịch vụ thất bại");
            }
        }

        private void toolStripBtn_Luu_Click(object sender, EventArgs e)
        {
            if (txt_TenDichVu.Text == "" || txt_MaDichVu.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!!!");
                return;
            }

            DichVu_DTO dv = new DichVu_DTO();
            dv.MaDichVu = int.Parse(txt_MaDichVu.Text);
            dv.TenDichVu = txt_TenDichVu.Text;
            dv.Gia = decimal.Parse(txt_Gia.Text);
            dv.MaChuyenKhoa = int.Parse(cbb_ChuyenKhoa.SelectedValue.ToString());

            if (dv_bll.updateDichVu(dv))
            {
                MessageBox.Show("Cập nhật thông tin dịch vụ thành công");
                RefreshDichVu();
            }
            else
            {
                MessageBox.Show("Cập nhật thông tin dịch vụ thất bại");
            }
        }

        private void toolStripBtn_Xoa_Click(object sender, EventArgs e)
        {
            if (txt_MaDichVu.Text == "")
            {
                MessageBox.Show("Vui lòng chọn dịch vụ cần xóa!!");
                return;
            }
            int maDichVu = int.Parse(txt_MaDichVu.Text);
            if (dv_bll.deleteDichVu(maDichVu))
            {
                MessageBox.Show("Xóa dịch vụ có tên : " + txt_TenDichVu.Text + " thành công");
                RefreshDichVu();
            }
            else
            {
                MessageBox.Show("Xóa thất bại!!");
            }
        }
    }
}
