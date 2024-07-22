using BLL;
using DAL;
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
    public partial class FrmNhapTBYT : Form
    {
        ThietBYT_BLL tbyt_bll = new ThietBYT_BLL(); 
        LoaiTBYT_BLL loaitbyt_bll = new LoaiTBYT_BLL();
        PhieuNhapTBYT_BLL phieu_bll = new PhieuNhapTBYT_BLL();
        CT_PhieuNhapTBYT_BLL ct_phieu_bll = new CT_PhieuNhapTBYT_BLL();
        private NhanVien_DTO nhanVien;

        public FrmNhapTBYT(NhanVien_DTO nv)
        {
            InitializeComponent();
            cbb_LoaiTBYT.DataSource = loaitbyt_bll.getLoaiTBYT();
            cbb_LoaiTBYT.DisplayMember = "TenLoaiTBYT";
            cbb_LoaiTBYT.ValueMember = "MaLoaiTBYT";
            toolStripBtn_ThemPhieuNhap.Enabled = false;
            date_NgayNhap.MinDate = DateTime.Today;
            this.nhanVien = nv;
        }

        private void cbb_LoaiTBYT_SelectedIndexChanged(object sender, EventArgs e)
        {
            Load_TBYT();

        }
        private void Load_TBYT()
        {
            if (cbb_LoaiTBYT.SelectedValue != null && int.TryParse(cbb_LoaiTBYT.SelectedValue.ToString(), out int maLoaiTBYT))
            {
                var thuocList = tbyt_bll.getTBYTByLoai(maLoaiTBYT);
                dtgv_TBYT.Rows.Clear();
                foreach (DataRow row in thuocList.Rows)
                {
                    dtgv_TBYT.Rows.Add(
                        row["TenTBYT"],
                        row["DonGia"],
                        row["DonViTinh"]
                    );
                }
            }
            else
            {
            }
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            if (txt_SoLuong.Text == "")
            {
                MessageBox.Show("Vui lòng nhập số lượng cần nhầm!!!");
                return;
            }
            try
            {
                // Tạo một hàng mới cho DataGridView Thông tin nhập
                DataGridViewRow newRow = new DataGridViewRow();
                newRow.CreateCells(dtgv_PhieuNhap);


                // Lấy giá trị từ các TextBox
                string tenTBYT = txt_TenTBYT.Text;
                float donGia = float.Parse(txt_DonGia.Text);
                int soLuong = int.Parse(txt_SoLuong.Text);
                string ngayNhap = date_NgayNhap.Value.ToString("dd/MM/yyyy");
                string donViTinh = txt_DonViTinh.Text;

                // Tính tổng giá trị
                float tongGiaTri = donGia * soLuong;

                // Thêm dữ liệu vào hàng mới
                newRow.Cells[0].Value = tenTBYT; // Tên thuốc
                newRow.Cells[1].Value = donGia; // Đơn giá
                newRow.Cells[2].Value = soLuong; // Số lượng
                newRow.Cells[3].Value = ngayNhap; // Ngày nhập thuốc
                newRow.Cells[4].Value = donViTinh; // Ngày nhập thuốc


                dtgv_PhieuNhap.Rows.Add(newRow);
                txt_TongTien.Text = UpdateTongGiaTri(tongGiaTri).ToString();

                //txt_TenThuoc.Text = "";
                //txt_DonGia.Text = "";
                //txt_HamLuong.Text = "";
                //txt_SoLuong.Text = "";
                //txt_Lo.Text = "";
                toolStripBtn_ThemPhieuNhap.Enabled = true;


            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm vào danh sách nhập: " + ex.Message);
            }
        }
        private float UpdateTongGiaTri(float giaTriMoi)
        {
            float tongGiaTri = 0;

            // Kiểm tra và lấy tổng giá trị hiện tại từ TextBox
            if (!string.IsNullOrEmpty(txt_TongTien.Text))
            {
                tongGiaTri = float.Parse(txt_TongTien.Text);
            }

            // Cộng giá trị mới vào tổng giá trị
            tongGiaTri += giaTriMoi;

            return tongGiaTri;
        }

        private void dtgv_TBYT_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dtgv_TBYT.Rows.Count)
            {
                DataGridViewRow row = dtgv_TBYT.Rows[e.RowIndex];

                foreach (DataGridViewCell cell in row.Cells)
                {
                    // Kiểm tra xem cột có dữ liệu hay không
                    if (cell.Value != null)
                    {
                        txt_TenTBYT.Text = row.Cells["TenTBYT"].Value.ToString();
                        txt_DonGia.Text = row.Cells["DonGia"].Value.ToString();
                        txt_DonViTinh.Text = row.Cells["DonViTinh"].Value.ToString();
                    }
                }
                txt_SoLuong.Focus();
            }
        }

        private void toolStripBtn_ThemPhieuNhap_Click(object sender, EventArgs e)
        {
            try
            {
                // Tạo đối tượng PhieuNhapThuoc_DTO
                PhieuNhapTBYT_DTO phieuNhap = new PhieuNhapTBYT_DTO();

                phieuNhap.NgayNhap = date_NgayNhap.Value;
                phieuNhap.TongGiaTri = decimal.Parse(txt_TongTien.Text);
                phieuNhap.MaNV = nhanVien.MaNV;

                // Gọi phương thức insertPhieuNhap để thêm phiếu nhập
                if (phieu_bll.insertPhieuNhapTBYT(phieuNhap))
                {
                    string tenThuoc = txt_TenTBYT.Text;
                    // Lấy MaPhieuNhap vừa được tạo
                    int maPhieuNhap = phieu_bll.getMaPhieuNhap();
                    int maTBYT = tbyt_bll.getMaTBYTByTenTBYT(txt_TenTBYT.Text.ToString());

                    // Thêm chi tiết phiếu nhập
                    foreach (DataGridViewRow row in dtgv_PhieuNhap.Rows)
                    {
                        if (row.Cells[0].Value != null)
                        {
                            CT_PhieuNhapTBYT_DTO ctPhieuNhap = new CT_PhieuNhapTBYT_DTO
                            {
                                MaTBYT = maTBYT,
                                MaPhieuNhap = maPhieuNhap,
                                SoLuong = int.Parse(row.Cells[2].Value.ToString()),
                                DonGia = decimal.Parse(row.Cells[1].Value.ToString())
                            };

                            ct_phieu_bll.insertCT_PhieuNhapTBYT(ctPhieuNhap);
                        }
                    }

                    MessageBox.Show("Thêm phiếu nhập thành công!");
                }
                else
                {
                    MessageBox.Show("Thêm phiếu nhập thất bại!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm phiếu nhập: " + ex.Message);
            }
        }
    }
}
