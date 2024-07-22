using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace GUI
{
    public partial class FrmNhapThuoc : Form
    {
        Thuoc_BLL t_bll = new Thuoc_BLL();
        LoaiThuoc_BLL loait_bll = new LoaiThuoc_BLL();
        PhieuNhapThuoc_BLL phieu_bll = new PhieuNhapThuoc_BLL();
        CT_PhieuNhapThuoc_BLL ct_phieu_bll = new CT_PhieuNhapThuoc_BLL();
        private NhanVien_DTO nhanVien;
        public FrmNhapThuoc(NhanVien_DTO nv)
        {
            InitializeComponent();
            cbb_LoaiThuoc.DataSource = loait_bll.getLoaiThuoc();
            cbb_LoaiThuoc.DisplayMember = "TenLoaiThuoc";
            cbb_LoaiThuoc.ValueMember = "MaLoaiThuoc";
            toolStripBtn_ThemPhieuNhap.Enabled = false;
            date_NgayNhap.MinDate = DateTime.Today;
            this.nhanVien = nv;
        }
        private void Load_Thuoc()
        {
            if (cbb_LoaiThuoc.SelectedValue != null && int.TryParse(cbb_LoaiThuoc.SelectedValue.ToString(), out int maLoaiThuoc))
            {
                var thuocList = t_bll.getThuocByLoai(maLoaiThuoc);
                dtgv_Thuoc.Rows.Clear();
                foreach (DataRow row in thuocList.Rows)
                {
                    dtgv_Thuoc.Rows.Add(
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

        private void FrmNhapThuoc_Load(object sender, EventArgs e)
        {
            //Load_Thuoc();
            //LoadComboBoxLoaiThuoc();
        }

        private void cbb_LoaiThuoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            Load_Thuoc();
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            if (txt_SoLuong.Text == "" || txt_Lo.Text == "")
            {
                MessageBox.Show("Vui lòng nhập sô lượng và lô thuốc!!!");
                return;
            }
            try
            {
                // Tạo một hàng mới cho DataGridView Thông tin nhập
                DataGridViewRow newRow = new DataGridViewRow();
                newRow.CreateCells(dtgv_PhieuNhap);


                // Lấy giá trị từ các TextBox
                string tenThuoc = txt_TenThuoc.Text;
                float donGia = float.Parse(txt_DonGia.Text);
                string hamLuong = txt_HamLuong.Text;
                int soLuong = int.Parse(txt_SoLuong.Text);
                string lo = txt_Lo.Text;
                string ngayNhap = date_NgayNhap.Value.ToString("dd/MM/yyyy");
                string donViTinh = txt_DonViTinh.Text;

                // Tính tổng giá trị
                float tongGiaTri = donGia * soLuong;

                // Thêm dữ liệu vào hàng mới
                newRow.Cells[0].Value = tenThuoc; // Tên thuốc
                newRow.Cells[1].Value = donGia; // Đơn giá
                newRow.Cells[2].Value = hamLuong; // Hàm lượng
                newRow.Cells[3].Value = soLuong; // Số lượng
                newRow.Cells[4].Value = lo; // Số lô
                newRow.Cells[5].Value = ngayNhap; // Ngày nhập thuốc
                newRow.Cells[6].Value = donViTinh; // Ngày nhập thuốc


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
                        txt_TenThuoc.Text = row.Cells["TenThuoc"].Value.ToString();
                        txt_DonGia.Text = row.Cells["DonGia"].Value.ToString();
                        txt_HamLuong.Text = row.Cells["HamLuong"].Value.ToString();
                        //txt_Lo.Text = row.Cells["Lo"].Value.ToString();
                        //txt_SoLuong.Text = row.Cells["SoLuong"].Value.ToString();
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
                PhieuNhapThuoc_DTO phieuNhap = new PhieuNhapThuoc_DTO();

                phieuNhap.NgayNhap = date_NgayNhap.Value;
                phieuNhap.TongGiaTri = decimal.Parse(txt_TongTien.Text);
                phieuNhap.MaNV = nhanVien.MaNV;

                // Gọi phương thức insertPhieuNhap để thêm phiếu nhập
                if (phieu_bll.insertPhieuNhapThuoc(phieuNhap))
                {
                    string tenThuoc = txt_TenThuoc.Text;
                    // Lấy MaPhieuNhap vừa được tạo
                    int maPhieuNhap = phieu_bll.getMaPhieuNhap();
                    int maThuoc = t_bll.getMaThuocByTenThuoc(txt_TenThuoc.Text.ToString());

                    // Thêm chi tiết phiếu nhập
                    foreach (DataGridViewRow row in dtgv_PhieuNhap.Rows)
                    {
                        if (row.Cells[0].Value != null)
                        {
                            CT_PhieuNhapThuoc_DTO ctPhieuNhap = new CT_PhieuNhapThuoc_DTO
                            {
                                MaThuoc = maThuoc,
                                MaPhieuNhap = maPhieuNhap,
                                SoLuong = int.Parse(row.Cells[3].Value.ToString()),
                                DonGia = decimal.Parse(row.Cells[1].Value.ToString())
                            };

                            ct_phieu_bll.insertCT_PhieuNhapThuoc(ctPhieuNhap);
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

        private void txt_SoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Chỉ cho phép nhập số, không cho phép nhập dấu chấm hoặc dấu phẩy
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

    }
}
