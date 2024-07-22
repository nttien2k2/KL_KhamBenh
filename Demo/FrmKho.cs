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
    public partial class FrmKho : Form
    {
        Thuoc_BLL t_bll = new Thuoc_BLL();
        ThietBYT_BLL tbyt_bll = new ThietBYT_BLL();
        LoaiThuoc_BLL loait_bll = new LoaiThuoc_BLL();
        LoaiTBYT_BLL loaitbyt_bll = new LoaiTBYT_BLL();

        public FrmKho()
        {
            InitializeComponent();
        }

        public void load_Thuoc()
        {
            var khoList = t_bll.getKho();
            dtgv_Kho.Rows.Clear();
            for (int i = 0; i < khoList.Rows.Count; i++)
            {
                DataRow row = khoList.Rows[i];

                dtgv_Kho.Rows.Add(
                    row["MaThuoc"],
                    row["TenThuoc"],
                    row["DonGiaBan"],
                    row["DonViTinh"],
                    row["TongSoLuong"]
                );
            }
        }
        public void load_TBYT()
        {
            var khoList = tbyt_bll.getKho();
            dtgv_KhoTBYT.Rows.Clear();
            for (int i = 0; i < khoList.Rows.Count; i++)
            {
                DataRow row = khoList.Rows[i];

                dtgv_KhoTBYT.Rows.Add(
                    row["MaTBYT"],
                    row["TenTBYT"],
                    row["DonGia"],
                    row["DonViTinh"],
                    row["TongSoLuong"]
                );
            }
        }
        private void FrmKho_Load(object sender, EventArgs e)
        {
            load_Thuoc();
            cbb_LoaiThuoc.DataSource = loait_bll.getLoaiThuoc();
            cbb_LoaiThuoc.DisplayMember = "TenLoaiThuoc";
            cbb_LoaiThuoc.ValueMember = "MaLoaiThuoc";
            load_TBYT();
            cbb_LoaiTBYT.DataSource = loaitbyt_bll.getLoaiTBYT();
            cbb_LoaiTBYT.DisplayMember = "TenLoaiTBYT";
            cbb_LoaiTBYT.ValueMember = "MaLoaiTBYT";
        }

        private void dtgv_Kho_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dtgv_Kho.Rows.Count)
            {
                DataGridViewRow row = dtgv_Kho.Rows[e.RowIndex];

                foreach (DataGridViewCell cell in row.Cells)
                {
                    // Kiểm tra xem cột có dữ liệu hay không
                    if (cell.Value != null)
                    {
                        txt_MaThuoc.Text = row.Cells["MaThuoc"].Value.ToString();
                        txt_TenThuoc.Text = row.Cells["TenThuoc"].Value.ToString();
                        txt_DonGia.Text = row.Cells["DonGiaBan"].Value.ToString();
                        //txt_Lo.Text = row.Cells["Lo"].Value.ToString();
                        //txt_SoLuong.Text = row.Cells["SoLuong"].Value.ToString();
                        txt_DonViTinh.Text = row.Cells["DonViTinh"].Value.ToString();
                        txt_SoLuong.Text = row.Cells["SoLuong"].Value.ToString();

                    }
                }
            }
        }

        private void cbb_LoaiThuoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            Load_Thuoc();

        }
        private void Load_Thuoc()
        {
            if (cbb_LoaiThuoc.SelectedValue != null && int.TryParse(cbb_LoaiThuoc.SelectedValue.ToString(), out int maLoaiThuoc))
            {
                var thuocList = t_bll.getThuocByLoai(maLoaiThuoc);
                dtgv_Kho.Rows.Clear();
                foreach (DataRow row in thuocList.Rows)
                {
                    dtgv_Kho.Rows.Add(
                        //row["MaThuoc"],
                        row["TenThuoc"],
                        row["DonGia"],
                        //row["DangGiaBan"],
                        row["HamLuong"],
                        //row["TacDungPhu"],
                        //row["NhaSanXuat"],
                        //row["NuocSanXuat"],
                        //row["SoLuong"],
                        //row["TacDung"],
                        //Convert.ToDateTime(row["NgayApDungDonGia"]).ToString("dd-MM-yyyy"),
                        //row["Lo"],
                        row["DonViTinh"]
                    //row["BietDuoc"],
                    //row["TenLoaiThuoc"]
                    );
                }
            }
            else
            {
                //MessageBox.Show("Selected value is not a valid number.");
            }
        }
    }
}
