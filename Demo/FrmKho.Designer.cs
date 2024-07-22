namespace GUI
{
    partial class FrmKho
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.cbb_LoaiThuoc = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_DonViTinh = new Demo.Controls.TextBox_NTT();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_SoLuong = new Demo.Controls.TextBox_NTT();
            this.txt_MaThuoc = new Demo.Controls.TextBox_NTT();
            this.txt_DonGia = new Demo.Controls.TextBox_NTT();
            this.txt_TenThuoc = new Demo.Controls.TextBox_NTT();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtgv_Kho = new System.Windows.Forms.DataGridView();
            this.MaThuoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenThuoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGiaBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonViTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.cbb_LoaiTBYT = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_ntt1 = new Demo.Controls.TextBox_NTT();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox_ntt2 = new Demo.Controls.TextBox_NTT();
            this.textBox_ntt3 = new Demo.Controls.TextBox_NTT();
            this.textBox_ntt4 = new Demo.Controls.TextBox_NTT();
            this.textBox_ntt5 = new Demo.Controls.TextBox_NTT();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtgv_KhoTBYT = new System.Windows.Forms.DataGridView();
            this.MaTBYT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenTBYT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonViTinhTBYT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TonKho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_Kho)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_KhoTBYT)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1139, 953);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.cbb_LoaiThuoc);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.txt_DonViTinh);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.txt_SoLuong);
            this.tabPage1.Controls.Add(this.txt_MaThuoc);
            this.tabPage1.Controls.Add(this.txt_DonGia);
            this.tabPage1.Controls.Add(this.txt_TenThuoc);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1131, 920);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Kho thuốc";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 308);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 20);
            this.label1.TabIndex = 40;
            this.label1.Text = "Loại thuốc";
            // 
            // cbb_LoaiThuoc
            // 
            this.cbb_LoaiThuoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_LoaiThuoc.FormattingEnabled = true;
            this.cbb_LoaiThuoc.Location = new System.Drawing.Point(87, 304);
            this.cbb_LoaiThuoc.Name = "cbb_LoaiThuoc";
            this.cbb_LoaiThuoc.Size = new System.Drawing.Size(280, 28);
            this.cbb_LoaiThuoc.TabIndex = 39;
            this.cbb_LoaiThuoc.SelectedIndexChanged += new System.EventHandler(this.cbb_LoaiThuoc_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(358, 103);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 20);
            this.label9.TabIndex = 38;
            this.label9.Text = "Đơn vị tính:";
            // 
            // txt_DonViTinh
            // 
            this.txt_DonViTinh.BackColor = System.Drawing.SystemColors.Window;
            this.txt_DonViTinh.BorderColor = System.Drawing.Color.Black;
            this.txt_DonViTinh.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txt_DonViTinh.BorderRadius = 5;
            this.txt_DonViTinh.BorderSize = 1;
            this.txt_DonViTinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_DonViTinh.Location = new System.Drawing.Point(447, 93);
            this.txt_DonViTinh.Margin = new System.Windows.Forms.Padding(4);
            this.txt_DonViTinh.Multiline = true;
            this.txt_DonViTinh.Name = "txt_DonViTinh";
            this.txt_DonViTinh.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txt_DonViTinh.PasswordChar = false;
            this.txt_DonViTinh.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_DonViTinh.PlaceholderText = "";
            this.txt_DonViTinh.Size = new System.Drawing.Size(200, 35);
            this.txt_DonViTinh.TabIndex = 37;
            this.txt_DonViTinh.UnderlinedStyle = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 20);
            this.label4.TabIndex = 33;
            this.label4.Text = "Mã thuốc:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(358, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 20);
            this.label5.TabIndex = 32;
            this.label5.Text = "Tồn kho:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 20);
            this.label3.TabIndex = 31;
            this.label3.Text = "Đơn giá:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 20);
            this.label2.TabIndex = 30;
            this.label2.Text = "Tên thuốc:";
            // 
            // txt_SoLuong
            // 
            this.txt_SoLuong.BackColor = System.Drawing.SystemColors.Window;
            this.txt_SoLuong.BorderColor = System.Drawing.Color.Black;
            this.txt_SoLuong.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txt_SoLuong.BorderRadius = 5;
            this.txt_SoLuong.BorderSize = 1;
            this.txt_SoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_SoLuong.Location = new System.Drawing.Point(447, 40);
            this.txt_SoLuong.Margin = new System.Windows.Forms.Padding(4);
            this.txt_SoLuong.Multiline = true;
            this.txt_SoLuong.Name = "txt_SoLuong";
            this.txt_SoLuong.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txt_SoLuong.PasswordChar = false;
            this.txt_SoLuong.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_SoLuong.PlaceholderText = "";
            this.txt_SoLuong.Size = new System.Drawing.Size(200, 35);
            this.txt_SoLuong.TabIndex = 29;
            this.txt_SoLuong.UnderlinedStyle = false;
            // 
            // txt_MaThuoc
            // 
            this.txt_MaThuoc.BackColor = System.Drawing.SystemColors.Window;
            this.txt_MaThuoc.BorderColor = System.Drawing.Color.Black;
            this.txt_MaThuoc.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txt_MaThuoc.BorderRadius = 5;
            this.txt_MaThuoc.BorderSize = 1;
            this.txt_MaThuoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_MaThuoc.Location = new System.Drawing.Point(115, 40);
            this.txt_MaThuoc.Margin = new System.Windows.Forms.Padding(4);
            this.txt_MaThuoc.Multiline = true;
            this.txt_MaThuoc.Name = "txt_MaThuoc";
            this.txt_MaThuoc.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txt_MaThuoc.PasswordChar = false;
            this.txt_MaThuoc.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_MaThuoc.PlaceholderText = "";
            this.txt_MaThuoc.Size = new System.Drawing.Size(200, 35);
            this.txt_MaThuoc.TabIndex = 27;
            this.txt_MaThuoc.UnderlinedStyle = false;
            // 
            // txt_DonGia
            // 
            this.txt_DonGia.BackColor = System.Drawing.SystemColors.Window;
            this.txt_DonGia.BorderColor = System.Drawing.Color.Black;
            this.txt_DonGia.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txt_DonGia.BorderRadius = 5;
            this.txt_DonGia.BorderSize = 1;
            this.txt_DonGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_DonGia.Location = new System.Drawing.Point(115, 134);
            this.txt_DonGia.Margin = new System.Windows.Forms.Padding(4);
            this.txt_DonGia.Multiline = true;
            this.txt_DonGia.Name = "txt_DonGia";
            this.txt_DonGia.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txt_DonGia.PasswordChar = false;
            this.txt_DonGia.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_DonGia.PlaceholderText = "";
            this.txt_DonGia.Size = new System.Drawing.Size(200, 35);
            this.txt_DonGia.TabIndex = 26;
            this.txt_DonGia.UnderlinedStyle = false;
            // 
            // txt_TenThuoc
            // 
            this.txt_TenThuoc.BackColor = System.Drawing.SystemColors.Window;
            this.txt_TenThuoc.BorderColor = System.Drawing.Color.Black;
            this.txt_TenThuoc.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txt_TenThuoc.BorderRadius = 5;
            this.txt_TenThuoc.BorderSize = 1;
            this.txt_TenThuoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_TenThuoc.Location = new System.Drawing.Point(115, 87);
            this.txt_TenThuoc.Margin = new System.Windows.Forms.Padding(4);
            this.txt_TenThuoc.Multiline = true;
            this.txt_TenThuoc.Name = "txt_TenThuoc";
            this.txt_TenThuoc.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txt_TenThuoc.PasswordChar = false;
            this.txt_TenThuoc.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_TenThuoc.PlaceholderText = "";
            this.txt_TenThuoc.Size = new System.Drawing.Size(200, 35);
            this.txt_TenThuoc.TabIndex = 25;
            this.txt_TenThuoc.UnderlinedStyle = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtgv_Kho);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(3, 357);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1125, 560);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách thuốc tồn kho";
            // 
            // dtgv_Kho
            // 
            this.dtgv_Kho.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgv_Kho.BackgroundColor = System.Drawing.Color.White;
            this.dtgv_Kho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_Kho.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaThuoc,
            this.TenThuoc,
            this.DonGiaBan,
            this.DonViTinh,
            this.SoLuong});
            this.dtgv_Kho.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dtgv_Kho.Location = new System.Drawing.Point(3, 26);
            this.dtgv_Kho.Name = "dtgv_Kho";
            this.dtgv_Kho.RowHeadersWidth = 51;
            this.dtgv_Kho.RowTemplate.Height = 29;
            this.dtgv_Kho.Size = new System.Drawing.Size(1119, 531);
            this.dtgv_Kho.TabIndex = 0;
            this.dtgv_Kho.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_Kho_CellClick);
            // 
            // MaThuoc
            // 
            this.MaThuoc.HeaderText = "Mã thuốc";
            this.MaThuoc.MinimumWidth = 6;
            this.MaThuoc.Name = "MaThuoc";
            // 
            // TenThuoc
            // 
            this.TenThuoc.HeaderText = "Tên thuốc";
            this.TenThuoc.MinimumWidth = 6;
            this.TenThuoc.Name = "TenThuoc";
            // 
            // DonGiaBan
            // 
            this.DonGiaBan.HeaderText = "Đơn giá (VND)";
            this.DonGiaBan.MinimumWidth = 6;
            this.DonGiaBan.Name = "DonGiaBan";
            // 
            // DonViTinh
            // 
            this.DonViTinh.HeaderText = "Đơn vị tính";
            this.DonViTinh.MinimumWidth = 6;
            this.DonViTinh.Name = "DonViTinh";
            // 
            // SoLuong
            // 
            this.SoLuong.HeaderText = "Tồn kho";
            this.SoLuong.MinimumWidth = 6;
            this.SoLuong.Name = "SoLuong";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.cbb_LoaiTBYT);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.textBox_ntt1);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.textBox_ntt2);
            this.tabPage2.Controls.Add(this.textBox_ntt3);
            this.tabPage2.Controls.Add(this.textBox_ntt4);
            this.tabPage2.Controls.Add(this.textBox_ntt5);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1131, 920);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Kho thiết bị y tế";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 306);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 20);
            this.label6.TabIndex = 53;
            this.label6.Text = "Loại thiết bị y tế";
            // 
            // cbb_LoaiTBYT
            // 
            this.cbb_LoaiTBYT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_LoaiTBYT.FormattingEnabled = true;
            this.cbb_LoaiTBYT.Location = new System.Drawing.Point(134, 303);
            this.cbb_LoaiTBYT.Name = "cbb_LoaiTBYT";
            this.cbb_LoaiTBYT.Size = new System.Drawing.Size(280, 28);
            this.cbb_LoaiTBYT.TabIndex = 52;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(358, 85);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 20);
            this.label7.TabIndex = 51;
            this.label7.Text = "Đơn vị tính:";
            // 
            // textBox_ntt1
            // 
            this.textBox_ntt1.BackColor = System.Drawing.SystemColors.Window;
            this.textBox_ntt1.BorderColor = System.Drawing.Color.Black;
            this.textBox_ntt1.BorderFocusColor = System.Drawing.Color.HotPink;
            this.textBox_ntt1.BorderRadius = 5;
            this.textBox_ntt1.BorderSize = 1;
            this.textBox_ntt1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox_ntt1.Location = new System.Drawing.Point(447, 75);
            this.textBox_ntt1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_ntt1.Multiline = true;
            this.textBox_ntt1.Name = "textBox_ntt1";
            this.textBox_ntt1.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.textBox_ntt1.PasswordChar = false;
            this.textBox_ntt1.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.textBox_ntt1.PlaceholderText = "";
            this.textBox_ntt1.Size = new System.Drawing.Size(200, 35);
            this.textBox_ntt1.TabIndex = 50;
            this.textBox_ntt1.UnderlinedStyle = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 30);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 20);
            this.label8.TabIndex = 49;
            this.label8.Text = "Mã TBYT:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(358, 32);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 20);
            this.label10.TabIndex = 48;
            this.label10.Text = "Tồn kho:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(19, 126);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 20);
            this.label11.TabIndex = 47;
            this.label11.Text = "Đơn giá:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(8, 79);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(72, 20);
            this.label12.TabIndex = 46;
            this.label12.Text = "Tên TBYT:";
            // 
            // textBox_ntt2
            // 
            this.textBox_ntt2.BackColor = System.Drawing.SystemColors.Window;
            this.textBox_ntt2.BorderColor = System.Drawing.Color.Black;
            this.textBox_ntt2.BorderFocusColor = System.Drawing.Color.HotPink;
            this.textBox_ntt2.BorderRadius = 5;
            this.textBox_ntt2.BorderSize = 1;
            this.textBox_ntt2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox_ntt2.Location = new System.Drawing.Point(447, 22);
            this.textBox_ntt2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_ntt2.Multiline = true;
            this.textBox_ntt2.Name = "textBox_ntt2";
            this.textBox_ntt2.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.textBox_ntt2.PasswordChar = false;
            this.textBox_ntt2.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.textBox_ntt2.PlaceholderText = "";
            this.textBox_ntt2.Size = new System.Drawing.Size(200, 35);
            this.textBox_ntt2.TabIndex = 45;
            this.textBox_ntt2.UnderlinedStyle = false;
            // 
            // textBox_ntt3
            // 
            this.textBox_ntt3.BackColor = System.Drawing.SystemColors.Window;
            this.textBox_ntt3.BorderColor = System.Drawing.Color.Black;
            this.textBox_ntt3.BorderFocusColor = System.Drawing.Color.HotPink;
            this.textBox_ntt3.BorderRadius = 5;
            this.textBox_ntt3.BorderSize = 1;
            this.textBox_ntt3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox_ntt3.Location = new System.Drawing.Point(115, 22);
            this.textBox_ntt3.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_ntt3.Multiline = true;
            this.textBox_ntt3.Name = "textBox_ntt3";
            this.textBox_ntt3.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.textBox_ntt3.PasswordChar = false;
            this.textBox_ntt3.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.textBox_ntt3.PlaceholderText = "";
            this.textBox_ntt3.Size = new System.Drawing.Size(200, 35);
            this.textBox_ntt3.TabIndex = 44;
            this.textBox_ntt3.UnderlinedStyle = false;
            // 
            // textBox_ntt4
            // 
            this.textBox_ntt4.BackColor = System.Drawing.SystemColors.Window;
            this.textBox_ntt4.BorderColor = System.Drawing.Color.Black;
            this.textBox_ntt4.BorderFocusColor = System.Drawing.Color.HotPink;
            this.textBox_ntt4.BorderRadius = 5;
            this.textBox_ntt4.BorderSize = 1;
            this.textBox_ntt4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox_ntt4.Location = new System.Drawing.Point(115, 116);
            this.textBox_ntt4.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_ntt4.Multiline = true;
            this.textBox_ntt4.Name = "textBox_ntt4";
            this.textBox_ntt4.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.textBox_ntt4.PasswordChar = false;
            this.textBox_ntt4.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.textBox_ntt4.PlaceholderText = "";
            this.textBox_ntt4.Size = new System.Drawing.Size(200, 35);
            this.textBox_ntt4.TabIndex = 43;
            this.textBox_ntt4.UnderlinedStyle = false;
            // 
            // textBox_ntt5
            // 
            this.textBox_ntt5.BackColor = System.Drawing.SystemColors.Window;
            this.textBox_ntt5.BorderColor = System.Drawing.Color.Black;
            this.textBox_ntt5.BorderFocusColor = System.Drawing.Color.HotPink;
            this.textBox_ntt5.BorderRadius = 5;
            this.textBox_ntt5.BorderSize = 1;
            this.textBox_ntt5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox_ntt5.Location = new System.Drawing.Point(115, 69);
            this.textBox_ntt5.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_ntt5.Multiline = true;
            this.textBox_ntt5.Name = "textBox_ntt5";
            this.textBox_ntt5.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.textBox_ntt5.PasswordChar = false;
            this.textBox_ntt5.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.textBox_ntt5.PlaceholderText = "";
            this.textBox_ntt5.Size = new System.Drawing.Size(200, 35);
            this.textBox_ntt5.TabIndex = 42;
            this.textBox_ntt5.UnderlinedStyle = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtgv_KhoTBYT);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Location = new System.Drawing.Point(3, 357);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1125, 560);
            this.groupBox2.TabIndex = 41;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách thuốc tồn kho";
            // 
            // dtgv_KhoTBYT
            // 
            this.dtgv_KhoTBYT.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgv_KhoTBYT.BackgroundColor = System.Drawing.Color.White;
            this.dtgv_KhoTBYT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_KhoTBYT.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaTBYT,
            this.TenTBYT,
            this.DonGia,
            this.DonViTinhTBYT,
            this.TonKho});
            this.dtgv_KhoTBYT.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dtgv_KhoTBYT.Location = new System.Drawing.Point(3, 26);
            this.dtgv_KhoTBYT.Name = "dtgv_KhoTBYT";
            this.dtgv_KhoTBYT.RowHeadersWidth = 51;
            this.dtgv_KhoTBYT.RowTemplate.Height = 29;
            this.dtgv_KhoTBYT.Size = new System.Drawing.Size(1119, 531);
            this.dtgv_KhoTBYT.TabIndex = 0;
            // 
            // MaTBYT
            // 
            this.MaTBYT.HeaderText = "Mã TBYT";
            this.MaTBYT.MinimumWidth = 6;
            this.MaTBYT.Name = "MaTBYT";
            // 
            // TenTBYT
            // 
            this.TenTBYT.HeaderText = "Tên TBYT";
            this.TenTBYT.MinimumWidth = 6;
            this.TenTBYT.Name = "TenTBYT";
            // 
            // DonGia
            // 
            this.DonGia.HeaderText = "Đơn giá (VND)";
            this.DonGia.MinimumWidth = 6;
            this.DonGia.Name = "DonGia";
            // 
            // DonViTinhTBYT
            // 
            this.DonViTinhTBYT.HeaderText = "Đơn vị tính";
            this.DonViTinhTBYT.MinimumWidth = 6;
            this.DonViTinhTBYT.Name = "DonViTinhTBYT";
            // 
            // TonKho
            // 
            this.TonKho.HeaderText = "Tồn kho";
            this.TonKho.MinimumWidth = 6;
            this.TonKho.Name = "TonKho";
            // 
            // FrmKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1139, 953);
            this.Controls.Add(this.tabControl1);
            this.Name = "FrmKho";
            this.Text = "FrmKho";
            this.Load += new System.EventHandler(this.FrmKho_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_Kho)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_KhoTBYT)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private GroupBox groupBox1;
        private DataGridView dtgv_Kho;
        private Label label9;
        private Demo.Controls.TextBox_NTT txt_DonViTinh;
        private Label label4;
        private Label label5;
        private Label label3;
        private Label label2;
        private Demo.Controls.TextBox_NTT txt_SoLuong;
        private Demo.Controls.TextBox_NTT txt_MaThuoc;
        private Demo.Controls.TextBox_NTT txt_DonGia;
        private Demo.Controls.TextBox_NTT txt_TenThuoc;
        private DataGridViewTextBoxColumn MaThuoc;
        private DataGridViewTextBoxColumn TenThuoc;
        private DataGridViewTextBoxColumn DonGiaBan;
        private DataGridViewTextBoxColumn DonViTinh;
        private DataGridViewTextBoxColumn SoLuong;
        private Label label1;
        private ComboBox cbb_LoaiThuoc;
        private Label label6;
        private ComboBox cbb_LoaiTBYT;
        private Label label7;
        private Demo.Controls.TextBox_NTT textBox_ntt1;
        private Label label8;
        private Label label10;
        private Label label11;
        private Label label12;
        private Demo.Controls.TextBox_NTT textBox_ntt2;
        private Demo.Controls.TextBox_NTT textBox_ntt3;
        private Demo.Controls.TextBox_NTT textBox_ntt4;
        private Demo.Controls.TextBox_NTT textBox_ntt5;
        private GroupBox groupBox2;
        private DataGridView dtgv_KhoTBYT;
        private DataGridViewTextBoxColumn MaTBYT;
        private DataGridViewTextBoxColumn TenTBYT;
        private DataGridViewTextBoxColumn DonGia;
        private DataGridViewTextBoxColumn DonViTinhTBYT;
        private DataGridViewTextBoxColumn TonKho;
    }
}