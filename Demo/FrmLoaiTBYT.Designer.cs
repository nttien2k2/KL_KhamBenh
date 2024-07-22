namespace GUI
{
    partial class FrmLoaiTBYT
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLoaiTBYT));
            this.pn_Right = new System.Windows.Forms.Panel();
            this.dtgv_LoaiTBYT = new System.Windows.Forms.DataGridView();
            this.MaLoaiTBYT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenLoaiTBYT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MoTa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_MaLoaiTBYT = new Demo.Controls.TextBox_NTT();
            this.toolStripBtn_Thoat = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtn_Refresh = new System.Windows.Forms.ToolStripButton();
            this.btn_ThemTBYT = new System.Windows.Forms.Button();
            this.txt_TenLoaiTBYT = new Demo.Controls.TextBox_NTT();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStripBtn_Xoa = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtn_Luu = new System.Windows.Forms.ToolStripButton();
            this.pn_Left = new System.Windows.Forms.Panel();
            this.txt_MoTa = new Demo.Controls.TextBox_NTT();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.pn_Right.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_LoaiTBYT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pn_Left.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pn_Right
            // 
            this.pn_Right.Controls.Add(this.dtgv_LoaiTBYT);
            this.pn_Right.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_Right.Location = new System.Drawing.Point(500, 50);
            this.pn_Right.Name = "pn_Right";
            this.pn_Right.Size = new System.Drawing.Size(860, 856);
            this.pn_Right.TabIndex = 8;
            // 
            // dtgv_LoaiTBYT
            // 
            this.dtgv_LoaiTBYT.BackgroundColor = System.Drawing.Color.White;
            this.dtgv_LoaiTBYT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_LoaiTBYT.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaLoaiTBYT,
            this.TenLoaiTBYT,
            this.MoTa});
            this.dtgv_LoaiTBYT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgv_LoaiTBYT.Location = new System.Drawing.Point(0, 0);
            this.dtgv_LoaiTBYT.Name = "dtgv_LoaiTBYT";
            this.dtgv_LoaiTBYT.ReadOnly = true;
            this.dtgv_LoaiTBYT.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dtgv_LoaiTBYT.RowHeadersWidth = 51;
            this.dtgv_LoaiTBYT.RowTemplate.Height = 29;
            this.dtgv_LoaiTBYT.Size = new System.Drawing.Size(860, 856);
            this.dtgv_LoaiTBYT.TabIndex = 0;
            this.dtgv_LoaiTBYT.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_LoaiTBYT_CellClick);
            // 
            // MaLoaiTBYT
            // 
            this.MaLoaiTBYT.FillWeight = 1.107548F;
            this.MaLoaiTBYT.HeaderText = "Mã Loại TBYT";
            this.MaLoaiTBYT.MinimumWidth = 6;
            this.MaLoaiTBYT.Name = "MaLoaiTBYT";
            this.MaLoaiTBYT.ReadOnly = true;
            this.MaLoaiTBYT.Width = 150;
            // 
            // TenLoaiTBYT
            // 
            this.TenLoaiTBYT.FillWeight = 18.14379F;
            this.TenLoaiTBYT.HeaderText = "Tên loại TBYT";
            this.TenLoaiTBYT.MinimumWidth = 6;
            this.TenLoaiTBYT.Name = "TenLoaiTBYT";
            this.TenLoaiTBYT.ReadOnly = true;
            this.TenLoaiTBYT.Width = 250;
            // 
            // MoTa
            // 
            this.MoTa.FillWeight = 280.7487F;
            this.MoTa.HeaderText = "Mô tả";
            this.MoTa.MinimumWidth = 6;
            this.MoTa.Name = "MoTa";
            this.MoTa.ReadOnly = true;
            this.MoTa.Width = 400;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(74, 174);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Mô tả:";
            // 
            // txt_MaLoaiTBYT
            // 
            this.txt_MaLoaiTBYT.BackColor = System.Drawing.SystemColors.Window;
            this.txt_MaLoaiTBYT.BorderColor = System.Drawing.SystemColors.Desktop;
            this.txt_MaLoaiTBYT.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txt_MaLoaiTBYT.BorderRadius = 5;
            this.txt_MaLoaiTBYT.BorderSize = 1;
            this.txt_MaLoaiTBYT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_MaLoaiTBYT.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txt_MaLoaiTBYT.Location = new System.Drawing.Point(137, 83);
            this.txt_MaLoaiTBYT.Margin = new System.Windows.Forms.Padding(4);
            this.txt_MaLoaiTBYT.Multiline = false;
            this.txt_MaLoaiTBYT.Name = "txt_MaLoaiTBYT";
            this.txt_MaLoaiTBYT.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txt_MaLoaiTBYT.PasswordChar = false;
            this.txt_MaLoaiTBYT.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_MaLoaiTBYT.PlaceholderText = "";
            this.txt_MaLoaiTBYT.Size = new System.Drawing.Size(328, 35);
            this.txt_MaLoaiTBYT.TabIndex = 8;
            this.txt_MaLoaiTBYT.UnderlinedStyle = false;
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
            // btn_ThemTBYT
            // 
            this.btn_ThemTBYT.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_ThemTBYT.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_ThemTBYT.FlatAppearance.BorderSize = 2;
            this.btn_ThemTBYT.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_ThemTBYT.Image = ((System.Drawing.Image)(resources.GetObject("btn_ThemTBYT.Image")));
            this.btn_ThemTBYT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ThemTBYT.Location = new System.Drawing.Point(147, 329);
            this.btn_ThemTBYT.Name = "btn_ThemTBYT";
            this.btn_ThemTBYT.Size = new System.Drawing.Size(148, 53);
            this.btn_ThemTBYT.TabIndex = 10;
            this.btn_ThemTBYT.Text = "   Thêm mới";
            this.btn_ThemTBYT.UseVisualStyleBackColor = false;
            this.btn_ThemTBYT.Click += new System.EventHandler(this.btn_ThemTBYT_Click);
            // 
            // txt_TenLoaiTBYT
            // 
            this.txt_TenLoaiTBYT.BackColor = System.Drawing.SystemColors.Window;
            this.txt_TenLoaiTBYT.BorderColor = System.Drawing.SystemColors.Desktop;
            this.txt_TenLoaiTBYT.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txt_TenLoaiTBYT.BorderRadius = 5;
            this.txt_TenLoaiTBYT.BorderSize = 1;
            this.txt_TenLoaiTBYT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_TenLoaiTBYT.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txt_TenLoaiTBYT.Location = new System.Drawing.Point(137, 126);
            this.txt_TenLoaiTBYT.Margin = new System.Windows.Forms.Padding(4);
            this.txt_TenLoaiTBYT.Multiline = false;
            this.txt_TenLoaiTBYT.Name = "txt_TenLoaiTBYT";
            this.txt_TenLoaiTBYT.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txt_TenLoaiTBYT.PasswordChar = false;
            this.txt_TenLoaiTBYT.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_TenLoaiTBYT.PlaceholderText = "";
            this.txt_TenLoaiTBYT.Size = new System.Drawing.Size(328, 35);
            this.txt_TenLoaiTBYT.TabIndex = 7;
            this.txt_TenLoaiTBYT.UnderlinedStyle = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(23, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tên loại TBYT:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(25, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mã loại TBYT:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(74, 56);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(300, 2);
            this.button1.TabIndex = 2;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(87, 21);
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
            this.label1.Location = new System.Drawing.Point(131, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Danh mục loại TBYT";
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
            // pn_Left
            // 
            this.pn_Left.BackColor = System.Drawing.Color.White;
            this.pn_Left.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pn_Left.Controls.Add(this.txt_MoTa);
            this.pn_Left.Controls.Add(this.label6);
            this.pn_Left.Controls.Add(this.txt_MaLoaiTBYT);
            this.pn_Left.Controls.Add(this.btn_ThemTBYT);
            this.pn_Left.Controls.Add(this.txt_TenLoaiTBYT);
            this.pn_Left.Controls.Add(this.label3);
            this.pn_Left.Controls.Add(this.label2);
            this.pn_Left.Controls.Add(this.button1);
            this.pn_Left.Controls.Add(this.pictureBox1);
            this.pn_Left.Controls.Add(this.label1);
            this.pn_Left.Dock = System.Windows.Forms.DockStyle.Left;
            this.pn_Left.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.pn_Left.Location = new System.Drawing.Point(0, 50);
            this.pn_Left.Name = "pn_Left";
            this.pn_Left.Size = new System.Drawing.Size(500, 856);
            this.pn_Left.TabIndex = 7;
            // 
            // txt_MoTa
            // 
            this.txt_MoTa.BackColor = System.Drawing.SystemColors.Window;
            this.txt_MoTa.BorderColor = System.Drawing.Color.Black;
            this.txt_MoTa.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txt_MoTa.BorderRadius = 5;
            this.txt_MoTa.BorderSize = 1;
            this.txt_MoTa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_MoTa.Location = new System.Drawing.Point(137, 169);
            this.txt_MoTa.Margin = new System.Windows.Forms.Padding(4);
            this.txt_MoTa.Multiline = true;
            this.txt_MoTa.Name = "txt_MoTa";
            this.txt_MoTa.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txt_MoTa.PasswordChar = false;
            this.txt_MoTa.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_MoTa.PlaceholderText = "";
            this.txt_MoTa.Size = new System.Drawing.Size(328, 141);
            this.txt_MoTa.TabIndex = 12;
            this.txt_MoTa.UnderlinedStyle = false;
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
            this.toolStrip1.TabIndex = 6;
            // 
            // FrmLoaiTBYT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1360, 906);
            this.Controls.Add(this.pn_Right);
            this.Controls.Add(this.pn_Left);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmLoaiTBYT";
            this.Text = "FrmTBYT";
            this.Load += new System.EventHandler(this.FrmLoaiTBYT_Load);
            this.pn_Right.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_LoaiTBYT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pn_Left.ResumeLayout(false);
            this.pn_Left.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Panel pn_Right;
        private DataGridView dtgv_LoaiTBYT;
        private Label label6;
        private Demo.Controls.TextBox_NTT txt_MaLoaiTBYT;
        private ToolStripButton toolStripBtn_Thoat;
        private ToolStripButton toolStripBtn_Refresh;
        private Button btn_ThemTBYT;
        private Demo.Controls.TextBox_NTT txt_TenLoaiTBYT;
        private Label label3;
        private Label label2;
        private Button button1;
        private PictureBox pictureBox1;
        private Label label1;
        private ToolStripButton toolStripBtn_Xoa;
        private ToolStripButton toolStripBtn_Luu;
        private Panel pn_Left;
        private ToolStrip toolStrip1;
        private Demo.Controls.TextBox_NTT txt_MoTa;
        private DataGridViewTextBoxColumn MaLoaiTBYT;
        private DataGridViewTextBoxColumn TenLoaiTBYT;
        private DataGridViewTextBoxColumn MoTa;
    }
}