using BLL;
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
    public partial class FrmChiTietThuoc : Form
    {
        Thuoc_BLL t_bll = new Thuoc_BLL();
        LoaiThuoc_BLL loait_bll = new LoaiThuoc_BLL();
        public FrmChiTietThuoc()
        {
            InitializeComponent();
        }
        private void Load_Thuoc()
        {
            var thuocList = t_bll.getThuoc();
            dtgv_Thuoc.Rows.Clear();
            foreach (DataRow row in thuocList.Rows)
            {
                dtgv_Thuoc.Rows.Add(
                    row["MaThuoc"],
                    row["TenThuoc"],
                    row["DonGia"],
                    row["DangGiaBan"],
                    row["HamLuong"],
                    row["DonViTinh"],
                    row["TacDungPhu"],
                    row["NhaSanXuat"],
                    row["NuocSanXuat"],
                    row["SoLuong"],
                    row["TacDung"],
                    Convert.ToDateTime(row["NgayApDungDonGia"]).ToString("dd-MM-yyyy"),
                    row["Lo"],
                    row["BietDuoc"],
                    row["TenLoaiThuoc"]
                );
            }
        }

        private void LoadComboBoxLoaiThuoc()
        {
            try
            {
                DataTable dtLoaiThuoc = loait_bll.getLoaiThuoc();

                // Clear existing items in ComboBox
                cbb_LoaiThuoc.Items.Clear();

                // Add items to ComboBox
                cbb_LoaiThuoc.DataSource = dtLoaiThuoc;
                cbb_LoaiThuoc.DisplayMember = "TenLoaiThuoc";
                cbb_LoaiThuoc.ValueMember = "MaLoaiThuoc";

                // Select the first item by default if available
                if (cbb_LoaiThuoc.Items.Count > 0)
                {
                    cbb_LoaiThuoc.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu loại thuốc: " + ex.Message);
            }
        }

        private void FrmNhapThuoc_Load(object sender, EventArgs e)
        {
            Load_Thuoc();
            LoadComboBoxLoaiThuoc();
        }

        private void toolStripBtn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
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
                        txt_MaThuoc.Text = row.Cells["MaThuoc"].Value.ToString();
                        txt_TenThuoc.Text = row.Cells["TenThuoc"].Value.ToString();
                        txt_NuocSanXuat.Text = row.Cells["NuocSanXuat"].Value.ToString();
                        txt_TacDung.Text = row.Cells["TacDung"].Value.ToString();
                        txt_TacDungPhu.Text = row.Cells["TacDungPhu"].Value.ToString();
                        txt_NhaSanXuat.Text = row.Cells["NhaSanXuat"].Value.ToString();
                        txt_Lo.Text = row.Cells["Lo"].Value.ToString();
                        txt_HamLuong.Text = row.Cells["HamLuong"].Value.ToString();
                        txt_BietDuoc.Text = row.Cells["BietDuoc"].Value.ToString();
                        txt_DonGia.Text = row.Cells["DonGia"].Value.ToString();
                        txt_DonGiaBan.Text = row.Cells["DonGiaBan"].Value.ToString();
                        txt_DonViTinh.Text = row.Cells["DonViTinh"].Value.ToString();
                        txt_NgayApDung.Text = row.Cells["NgayApDungDonGia"].Value.ToString();
                        txt_SoLuong.Text = row.Cells["SoLuong"].Value.ToString();
                        cbb_LoaiThuoc.Text = row.Cells["TenLoaiThuoc"].Value.ToString();
                    }
                }
            }
        }
    }
}
