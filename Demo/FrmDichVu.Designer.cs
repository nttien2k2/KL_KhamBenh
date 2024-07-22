namespace GUI
{
    partial class FrmDichVu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDichVu));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolStripBtn_Thoat = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtn_Xoa = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtn_Luu = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripBtn_Refresh = new System.Windows.Forms.ToolStripButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pn_Right = new System.Windows.Forms.Panel();
            this.dtgv_DichVu = new System.Windows.Forms.DataGridView();
            this.TenChuyenKhoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaDichVu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenDichVu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pn_Left = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.cbb_ChuyenKhoa = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_Gia = new Demo.Controls.TextBox_NTT();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_MaDichVu = new Demo.Controls.TextBox_NTT();
            this.btn_Them = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_TenDichVu = new Demo.Controls.TextBox_NTT();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.pn_Right.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_DichVu)).BeginInit();
            this.pn_Left.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
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
            this.toolStripBtn_Thoat.Click += new System.EventHandler(this.toolStripBtn_Thoat_Click);
            // 
            // toolStripBtn_Xoa
            // 
            this.toolStripBtn_Xoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(117)))), ((int)(((byte)(220)))));
            this.toolStripBtn_Xoa.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.toolStripBtn_Xoa.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.toolStripBtn_Xoa.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtn_Xoa.Image")));
            this.toolStripBtn_Xoa.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtn_Xoa.Name = "toolStripBtn_Xoa";
            this.toolStripBtn_Xoa.Padding = new System.Windows.Forms.Padding(10);
            this.toolStripBtn_Xoa.Size = new System.Drawing.Size(88, 47);
            this.toolStripBtn_Xoa.Text = " Xóa";
            this.toolStripBtn_Xoa.Click += new System.EventHandler(this.toolStripBtn_Xoa_Click);
            // 
            // toolStripBtn_Luu
            // 
            this.toolStripBtn_Luu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(117)))), ((int)(((byte)(220)))));
            this.toolStripBtn_Luu.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.toolStripBtn_Luu.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.toolStripBtn_Luu.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtn_Luu.Image")));
            this.toolStripBtn_Luu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtn_Luu.Name = "toolStripBtn_Luu";
            this.toolStripBtn_Luu.Padding = new System.Windows.Forms.Padding(10);
            this.toolStripBtn_Luu.Size = new System.Drawing.Size(87, 47);
            this.toolStripBtn_Luu.Text = " Lưu";
            this.toolStripBtn_Luu.Click += new System.EventHandler(this.toolStripBtn_Luu_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(117)))), ((int)(((byte)(220)))));
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripBtn_Luu,
            this.toolStripBtn_Xoa,
            this.toolStripBtn_Refresh,
            this.toolStripBtn_Thoat});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0);
            this.toolStrip1.Size = new System.Drawing.Size(1360, 50);
            this.toolStrip1.TabIndex = 1;
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
            // panel4
            // 
            this.panel4.Controls.Add(this.pn_Right);
            this.panel4.Controls.Add(this.pn_Left);
            this.panel4.Controls.Add(this.toolStrip1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1360, 906);
            this.panel4.TabIndex = 4;
            // 
            // pn_Right
            // 
            this.pn_Right.Controls.Add(this.dtgv_DichVu);
            this.pn_Right.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_Right.Location = new System.Drawing.Point(482, 50);
            this.pn_Right.Name = "pn_Right";
            this.pn_Right.Size = new System.Drawing.Size(878, 856);
            this.pn_Right.TabIndex = 3;
            // 
            // dtgv_DichVu
            // 
            this.dtgv_DichVu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgv_DichVu.BackgroundColor = System.Drawing.Color.White;
            this.dtgv_DichVu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgv_DichVu.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgv_DichVu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_DichVu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TenChuyenKhoa,
            this.MaDichVu,
            this.TenDichVu,
            this.Gia});
            this.dtgv_DichVu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgv_DichVu.Location = new System.Drawing.Point(0, 0);
            this.dtgv_DichVu.Name = "dtgv_DichVu";
            this.dtgv_DichVu.ReadOnly = true;
            this.dtgv_DichVu.RowHeadersWidth = 51;
            this.dtgv_DichVu.RowTemplate.Height = 29;
            this.dtgv_DichVu.Size = new System.Drawing.Size(878, 856);
            this.dtgv_DichVu.TabIndex = 0;
            this.dtgv_DichVu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_DichVu_CellClick);
            // 
            // TenChuyenKhoa
            // 
            this.TenChuyenKhoa.HeaderText = "Chuyên khoa";
            this.TenChuyenKhoa.MinimumWidth = 6;
            this.TenChuyenKhoa.Name = "TenChuyenKhoa";
            this.TenChuyenKhoa.ReadOnly = true;
            // 
            // MaDichVu
            // 
            this.MaDichVu.HeaderText = "Mã";
            this.MaDichVu.MinimumWidth = 6;
            this.MaDichVu.Name = "MaDichVu";
            this.MaDichVu.ReadOnly = true;
            // 
            // TenDichVu
            // 
            this.TenDichVu.HeaderText = "Tên dịch vụ";
            this.TenDichVu.MinimumWidth = 6;
            this.TenDichVu.Name = "TenDichVu";
            this.TenDichVu.ReadOnly = true;
            // 
            // Gia
            // 
            this.Gia.HeaderText = "Giá (VND)";
            this.Gia.MinimumWidth = 6;
            this.Gia.Name = "Gia";
            this.Gia.ReadOnly = true;
            // 
            // pn_Left
            // 
            this.pn_Left.BackColor = System.Drawing.Color.White;
            this.pn_Left.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pn_Left.Controls.Add(this.label8);
            this.pn_Left.Controls.Add(this.cbb_ChuyenKhoa);
            this.pn_Left.Controls.Add(this.label7);
            this.pn_Left.Controls.Add(this.txt_Gia);
            this.pn_Left.Controls.Add(this.label6);
            this.pn_Left.Controls.Add(this.txt_MaDichVu);
            this.pn_Left.Controls.Add(this.btn_Them);
            this.pn_Left.Controls.Add(this.label5);
            this.pn_Left.Controls.Add(this.label4);
            this.pn_Left.Controls.Add(this.txt_TenDichVu);
            this.pn_Left.Controls.Add(this.label3);
            this.pn_Left.Controls.Add(this.label2);
            this.pn_Left.Controls.Add(this.button1);
            this.pn_Left.Controls.Add(this.pictureBox1);
            this.pn_Left.Controls.Add(this.label1);
            this.pn_Left.Dock = System.Windows.Forms.DockStyle.Left;
            this.pn_Left.Location = new System.Drawing.Point(0, 50);
            this.pn_Left.Name = "pn_Left";
            this.pn_Left.Size = new System.Drawing.Size(482, 856);
            this.pn_Left.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(11, 219);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(114, 23);
            this.label8.TabIndex = 16;
            this.label8.Text = "Chuyên khoa:";
            // 
            // cbb_ChuyenKhoa
            // 
            this.cbb_ChuyenKhoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_ChuyenKhoa.FormattingEnabled = true;
            this.cbb_ChuyenKhoa.Location = new System.Drawing.Point(132, 218);
            this.cbb_ChuyenKhoa.Name = "cbb_ChuyenKhoa";
            this.cbb_ChuyenKhoa.Size = new System.Drawing.Size(278, 28);
            this.cbb_ChuyenKhoa.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(417, 165);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(20, 25);
            this.label7.TabIndex = 14;
            this.label7.Text = "*";
            // 
            // txt_Gia
            // 
            this.txt_Gia.BackColor = System.Drawing.SystemColors.Window;
            this.txt_Gia.BorderColor = System.Drawing.SystemColors.Desktop;
            this.txt_Gia.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txt_Gia.BorderRadius = 5;
            this.txt_Gia.BorderSize = 1;
            this.txt_Gia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_Gia.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txt_Gia.Location = new System.Drawing.Point(132, 165);
            this.txt_Gia.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Gia.Multiline = false;
            this.txt_Gia.Name = "txt_Gia";
            this.txt_Gia.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txt_Gia.PasswordChar = false;
            this.txt_Gia.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_Gia.PlaceholderText = "";
            this.txt_Gia.Size = new System.Drawing.Size(278, 35);
            this.txt_Gia.TabIndex = 13;
            this.txt_Gia.UnderlinedStyle = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(86, 170);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 23);
            this.label6.TabIndex = 12;
            this.label6.Text = "Giá:";
            // 
            // txt_MaDichVu
            // 
            this.txt_MaDichVu.BackColor = System.Drawing.SystemColors.Window;
            this.txt_MaDichVu.BorderColor = System.Drawing.SystemColors.Desktop;
            this.txt_MaDichVu.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txt_MaDichVu.BorderRadius = 5;
            this.txt_MaDichVu.BorderSize = 1;
            this.txt_MaDichVu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_MaDichVu.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txt_MaDichVu.Location = new System.Drawing.Point(132, 78);
            this.txt_MaDichVu.Margin = new System.Windows.Forms.Padding(4);
            this.txt_MaDichVu.Multiline = false;
            this.txt_MaDichVu.Name = "txt_MaDichVu";
            this.txt_MaDichVu.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txt_MaDichVu.PasswordChar = false;
            this.txt_MaDichVu.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_MaDichVu.PlaceholderText = "";
            this.txt_MaDichVu.Size = new System.Drawing.Size(278, 35);
            this.txt_MaDichVu.TabIndex = 11;
            this.txt_MaDichVu.UnderlinedStyle = false;
            // 
            // btn_Them
            // 
            this.btn_Them.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Them.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_Them.FlatAppearance.BorderSize = 2;
            this.btn_Them.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Them.Image = ((System.Drawing.Image)(resources.GetObject("btn_Them.Image")));
            this.btn_Them.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Them.Location = new System.Drawing.Point(132, 269);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(148, 53);
            this.btn_Them.TabIndex = 10;
            this.btn_Them.Text = "   Thêm mới";
            this.btn_Them.UseVisualStyleBackColor = false;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(417, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "*";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(417, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "*";
            // 
            // txt_TenDichVu
            // 
            this.txt_TenDichVu.BackColor = System.Drawing.SystemColors.Window;
            this.txt_TenDichVu.BorderColor = System.Drawing.SystemColors.Desktop;
            this.txt_TenDichVu.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txt_TenDichVu.BorderRadius = 5;
            this.txt_TenDichVu.BorderSize = 1;
            this.txt_TenDichVu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_TenDichVu.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txt_TenDichVu.Location = new System.Drawing.Point(132, 122);
            this.txt_TenDichVu.Margin = new System.Windows.Forms.Padding(4);
            this.txt_TenDichVu.Multiline = false;
            this.txt_TenDichVu.Name = "txt_TenDichVu";
            this.txt_TenDichVu.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txt_TenDichVu.PasswordChar = false;
            this.txt_TenDichVu.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_TenDichVu.PlaceholderText = "";
            this.txt_TenDichVu.Size = new System.Drawing.Size(278, 35);
            this.txt_TenDichVu.TabIndex = 7;
            this.txt_TenDichVu.UnderlinedStyle = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(85, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tên:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(87, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mã:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(98, 55);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(300, 2);
            this.button1.TabIndex = 2;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(111, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(38, 29);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(155, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Danh mục dịch vụ";
            // 
            // FrmDichVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1360, 906);
            this.Controls.Add(this.panel4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmDichVu";
            this.Text = "FrmDichVu";
            this.Load += new System.EventHandler(this.FrmDichVu_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.pn_Right.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_DichVu)).EndInit();
            this.pn_Left.ResumeLayout(false);
            this.pn_Left.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ToolStripButton toolStripBtn_Thoat;
        private ToolStripButton toolStripBtn_Xoa;
        private ToolStripButton toolStripBtn_Luu;
        private ToolStrip toolStrip1;
        private ToolStripButton toolStripBtn_Refresh;
        private Panel panel4;
        private Panel pn_Right;
        private DataGridView dtgv_DichVu;
        private Panel pn_Left;
        private Demo.Controls.TextBox_NTT txt_Gia;
        private Label label6;
        private Demo.Controls.TextBox_NTT txt_MaDichVu;
        private Button btn_Them;
        private Label label5;
        private Label label4;
        private Demo.Controls.TextBox_NTT txt_TenDichVu;
        private Label label3;
        private Label label2;
        private Button button1;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label7;
        private DataGridViewTextBoxColumn TenChuyenKhoa;
        private DataGridViewTextBoxColumn MaDichVu;
        private DataGridViewTextBoxColumn TenDichVu;
        private DataGridViewTextBoxColumn Gia;
        private Label label8;
        private ComboBox cbb_ChuyenKhoa;
    }
}