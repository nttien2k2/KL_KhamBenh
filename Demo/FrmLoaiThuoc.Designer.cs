namespace GUI
{
    partial class FrmLoaiThuoc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLoaiThuoc));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripBtn_Luu = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtn_Xoa = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtn_Refresh = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtn_Thoat = new System.Windows.Forms.ToolStripButton();
            this.pn_Left = new System.Windows.Forms.Panel();
            this.txt_MoTa = new Demo.Controls.TextBox_NTT();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_MaLoaiThuoc = new Demo.Controls.TextBox_NTT();
            this.btn_Them = new System.Windows.Forms.Button();
            this.txt_TenLoaiThuoc = new Demo.Controls.TextBox_NTT();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pn_Right = new System.Windows.Forms.Panel();
            this.dtgv_Thuoc = new System.Windows.Forms.DataGridView();
            this.MaLoaiThuoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenLoaiThuoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MoTa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1.SuspendLayout();
            this.pn_Left.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pn_Right.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_Thuoc)).BeginInit();
            this.SuspendLayout();
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
            this.toolStrip1.Size = new System.Drawing.Size(1378, 50);
            this.toolStrip1.TabIndex = 9;
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
            this.toolStripBtn_Refresh.Click += new System.EventHandler(this.toolStripBtn_Refresh_Click);
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
            // pn_Left
            // 
            this.pn_Left.BackColor = System.Drawing.Color.White;
            this.pn_Left.Controls.Add(this.txt_MoTa);
            this.pn_Left.Controls.Add(this.label6);
            this.pn_Left.Controls.Add(this.txt_MaLoaiThuoc);
            this.pn_Left.Controls.Add(this.btn_Them);
            this.pn_Left.Controls.Add(this.txt_TenLoaiThuoc);
            this.pn_Left.Controls.Add(this.label3);
            this.pn_Left.Controls.Add(this.label2);
            this.pn_Left.Controls.Add(this.button1);
            this.pn_Left.Controls.Add(this.pictureBox1);
            this.pn_Left.Controls.Add(this.label1);
            this.pn_Left.Dock = System.Windows.Forms.DockStyle.Left;
            this.pn_Left.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.pn_Left.Location = new System.Drawing.Point(0, 50);
            this.pn_Left.Name = "pn_Left";
            this.pn_Left.Size = new System.Drawing.Size(500, 903);
            this.pn_Left.TabIndex = 10;
            // 
            // txt_MoTa
            // 
            this.txt_MoTa.BackColor = System.Drawing.SystemColors.Window;
            this.txt_MoTa.BorderColor = System.Drawing.Color.Black;
            this.txt_MoTa.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txt_MoTa.BorderRadius = 5;
            this.txt_MoTa.BorderSize = 1;
            this.txt_MoTa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_MoTa.Location = new System.Drawing.Point(120, 183);
            this.txt_MoTa.Margin = new System.Windows.Forms.Padding(4);
            this.txt_MoTa.Multiline = true;
            this.txt_MoTa.Name = "txt_MoTa";
            this.txt_MoTa.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txt_MoTa.PasswordChar = false;
            this.txt_MoTa.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_MoTa.PlaceholderText = "";
            this.txt_MoTa.Size = new System.Drawing.Size(334, 199);
            this.txt_MoTa.TabIndex = 94;
            this.txt_MoTa.UnderlinedStyle = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(60, 183);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Mô tả:";
            // 
            // txt_MaLoaiThuoc
            // 
            this.txt_MaLoaiThuoc.BackColor = System.Drawing.SystemColors.Window;
            this.txt_MaLoaiThuoc.BorderColor = System.Drawing.SystemColors.Desktop;
            this.txt_MaLoaiThuoc.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txt_MaLoaiThuoc.BorderRadius = 5;
            this.txt_MaLoaiThuoc.BorderSize = 1;
            this.txt_MaLoaiThuoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_MaLoaiThuoc.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txt_MaLoaiThuoc.Location = new System.Drawing.Point(120, 82);
            this.txt_MaLoaiThuoc.Margin = new System.Windows.Forms.Padding(4);
            this.txt_MaLoaiThuoc.Multiline = false;
            this.txt_MaLoaiThuoc.Name = "txt_MaLoaiThuoc";
            this.txt_MaLoaiThuoc.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txt_MaLoaiThuoc.PasswordChar = false;
            this.txt_MaLoaiThuoc.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_MaLoaiThuoc.PlaceholderText = "";
            this.txt_MaLoaiThuoc.Size = new System.Drawing.Size(334, 35);
            this.txt_MaLoaiThuoc.TabIndex = 8;
            this.txt_MaLoaiThuoc.UnderlinedStyle = false;
            // 
            // btn_Them
            // 
            this.btn_Them.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Them.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_Them.FlatAppearance.BorderSize = 2;
            this.btn_Them.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Them.Image = ((System.Drawing.Image)(resources.GetObject("btn_Them.Image")));
            this.btn_Them.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Them.Location = new System.Drawing.Point(120, 389);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(148, 53);
            this.btn_Them.TabIndex = 10;
            this.btn_Them.Text = "   Thêm mới";
            this.btn_Them.UseVisualStyleBackColor = false;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // txt_TenLoaiThuoc
            // 
            this.txt_TenLoaiThuoc.BackColor = System.Drawing.SystemColors.Window;
            this.txt_TenLoaiThuoc.BorderColor = System.Drawing.SystemColors.Desktop;
            this.txt_TenLoaiThuoc.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txt_TenLoaiThuoc.BorderRadius = 5;
            this.txt_TenLoaiThuoc.BorderSize = 1;
            this.txt_TenLoaiThuoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_TenLoaiThuoc.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txt_TenLoaiThuoc.Location = new System.Drawing.Point(120, 125);
            this.txt_TenLoaiThuoc.Margin = new System.Windows.Forms.Padding(4);
            this.txt_TenLoaiThuoc.Multiline = false;
            this.txt_TenLoaiThuoc.Name = "txt_TenLoaiThuoc";
            this.txt_TenLoaiThuoc.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txt_TenLoaiThuoc.PasswordChar = false;
            this.txt_TenLoaiThuoc.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_TenLoaiThuoc.PlaceholderText = "";
            this.txt_TenLoaiThuoc.Size = new System.Drawing.Size(334, 35);
            this.txt_TenLoaiThuoc.TabIndex = 7;
            this.txt_TenLoaiThuoc.UnderlinedStyle = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(4, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tên loại thuốc:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(10, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mã loại thuốc:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(63, 54);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(300, 2);
            this.button1.TabIndex = 2;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(76, 19);
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
            this.label1.Location = new System.Drawing.Point(120, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Danh mục Thuốc";
            // 
            // pn_Right
            // 
            this.pn_Right.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pn_Right.Controls.Add(this.dtgv_Thuoc);
            this.pn_Right.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_Right.Location = new System.Drawing.Point(500, 50);
            this.pn_Right.Name = "pn_Right";
            this.pn_Right.Size = new System.Drawing.Size(878, 903);
            this.pn_Right.TabIndex = 11;
            // 
            // dtgv_Thuoc
            // 
            this.dtgv_Thuoc.BackgroundColor = System.Drawing.Color.White;
            this.dtgv_Thuoc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgv_Thuoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_Thuoc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaLoaiThuoc,
            this.TenLoaiThuoc,
            this.MoTa});
            this.dtgv_Thuoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgv_Thuoc.Location = new System.Drawing.Point(0, 0);
            this.dtgv_Thuoc.Name = "dtgv_Thuoc";
            this.dtgv_Thuoc.ReadOnly = true;
            this.dtgv_Thuoc.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dtgv_Thuoc.RowHeadersWidth = 51;
            this.dtgv_Thuoc.RowTemplate.Height = 29;
            this.dtgv_Thuoc.Size = new System.Drawing.Size(876, 901);
            this.dtgv_Thuoc.TabIndex = 0;
            this.dtgv_Thuoc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_Thuoc_CellClick);
            // 
            // MaLoaiThuoc
            // 
            this.MaLoaiThuoc.HeaderText = "Mã loại thuốc";
            this.MaLoaiThuoc.MinimumWidth = 6;
            this.MaLoaiThuoc.Name = "MaLoaiThuoc";
            this.MaLoaiThuoc.ReadOnly = true;
            this.MaLoaiThuoc.Width = 150;
            // 
            // TenLoaiThuoc
            // 
            this.TenLoaiThuoc.HeaderText = "Tên loại thuốc";
            this.TenLoaiThuoc.MinimumWidth = 6;
            this.TenLoaiThuoc.Name = "TenLoaiThuoc";
            this.TenLoaiThuoc.ReadOnly = true;
            this.TenLoaiThuoc.Width = 250;
            // 
            // MoTa
            // 
            this.MoTa.HeaderText = "Mô tả";
            this.MoTa.MinimumWidth = 6;
            this.MoTa.Name = "MoTa";
            this.MoTa.ReadOnly = true;
            this.MoTa.Width = 400;
            // 
            // FrmLoaiThuoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1378, 953);
            this.Controls.Add(this.pn_Right);
            this.Controls.Add(this.pn_Left);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmLoaiThuoc";
            this.Text = "FrmThuoc";
            this.Load += new System.EventHandler(this.FrmLoaiThuoc_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.pn_Left.ResumeLayout(false);
            this.pn_Left.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pn_Right.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_Thuoc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripButton toolStripBtn_Luu;
        private ToolStripButton toolStripBtn_Xoa;
        private ToolStripButton toolStripBtn_Refresh;
        private ToolStripButton toolStripBtn_Thoat;
        private Panel pn_Left;
        private Label label6;
        private Demo.Controls.TextBox_NTT txt_MaLoaiThuoc;
        private Button btn_Them;
        private Demo.Controls.TextBox_NTT txt_TenLoaiThuoc;
        private Label label3;
        private Label label2;
        private Button button1;
        private PictureBox pictureBox1;
        private Label label1;
        private Panel pn_Right;
        private DataGridView dtgv_Thuoc;
        private Demo.Controls.TextBox_NTT txt_MoTa;
        private DataGridViewTextBoxColumn MaLoaiThuoc;
        private DataGridViewTextBoxColumn TenLoaiThuoc;
        private DataGridViewTextBoxColumn MoTa;
    }
}