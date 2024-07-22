namespace GUI
{
    partial class FrmNhapTBYT
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNhapTBYT));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripBtn_ThemPhieuNhap = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtn_Refresh = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtn_Thoat = new System.Windows.Forms.ToolStripButton();
            this.txt_SoLuong = new System.Windows.Forms.TextBox();
            this.txt_DonViTinh = new Demo.Controls.TextBox_NTT();
            this.date_NgayNhap = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_DonGia = new Demo.Controls.TextBox_NTT();
            this.txt_TenTBYT = new Demo.Controls.TextBox_NTT();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtgv_TBYT = new System.Windows.Forms.DataGridView();
            this.TenTBYT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonViTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbb_LoaiTBYT = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_TongTien = new Demo.Controls.TextBox_NTT();
            this.btn_Them = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtgv_PhieuNhap = new System.Windows.Forms.DataGridView();
            this.pn_TenThuoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pn_DonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pn_SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pn_DonViTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_TBYT)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_PhieuNhap)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(117)))), ((int)(((byte)(220)))));
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripBtn_ThemPhieuNhap,
            this.toolStripBtn_Refresh,
            this.toolStripBtn_Thoat});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0);
            this.toolStrip1.Size = new System.Drawing.Size(1465, 50);
            this.toolStrip1.TabIndex = 21;
            // 
            // toolStripBtn_ThemPhieuNhap
            // 
            this.toolStripBtn_ThemPhieuNhap.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.toolStripBtn_ThemPhieuNhap.ForeColor = System.Drawing.Color.White;
            this.toolStripBtn_ThemPhieuNhap.Image = global::GUI.Properties.Resources.plus;
            this.toolStripBtn_ThemPhieuNhap.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtn_ThemPhieuNhap.Name = "toolStripBtn_ThemPhieuNhap";
            this.toolStripBtn_ThemPhieuNhap.Size = new System.Drawing.Size(117, 47);
            this.toolStripBtn_ThemPhieuNhap.Text = "Nhập TBYT";
            this.toolStripBtn_ThemPhieuNhap.Click += new System.EventHandler(this.toolStripBtn_ThemPhieuNhap_Click);
            // 
            // toolStripBtn_Refresh
            // 
            this.toolStripBtn_Refresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(117)))), ((int)(((byte)(220)))));
            this.toolStripBtn_Refresh.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.toolStripBtn_Refresh.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.toolStripBtn_Refresh.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtn_Refresh.Image")));
            this.toolStripBtn_Refresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtn_Refresh.Name = "toolStripBtn_Refresh";
            this.toolStripBtn_Refresh.Padding = new System.Windows.Forms.Padding(10);
            this.toolStripBtn_Refresh.Size = new System.Drawing.Size(115, 47);
            this.toolStripBtn_Refresh.Text = " Refresh";
            // 
            // toolStripBtn_Thoat
            // 
            this.toolStripBtn_Thoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(117)))), ((int)(((byte)(220)))));
            this.toolStripBtn_Thoat.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.toolStripBtn_Thoat.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.toolStripBtn_Thoat.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtn_Thoat.Image")));
            this.toolStripBtn_Thoat.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtn_Thoat.Name = "toolStripBtn_Thoat";
            this.toolStripBtn_Thoat.Padding = new System.Windows.Forms.Padding(10);
            this.toolStripBtn_Thoat.Size = new System.Drawing.Size(103, 47);
            this.toolStripBtn_Thoat.Text = " Thoát";
            // 
            // txt_SoLuong
            // 
            this.txt_SoLuong.Location = new System.Drawing.Point(416, 394);
            this.txt_SoLuong.Name = "txt_SoLuong";
            this.txt_SoLuong.Size = new System.Drawing.Size(200, 27);
            this.txt_SoLuong.TabIndex = 51;
            // 
            // txt_DonViTinh
            // 
            this.txt_DonViTinh.BackColor = System.Drawing.SystemColors.Window;
            this.txt_DonViTinh.BorderColor = System.Drawing.Color.Black;
            this.txt_DonViTinh.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txt_DonViTinh.BorderRadius = 5;
            this.txt_DonViTinh.BorderSize = 1;
            this.txt_DonViTinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_DonViTinh.Location = new System.Drawing.Point(99, 491);
            this.txt_DonViTinh.Margin = new System.Windows.Forms.Padding(4);
            this.txt_DonViTinh.Multiline = true;
            this.txt_DonViTinh.Name = "txt_DonViTinh";
            this.txt_DonViTinh.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txt_DonViTinh.PasswordChar = false;
            this.txt_DonViTinh.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_DonViTinh.PlaceholderText = "";
            this.txt_DonViTinh.Size = new System.Drawing.Size(200, 35);
            this.txt_DonViTinh.TabIndex = 50;
            this.txt_DonViTinh.UnderlinedStyle = false;
            // 
            // date_NgayNhap
            // 
            this.date_NgayNhap.Location = new System.Drawing.Point(416, 439);
            this.date_NgayNhap.Name = "date_NgayNhap";
            this.date_NgayNhap.Size = new System.Drawing.Size(200, 27);
            this.date_NgayNhap.TabIndex = 49;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(315, 444);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 20);
            this.label6.TabIndex = 48;
            this.label6.Text = "Ngày nhập:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(327, 396);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 20);
            this.label5.TabIndex = 46;
            this.label5.Text = "Số lượng:";
            // 
            // txt_DonGia
            // 
            this.txt_DonGia.BackColor = System.Drawing.SystemColors.Window;
            this.txt_DonGia.BorderColor = System.Drawing.Color.Black;
            this.txt_DonGia.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txt_DonGia.BorderRadius = 5;
            this.txt_DonGia.BorderSize = 1;
            this.txt_DonGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_DonGia.Location = new System.Drawing.Point(99, 441);
            this.txt_DonGia.Margin = new System.Windows.Forms.Padding(4);
            this.txt_DonGia.Multiline = true;
            this.txt_DonGia.Name = "txt_DonGia";
            this.txt_DonGia.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txt_DonGia.PasswordChar = false;
            this.txt_DonGia.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_DonGia.PlaceholderText = "";
            this.txt_DonGia.Size = new System.Drawing.Size(200, 35);
            this.txt_DonGia.TabIndex = 43;
            this.txt_DonGia.UnderlinedStyle = false;
            // 
            // txt_TenTBYT
            // 
            this.txt_TenTBYT.BackColor = System.Drawing.SystemColors.Window;
            this.txt_TenTBYT.BorderColor = System.Drawing.Color.Black;
            this.txt_TenTBYT.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txt_TenTBYT.BorderRadius = 5;
            this.txt_TenTBYT.BorderSize = 1;
            this.txt_TenTBYT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_TenTBYT.Location = new System.Drawing.Point(99, 394);
            this.txt_TenTBYT.Margin = new System.Windows.Forms.Padding(4);
            this.txt_TenTBYT.Multiline = true;
            this.txt_TenTBYT.Name = "txt_TenTBYT";
            this.txt_TenTBYT.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txt_TenTBYT.PasswordChar = false;
            this.txt_TenTBYT.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_TenTBYT.PlaceholderText = "";
            this.txt_TenTBYT.Size = new System.Drawing.Size(200, 35);
            this.txt_TenTBYT.TabIndex = 42;
            this.txt_TenTBYT.UnderlinedStyle = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dtgv_TBYT);
            this.groupBox1.Controls.Add(this.cbb_LoaiTBYT);
            this.groupBox1.Location = new System.Drawing.Point(12, 109);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1405, 269);
            this.groupBox1.TabIndex = 41;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh mục TBYT";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Loại TBYT";
            // 
            // dtgv_TBYT
            // 
            this.dtgv_TBYT.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgv_TBYT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_TBYT.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TenTBYT,
            this.DonGia,
            this.DonViTinh});
            this.dtgv_TBYT.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dtgv_TBYT.Location = new System.Drawing.Point(3, 64);
            this.dtgv_TBYT.Name = "dtgv_TBYT";
            this.dtgv_TBYT.ReadOnly = true;
            this.dtgv_TBYT.RowHeadersWidth = 51;
            this.dtgv_TBYT.RowTemplate.Height = 29;
            this.dtgv_TBYT.Size = new System.Drawing.Size(1399, 202);
            this.dtgv_TBYT.TabIndex = 3;
            this.dtgv_TBYT.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_TBYT_CellClick);
            // 
            // TenTBYT
            // 
            this.TenTBYT.HeaderText = "Tên TBYT";
            this.TenTBYT.MinimumWidth = 6;
            this.TenTBYT.Name = "TenTBYT";
            this.TenTBYT.ReadOnly = true;
            // 
            // DonGia
            // 
            this.DonGia.HeaderText = "Đơn giá (VND)";
            this.DonGia.MinimumWidth = 6;
            this.DonGia.Name = "DonGia";
            this.DonGia.ReadOnly = true;
            // 
            // DonViTinh
            // 
            this.DonViTinh.HeaderText = "Đơn vị tính";
            this.DonViTinh.MinimumWidth = 6;
            this.DonViTinh.Name = "DonViTinh";
            this.DonViTinh.ReadOnly = true;
            // 
            // cbb_LoaiTBYT
            // 
            this.cbb_LoaiTBYT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_LoaiTBYT.FormattingEnabled = true;
            this.cbb_LoaiTBYT.Location = new System.Drawing.Point(111, 26);
            this.cbb_LoaiTBYT.Name = "cbb_LoaiTBYT";
            this.cbb_LoaiTBYT.Size = new System.Drawing.Size(280, 28);
            this.cbb_LoaiTBYT.TabIndex = 1;
            this.cbb_LoaiTBYT.SelectedIndexChanged += new System.EventHandler(this.cbb_LoaiTBYT_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 496);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 20);
            this.label9.TabIndex = 55;
            this.label9.Text = "Đơn vị tính:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 451);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 20);
            this.label3.TabIndex = 53;
            this.label3.Text = "Đơn giá:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 404);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 20);
            this.label2.TabIndex = 52;
            this.label2.Text = "Tên thuốc:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1115, 574);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(120, 20);
            this.label8.TabIndex = 59;
            this.label8.Text = "Tổng tiền (VND):";
            // 
            // txt_TongTien
            // 
            this.txt_TongTien.BackColor = System.Drawing.SystemColors.Window;
            this.txt_TongTien.BorderColor = System.Drawing.Color.Black;
            this.txt_TongTien.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txt_TongTien.BorderRadius = 5;
            this.txt_TongTien.BorderSize = 1;
            this.txt_TongTien.Enabled = false;
            this.txt_TongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_TongTien.Location = new System.Drawing.Point(1242, 566);
            this.txt_TongTien.Margin = new System.Windows.Forms.Padding(4);
            this.txt_TongTien.Multiline = true;
            this.txt_TongTien.Name = "txt_TongTien";
            this.txt_TongTien.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txt_TongTien.PasswordChar = false;
            this.txt_TongTien.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_TongTien.PlaceholderText = "";
            this.txt_TongTien.Size = new System.Drawing.Size(200, 35);
            this.txt_TongTien.TabIndex = 58;
            this.txt_TongTien.UnderlinedStyle = false;
            // 
            // btn_Them
            // 
            this.btn_Them.Location = new System.Drawing.Point(99, 553);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(221, 48);
            this.btn_Them.TabIndex = 56;
            this.btn_Them.Text = "Thêm danh sách nhập";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtgv_PhieuNhap);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Location = new System.Drawing.Point(0, 630);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1465, 323);
            this.groupBox2.TabIndex = 57;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách nhập thuốc";
            // 
            // dtgv_PhieuNhap
            // 
            this.dtgv_PhieuNhap.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgv_PhieuNhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_PhieuNhap.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pn_TenThuoc,
            this.pn_DonGia,
            this.pn_SoLuong,
            this.NgayNhap,
            this.pn_DonViTinh});
            this.dtgv_PhieuNhap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgv_PhieuNhap.Location = new System.Drawing.Point(3, 23);
            this.dtgv_PhieuNhap.Name = "dtgv_PhieuNhap";
            this.dtgv_PhieuNhap.RowHeadersWidth = 51;
            this.dtgv_PhieuNhap.RowTemplate.Height = 29;
            this.dtgv_PhieuNhap.Size = new System.Drawing.Size(1459, 297);
            this.dtgv_PhieuNhap.TabIndex = 1;
            // 
            // pn_TenThuoc
            // 
            this.pn_TenThuoc.HeaderText = "Tên thuốc";
            this.pn_TenThuoc.MinimumWidth = 6;
            this.pn_TenThuoc.Name = "pn_TenThuoc";
            // 
            // pn_DonGia
            // 
            this.pn_DonGia.HeaderText = "Đơn giá (VND)";
            this.pn_DonGia.MinimumWidth = 6;
            this.pn_DonGia.Name = "pn_DonGia";
            // 
            // pn_SoLuong
            // 
            this.pn_SoLuong.HeaderText = "Số lượng";
            this.pn_SoLuong.MinimumWidth = 6;
            this.pn_SoLuong.Name = "pn_SoLuong";
            // 
            // NgayNhap
            // 
            this.NgayNhap.HeaderText = "Ngày nhập";
            this.NgayNhap.MinimumWidth = 6;
            this.NgayNhap.Name = "NgayNhap";
            // 
            // pn_DonViTinh
            // 
            this.pn_DonViTinh.HeaderText = "Đơn vị tính";
            this.pn_DonViTinh.MinimumWidth = 6;
            this.pn_DonViTinh.Name = "pn_DonViTinh";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(611, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(240, 38);
            this.label4.TabIndex = 60;
            this.label4.Text = "Phiếu nhập TBYT";
            // 
            // FrmNhapTBYT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1465, 953);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_TongTien);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_SoLuong);
            this.Controls.Add(this.txt_DonViTinh);
            this.Controls.Add(this.date_NgayNhap);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_DonGia);
            this.Controls.Add(this.txt_TenTBYT);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "FrmNhapTBYT";
            this.Text = "FrmNhapTBYT";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_TBYT)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_PhieuNhap)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripButton toolStripBtn_ThemPhieuNhap;
        private ToolStripButton toolStripBtn_Refresh;
        private ToolStripButton toolStripBtn_Thoat;
        private TextBox txt_SoLuong;
        private Demo.Controls.TextBox_NTT txt_DonViTinh;
        private DateTimePicker date_NgayNhap;
        private Label label6;
        private Label label5;
        private Demo.Controls.TextBox_NTT txt_DonGia;
        private Demo.Controls.TextBox_NTT txt_TenTBYT;
        private GroupBox groupBox1;
        private Label label1;
        private DataGridView dtgv_TBYT;
        private ComboBox cbb_LoaiTBYT;
        private Label label9;
        private Label label3;
        private Label label2;
        private DataGridViewTextBoxColumn TenTBYT;
        private DataGridViewTextBoxColumn DonGia;
        private DataGridViewTextBoxColumn DonViTinh;
        private Label label8;
        private Demo.Controls.TextBox_NTT txt_TongTien;
        private Button btn_Them;
        private GroupBox groupBox2;
        private DataGridView dtgv_PhieuNhap;
        private DataGridViewTextBoxColumn pn_TenThuoc;
        private DataGridViewTextBoxColumn pn_DonGia;
        private DataGridViewTextBoxColumn pn_SoLuong;
        private DataGridViewTextBoxColumn NgayNhap;
        private DataGridViewTextBoxColumn pn_DonViTinh;
        private Label label4;
    }
}