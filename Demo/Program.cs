using GUI;

namespace Demo
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            string tk = "";
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            //Application.Run(new FrmMain(tk));
            //Application.Run(new FrmSaoLuuPhucHoi());
            //Application.Run(new FrmRegister());
            Application.Run(new FrmLogin());
            //Application.Run(new FrmNhanVien());
            //application.run(new frmphanquyen());
            //Application.Run(new FrmPhongBan());
            //Application.Run(new FrmChuyenKhoa());
            //Application.Run(new FrmLich());
            //Application.Run(new FrmChiTietThuoc());
            //Application.Run(new FrmLoaiThuoc());
            //Application.Run(new FrmLoaiTBYT());
            //Application.Run(new FrmBenhAn());
            //Application.Run(new FrmNhapThuoc());


        }
    }
}