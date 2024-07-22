using Microsoft.Reporting.WinForms;
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

namespace GUI
{
    public partial class FrmXQuang : Form
    {
        private int MaDichVu;
        private int MaKhamBenh;

        public FrmXQuang(int MaDichVu, int maKhamBenh)
        {
            InitializeComponent();
            this.MaDichVu = MaDichVu;
            this.MaKhamBenh = maKhamBenh;

        }

        private void FrmXQuang_Load(object sender, EventArgs e)
        {
            string connectionString = @"Server=LAPTOP-FRMKN0GD\TIEN;Database=QL_KHAMBENH;User Id=sa;Password=123;Encrypt=true;TrustServerCertificate=true;";
            string query = @"SELECT 
                                    bn.HoTenBN,
                                    bn.GioiTinh,
                                    DATEDIFF(YEAR, bn.NgaySinh, GETDATE()), 
                                    ct.NgayThucHien,
                                    ck.TenChuyenKhoa,
                                    nv.HoTen,
                                    ct.ChiTiet,
                                    ct.KetQua
                                FROM 
                                    BenhNhan bn
                                JOIN 
                                    KhamBenh kb ON kb.MaBN = bn.MaBN
                                JOIN 
                                    CT_DichVu ct ON ct.MaKhamBenh = kb.MaKhamBenh
                                JOIN 
                                    DichVu dv ON dv.MaDichVu = ct.MaDichVu
                                JOIN 
                                    ChuyenKhoa ck ON dv.MaChuyenKhoa = ck.MaChuyenKhoa
                                JOIN 
                                    LichLamViec llv ON kb.MaLichLamViec = llv.MaLichLamViec
                                JOIN 
                                    NhanVien nv ON nv.MaNV = llv.MaNV
                                WHERE 
                                    kb.MaKhamBenh = @MaKhamBenh and dv.MaDichVu = @MaDichVu;";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    adapter.SelectCommand.Parameters.AddWithValue("@MaKhamBenh", MaKhamBenh); // Gán giá trị cho tham số @MaBN
                    adapter.SelectCommand.Parameters.AddWithValue("@MaDichVu", MaDichVu); // Gán giá trị cho tham số @MaBN

                    DataSet dataSet = new DataSet();
                    adapter.Fill(dataSet, "DataSet1");

                    //    //Thiết lập nguồn dữ liệu cho báo cáo
                    ReportDataSource reportDataSource = new ReportDataSource("DataSet1", dataSet.Tables["DataSet1"]);


                // Gán nguồn dữ liệu cho ReportViewer
                reportViewer1.LocalReport.DataSources.Clear();
                    reportViewer1.LocalReport.DataSources.Add(reportDataSource);
                    reportViewer1.LocalReport.ReportEmbeddedResource = "GUI.Report.XQuang.rdlc"; // Đảm bảo tên file báo cáo đúng
                    reportViewer1.RefreshReport();
            }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading report: {ex.Message}");
            }
        }
    }
}
