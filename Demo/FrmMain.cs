using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using MaterialSkin.Controls;
using MaterialSkin;
using DAL;
using GUI;
using BLL;
using DTO;

namespace Demo
{
    public partial class FrmMain : Form
    {
        bool sidebarExpand;
        bool SubMeNuDanhMuc;
        bool SubMeNuCaiDat;
        bool SubMeNuThuoc;
        bool SubMeNuTBYT;

        private string sdt;
        NhanVien_BLL nv_bll = new NhanVien_BLL();
        private NhanVien_DTO nhanVien;
        //public FrmMain()
        //{
        //    this.IsMdiContainer = true;
        //}

        public FrmMain(NhanVien_DTO nv)
        {
            InitializeComponent();
            this.IsMdiContainer = true;
            this.WindowState = FormWindowState.Maximized;
            this.nhanVien = nv_bll.getNhanVienSDT(nv.SDT);
            lb_Ten.Text = nv_bll.getNhanVienBySDT(nhanVien.SDT);
        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        public void đăngNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmLogin f = new FrmLogin();
            f.MdiParent = this;
            f.Show();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void saoLưuPhụcHồiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSaoLuuPhucHoi f = new FrmSaoLuuPhucHoi();
            f.MdiParent = this;
            f.Show();
        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //FrmNhanVien f = new FrmNhanVien();
            //f.MdiParent = this;
            //f.Show();
        }

        private void btn_Dashboard_Click(object sender, EventArgs e)
        {
            FrmLogin f = new FrmLogin();
            f.MdiParent = this;
            f.Show();
        }

        private void btn_DanhMuc_Timer_Tick(object sender, EventArgs e)
        {
            if (SubMeNuDanhMuc)
            {
                pn_DanhMuc.Height += 10;
                if (pn_DanhMuc.Height == pn_DanhMuc.MaximumSize.Height)
                {
                    SubMeNuDanhMuc = false;
                    btn_DanhMuc_Timer.Stop();
                }
            }
            else
            {
                pn_DanhMuc.Height -= 10;
                if (pn_DanhMuc.Height == pn_DanhMuc.MinimumSize.Height)
                {
                    SubMeNuDanhMuc = true;
                    btn_DanhMuc_Timer.Stop();
                }
            }
        }

        private void btn_Menu_NhanVien_Click_1(object sender, EventArgs e)
        {
            Form_load(new FrmNhanVien());
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_Maxsize_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.Width = 1200;
                this.Height = 900;
                this.WindowState = FormWindowState.Normal;
                //this.StartPosition = FormStartPosition.CenterScreen;
            }
            else
            {
                //this.StartPosition = FormStartPosition.CenterScreen;
                this.WindowState = FormWindowState.Maximized;

            }
        }

        private void btn_PhongBan_Click(object sender, EventArgs e)
        {
            Form_load(new FrmPhongBan());
        }

        private void Form_load(object form)
        {
            if (this.pn_Main.Controls.Count > 0)
                this.pn_Main.Controls.RemoveAt(0);
            Form f = form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.pn_Main.Controls.Add(f);
            this.pn_Main.Tag = f;
            f.Show();
        }

        private void btn_ChuyenKhoa_Click(object sender, EventArgs e)
        {
            Form_load(new FrmChuyenKhoa());
        }

        private void btn_CaiDat_Click(object sender, EventArgs e)
        {
            btn_CaiDat_Timer.Start();
        }

        private void btn_BenhAn_Click(object sender, EventArgs e)
        {
            Form_load(new FrmBenhAn());

        }

