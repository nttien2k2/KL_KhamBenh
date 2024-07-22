using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DAL;


namespace Demo
{
    public partial class FrmSaoLuuPhucHoi : Form
    {
        private readonly DbContext conn = new DbContext();

        string defaultFolderPath = @"C:\KiKS";

        Backup_Restore_BLL bc_rt_bll = new Backup_Restore_BLL();
        public FrmSaoLuuPhucHoi()
        {
            InitializeComponent();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            //openFile.Filter = "Backup file (.bak)|*.bak| All files (.trn)|*.trn";
            //openFile.Title = "Phục hồi dữ liệu";
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                //txtPhucHoi.Text = openFile.FileName;
            }
        }

        private void FrmSaoLuuPhucHoi_Load(object sender, EventArgs e)
        {
            Load_FileRestore();
        }

        private void toolStripBtn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBackupFull_Click(object sender, EventArgs e)
        {
            if (bc_rt_bll.BackupFull(defaultFolderPath))
            {
                MessageBox.Show("Backup database thành công!!!", "Thông báo");
                return;
            }
            else
            {
                MessageBox.Show("Backup database thất bại!!!", "Thông báo");
                return;
            }

        }
        public void Load_FileRestore()
        {
            dtgv_Restore.Rows.Clear();
            // Kiểm tra xem thư mục mặc định có tồn tại không
            if (Directory.Exists(defaultFolderPath))
            {
                // Lấy danh sách các tệp tin .bak trong thư mục mặc định
                string[] files = Directory.GetFiles(defaultFolderPath, "*.bak");

                // Thêm tên tệp tin và đường dẫn vào DataGridView
                foreach (string file in files)
                {
                    //dtgv_Restore.Rows.Add(Path.GetFileName(file), Path.GetDirectoryName(file));
                    dtgv_Restore.Rows.Add(Path.GetFileName(file), file);
                }
            }
            else
            {
                // Hiển thị thông báo nếu thư mục mặc định không tồn tại
                MessageBox.Show("The default folder does not exist. Please choose a folder manually.");

                // Hiển thị hộp thoại để chọn thư mục chứa các tệp tin .bak
                FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
                folderBrowserDialog.Description = "Select the folder containing the .bak files";

                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    // Lấy thư mục được chọn
                    string selectedFolder = folderBrowserDialog.SelectedPath;

                    // Khởi tạo DataTable để lưu danh sách các tệp tin .bak
                    DataTable dataTable = new DataTable();
                    DataColumn fileNameColumn = new DataColumn("File Name");
                    DataColumn filePathColumn = new DataColumn("File Path");
                    dataTable.Columns.Add(fileNameColumn);
                    dataTable.Columns.Add(filePathColumn);

                    // Lấy danh sách các tệp tin .bak trong thư mục được chọn
                    string[] files = Directory.GetFiles(selectedFolder, "*.bak");
                    foreach (string file in files)
                    {
                        // Thêm tên tệp tin và đường dẫn vào DataTable
                        dataTable.Rows.Add(Path.GetFileName(file), file);
                    }

                    // Gán DataTable làm nguồn dữ liệu cho DataGridView
                    dtgv_Restore.DataSource = dataTable;
                }
            }
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            Load_FileRestore();
        }

        private void RestoreFull_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem có hàng nào được chọn trong DataGridView hay không
            if (dtgv_Restore.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn file backup để phục hồi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Lấy đường dẫn file backup từ hàng được chọn
            DataGridViewRow selectedRow = dtgv_Restore.SelectedRows[0];
            string backupPath = selectedRow.Cells["BackupFilePath"].Value.ToString();

            // Tên cơ sở dữ liệu từ kết nối hiện tại
            string database = conn.StrDataBaseName.ToString();

            // Tạo đối tượng DAL và gọi phương thức restore
            bool result = bc_rt_bll.RestoreFull(backupPath, database);

            // Hiển thị thông báo dựa trên kết quả
            if (result)
            {
                MessageBox.Show("Khôi phục dữ liệu thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Khôi phục dữ liệu không thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dtgv_Restore_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0 && e.RowIndex < dtgv_Restore.Rows.Count)
            {
                dtgv_Restore.Rows[e.RowIndex].Selected = true;
            }
        }
    }
}
