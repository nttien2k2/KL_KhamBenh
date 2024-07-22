using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DAL;
using DTO;

namespace Demo
{
    public partial class FrmNhanVien : Form
    {
        DbContext conn = new DbContext();
        NhanVien_BLL nhanVienBLL = new NhanVien_BLL();
        Export_BLL export_bll = new Export_BLL();
        PhongBan_BLL phongBanBLL = new PhongBan_BLL();

        public FrmNhanVien()
        {
            InitializeComponent();
        }

        private void FrmNhanVien_Load(object sender, EventArgs e)
        {
            Load_NhanVien();
            cbb_ChucDanh.DataSource = nhanVienBLL.loadCbb_ChucDanh();
            cbb_ChucDanh.DisplayMember = "TenQuyen";
            cbb_ChucDanh.ValueMember = "MaQuyen";
            cbb_PhongBan.DataSource = phongBanBLL.loadCbb_PhongBan();
            cbb_PhongBan.DisplayMember = "TenPhongBan";
            cbb_PhongBan.ValueMember = "MaPhongBan";
        }
        private void Load_NhanVien()
        {
            var nhanVienList = nhanVienBLL.getNhanVien();
            dtgv_NhanVien.Rows.Clear();
            for (int i = 0; i < nhanVienList.Rows.Count; i++)
            {
                DataRow row = nhanVienList.Rows[i];
                DateTime ngaySinh = Convert.ToDateTime(row["NgaySinh"]);
                string fmngaySinh = ngaySinh.ToString("dd/MM/yyyy");
                dtgv_NhanVien.Rows.Add(
                    row["MaNV"],
                    row["HoTen"],
                    row["SDT"],
                    row["CCCD"],
                    row["HocVan"],
                    row["TenPhongBan"],
                    row["ChucDanh"],
                    //row["TenQuyen"],
                    row["DiaChi"],
                    row["Email"],
                    row["Tuoi"],
                    fmngaySinh
                );
            }
        }
        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void dtgv_NhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dtgv_NhanVien.Rows.Count)
            {
                DataGridViewRow row = dtgv_NhanVien.Rows[e.RowIndex];

                foreach (DataGridViewCell cell in row.Cells)
                {
                    // Kiểm tra xem cột có dữ liệu hay không
                    if (cell.Value != null)
                    {
                        txt_MaNV.Text = row.Cells["MaNV"].Value.ToString();
                        txt_HoTen.Text = row.Cells["HoTen"].Value.ToString();
                        txt_SDT.Text = row.Cells["SDT"].Value.ToString();
                        txt_DiaChi.Text = row.Cells["DiaChi"].Value.ToString();
                        txt_Email.Text = row.Cells["Email"].Value.ToString();
                        txt_Tuoi.Text = row.Cells["Tuoi"].Value.ToString();
                        txt_NgaySinh.Text = row.Cells["NgaySinh"].Value.ToString();
                        txt_HocVan.Text = row.Cells["HocVan"].Value.ToString();
                        txt_CCCD.Text = row.Cells["CCCD"].Value.ToString();
                        cbb_ChucDanh.Text = row.Cells["ChucDanh"].Value.ToString();
                        cbb_PhongBan.Text = row.Cells["PhongBan"].Value.ToString();
                    }
                }
            }
        }
        private void btn_Them_Click(object sender, EventArgs e)
        {
            if (txt_HoTen.Text == "" || txt_SDT.Text == "" || txt_Email.Text == "" || txt_Tuoi.Text == "" || txt_DiaChi.Text == "" || txt_HocVan.Text == "")
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!!!");
            NhanVien_DTO nv = new NhanVien_DTO();
            nv.HoTen = txt_HoTen.Text;
            nv.SDT = txt_SDT.Text;
            nv.CCCD = txt_CCCD.Text;
            nv.Tuoi = int.Parse(txt_Tuoi.Text);
            nv.Email = txt_Email.Text;
            nv.DiaChi = txt_DiaChi.Text;
            nv.HocVan = txt_HocVan.Text;
            nv.NgaySinh = DateTime.ParseExact(txt_NgaySinh.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            nv.MaQuyen = int.Parse(cbb_ChucDanh.SelectedValue.ToString());
            nv.ChucDanh = cbb_ChucDanh.Text;
            nv.MaPhongBan = int.Parse(cbb_PhongBan.SelectedValue.ToString());


            if (nhanVienBLL.insertNhanVien(nv))
            {
                MessageBox.Show("Thêm nhân viên thành công");
                RefreshNhanVien();
            }
            else
            {
                MessageBox.Show("Thêm nhân viên thất bại");
            }
        }
        private void toolStripbtn_Luu_Click(object sender, EventArgs e)
        {
            if (txt_HoTen.Text == "" || txt_SDT.Text == "" || txt_Email.Text == "" || txt_Tuoi.Text == "" || txt_DiaChi.Text == "" || txt_HocVan.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!!!");
                return;
            }

            NhanVien_DTO nv = new NhanVien_DTO();
            nv.MaNV = int.Parse(txt_MaNV.Text);
            nv.HoTen = txt_HoTen.Text;
            nv.SDT = txt_SDT.Text;
            nv.CCCD = txt_CCCD.Text;
            nv.Tuoi = int.Parse(txt_Tuoi.Text);
            nv.Email = txt_Email.Text;
            nv.DiaChi = txt_DiaChi.Text;
            nv.HocVan = txt_HocVan.Text;
            nv.NgaySinh = DateTime.ParseExact(txt_NgaySinh.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture); 
            nv.ChucDanh = cbb_ChucDanh.SelectedValue.ToString();
            nv.MaPhongBan = int.Parse(cbb_PhongBan.SelectedValue.ToString());

            if (nhanVienBLL.updateNhanVien(nv))
            {
                MessageBox.Show("Cập nhật thông tin nhân viên thành công");
                RefreshNhanVien();
            }
            else
            {
                MessageBox.Show("Cập nhật thông tin nhân viên thất bại");
            }
        }
        private void toolStripbtn_Xoa_Click(object sender, EventArgs e)
        {
            if (txt_MaNV.Text == "")
            {
                MessageBox.Show("Vui lòng chọn nhân viên cần xóa!!");
                return;
            }
            string sdt = txt_SDT.Text;
            if (nhanVienBLL.deleteNhanVien(sdt))
            {
                MessageBox.Show("Xóa nhân viên có Tên : " + txt_HoTen.Text + " thành công");
                RefreshNhanVien();
            }
            else
            {
                MessageBox.Show("Xóa thất bại!!");
            }
        }
        public void RefreshNhanVien()
        {
            txt_HoTen.Clear();
            txt_DiaChi.Clear();
            txt_HocVan.Clear();
            txt_CCCD.Clear();
            txt_MaNV.Clear();
            txt_SDT.Clear();
            txt_Tuoi.Clear();
            txt_Email.Clear();
            txt_SoLuongNV.Clear();
            txt_Search.Clear();
            txt_NgaySinh.Clear();
            Load_NhanVien();
        }
        private void toolStripbtn_Refresh_Click(object sender, EventArgs e)
        {
            RefreshNhanVien();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            // Thiết lập các thuộc tính của OpenFileDialog
            openFileDialog.Title = "Chọn ảnh";
            openFileDialog.Filter = "Image files (*.jpg, *.png, *.gif) | *.jpg; *.png; *.gif";
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);

            // Hiển thị hộp thoại chọn tệp tin
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Lấy đường dẫn của tệp tin được chọn
                string selectedImagePath = openFileDialog.FileName;
                Image selectedImage = Image.FromFile(selectedImagePath);
                // Hiển thị ảnh trong PictureBox
                pictureBox1.Image = selectedImage;
                pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;

            }
        }
        private void btn_Search_Click(object sender, EventArgs e)
        {
            string search = txt_Search.Text;
            if (txt_Search.Text == "")
            {
                Load_NhanVien();
            }
            else
            {
                var nhanVienListByName = nhanVienBLL.search(search);
                dtgv_NhanVien.Rows.Clear();
                for (int i = 0; i < nhanVienListByName.Rows.Count; i++)
                {
                    DataRow row = nhanVienListByName.Rows[i];
                    dtgv_NhanVien.Rows.Add(
                        row["MaNV"],
                        row["HoTen"],
                        row["SDT"],
                        row["CCCD"],
                        row["HocVan"],
                        row["TenPhongBan"],
                        row["ChucDanh"],
                        //row["TenQuyen"],
                        row["DiaChi"],
                        row["Email"],
                        row["Tuoi"],
                        row["NgaySinh"]

                    );
                }
            }
            txt_SoLuongNV.Text = nhanVienBLL.countNhanVienBySearch(search).ToString();

        }
        private void toolStripBtn_PrintNV_Click(object sender, EventArgs e)
        {
            if (dtgv_NhanVien.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu để xuất.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DataTable dt = GetDataTableFromDataGridView(dtgv_NhanVien);
            string sheetName = "Nhân viên";
            string title = "Danh sách nhân viên";
            export_bll.exportDSNhanVien(dt, sheetName, title);
        }
        private DataTable GetDataTableFromDataGridView(DataGridView dataGridView)
        {
            DataTable dataTable = new DataTable();

            // Thêm các cột vào DataTable
            foreach (DataGridViewColumn column in dataGridView.Columns)
            {
                if (column.Visible) // Chỉ thêm các cột đang hiển thị
                {
                    dataTable.Columns.Add(column.HeaderText, column.ValueType ?? typeof(string));
                }
            }

            // Thêm các hàng vào DataTable
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                if (!row.IsNewRow) // Bỏ qua hàng trống cuối cùng
                {
                    DataRow dataRow = dataTable.NewRow();
                    foreach (DataGridViewColumn column in dataGridView.Columns)
                    {
                        if (column.Visible) // Chỉ thêm dữ liệu từ các cột đang hiển thị
                        {
                            dataRow[column.HeaderText] = row.Cells[column.Index].Value ?? DBNull.Value;
                        }
                    }
                    dataTable.Rows.Add(dataRow);
                }
            }

            return dataTable;
        }
    }
}