        private void sidebarTimer_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                sidebar.Width -= 10;
                if (sidebar.Width == sidebar.MinimumSize.Width)
                {
                    sidebarExpand = false;
                    sidebarTimer.Stop();
                }
            }
            else
            {
                sidebar.Width += 10;
                if (sidebar.Width == sidebar.MaximumSize.Width)
                {
                    sidebarExpand = true;
                    sidebarTimer.Stop();
                }
            }
        }

        private void btn_DanhMuc_Click(object sender, EventArgs e)
        {
            btn_DanhMuc_Timer.Start();
        }

        private void btn_HoSoBenhAn_Click(object sender, EventArgs e)
        {
            Form_load(new FrmBenhAn());
        }

        private void btn_Menu_Click(object sender, EventArgs e)
        {
            sidebarTimer.Start();
        }

        private void btn_PhanQuyen_Click(object sender, EventArgs e)
        {
            Form_load(new FrmPhanQuyen());
        }

        private void btn_SaoLuuPhucHoi_Click(object sender, EventArgs e)
        {
            //Form_load(new FrmSaoLuuPhucHoi());
            FrmSaoLuuPhucHoi f = new FrmSaoLuuPhucHoi();
            f.Show();
        }

        private void btn_Thuoc_Click(object sender, EventArgs e)
        {
            btn_Thuoc_Timer.Start();
        }

        private void btn_TBYT_Click(object sender, EventArgs e)
        {
            btn_TBYT_Timer.Start();

        }

        private void btn_DichVu_Click(object sender, EventArgs e)
        {
            Form_load(new FrmDichVu());
        }

        private void btn_Thuoc_Timer_Tick(object sender, EventArgs e)
        {
            if (SubMeNuThuoc)
            {
                pn_Thuoc.Height -= 10;
                if (pn_Thuoc.Height  == pn_Thuoc.MinimumSize.Height)
                {
                    SubMeNuThuoc = false;
                    btn_Thuoc_Timer.Stop();
                }
            }
            else
            {
                pn_Thuoc.Height += 10;
                if (pn_Thuoc.Height == pn_Thuoc.MaximumSize.Height)
                {
                    SubMeNuThuoc = true;
                    btn_Thuoc_Timer.Stop();
                }
            }
        }

        private void btn_CaiDat_Timer_Tick(object sender, EventArgs e)
        {
            if (SubMeNuCaiDat)
            {
                pn_CaiDat.Height += 10;
                if (pn_CaiDat.Height == pn_CaiDat.MaximumSize.Height)
                {
                    SubMeNuCaiDat = false;
                    btn_CaiDat_Timer.Stop();
                }
            }
            else
            {
                pn_CaiDat.Height -= 10;
                if (pn_CaiDat.Height == pn_CaiDat.MinimumSize.Height)
                {
                    SubMeNuCaiDat = true;
                    btn_CaiDat_Timer.Stop();
                }
            }
        }
        private void btn_LoaiThuoc_Click(object sender, EventArgs e)
        {
            Form_load(new FrmLoaiThuoc());
        }

        private void btn_ChiTietThuoc_Click(object sender, EventArgs e)
        {
            Form_load(new FrmChiTietThuoc());
        }

        private void btn_TBYT_Timer_Tick(object sender, EventArgs e)
        {
            if (SubMeNuTBYT)
            {
                pn_TBYT.Height += 10;
                if (pn_TBYT.Height == pn_TBYT.MaximumSize.Height)
                {
                    SubMeNuTBYT = false;
                    btn_TBYT_Timer.Stop();
                }
            }
            else
            {
                pn_TBYT.Height -= 10;
                if (pn_TBYT.Height == pn_TBYT.MinimumSize.Height)
                {
                    SubMeNuTBYT = true;
                    btn_TBYT_Timer.Stop();
                }
            }
        }

        private void btn_LoaiTBYT_Click(object sender, EventArgs e)
        {
            Form_load(new FrmLoaiTBYT());
        }

        private void btn_DangXuat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn đăng xuất không?", "Xác nhận đăng xuất", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                FrmLogin flg = new FrmLogin();
                flg.Show();
                this.Hide();
            }
            else
            {
                return;
            }
        }

        private void btn_DoiMatKhau_Click(object sender, EventArgs e)
        {
            FrmDoiMatKhau f = new FrmDoiMatKhau();
            f.Show();
            //this.Hide();

        }

        private void btn_NhapThuoc_Click(object sender, EventArgs e)
        {
            //Form_load(new FrmNhapThuoc(this.nhanVien));
            FrmNhapThuoc frmNhapThuoc = new FrmNhapThuoc(this.nhanVien);
            Form_load(frmNhapThuoc);
        }

        private void btn_Kho_Click(object sender, EventArgs e)
        {
            Form_load(new FrmKho());

        }

        private void btn_NhapTBYT_Click(object sender, EventArgs e)
        {
            FrmNhapTBYT frmNhapTBYT = new FrmNhapTBYT(this.nhanVien);
            Form_load(frmNhapTBYT);
        }
    }
}