namespace GUI
{
    partial class FrmChuyenKhoa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmChuyenKhoa));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_Them = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_TenChuyenKhoa = new Demo.Controls.TextBox_NTT();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pn_Left = new System.Windows.Forms.Panel();
            this.txt_VietTat = new Demo.Controls.TextBox_NTT();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_MaChuyenKhoa = new Demo.Controls.TextBox_NTT();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pn_Right = new System.Windows.Forms.Panel();
            this.dtgv_ChuyenKhoa = new System.Windows.Forms.DataGridView();
            this.MaChuyenKhoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenChuyenKhoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VietTat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel4 = new System.Windows.Forms.Panel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripBtn_Luu = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtn_Xoa = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtn_Refresh = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtn_Thoat = new System.Windows.Forms.ToolStripButton();
            this.pn_Left.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pn_Right.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_ChuyenKhoa)).BeginInit();
            this.panel4.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Them
            // 
            this.btn_Them.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Them.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_Them.FlatAppearance.BorderSize = 2;
            this.btn_Them.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Them.Image = ((System.Drawing.Image)(resources.GetObject("btn_Them.Image")));
            this.btn_Them.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Them.Location = new System.Drawing.Point(91, 222);
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
            this.label5.Location = new System.Drawing.Point(388, 124);
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
            this.label4.Location = new System.Drawing.Point(388, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "*";
            // 
            // txt_TenChuyenKhoa
            // 
            this.txt_TenChuyenKhoa.BackColor = System.Drawing.SystemColors.Window;
            this.txt_TenChuyenKhoa.BorderColor = System.Drawing.SystemColors.Desktop;
            this.txt_TenChuyenKhoa.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txt_TenChuyenKhoa.BorderRadius = 5;
            this.txt_TenChuyenKhoa.BorderSize = 1;
            this.txt_TenChuyenKhoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_TenChuyenKhoa.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txt_TenChuyenKhoa.Location = new System.Drawing.Point(91, 126);
            this.txt_TenChuyenKhoa.Margin = new System.Windows.Forms.Padding(4);
            this.txt_TenChuyenKhoa.Multiline = false;
            this.txt_TenChuyenKhoa.Name = "txt_TenChuyenKhoa";
            this.txt_TenChuyenKhoa.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txt_TenChuyenKhoa.PasswordChar = false;
            this.txt_TenChuyenKhoa.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_TenChuyenKhoa.PlaceholderText = "";
            this.txt_TenChuyenKhoa.Size = new System.Drawing.Size(279, 35);
            this.txt_TenChuyenKhoa.TabIndex = 7;
            this.txt_TenChuyenKhoa.UnderlinedStyle = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(43, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tên:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(45, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mã:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(70, 56);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(300, 2);
            this.button1.TabIndex = 2;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(127, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Danh mục chuyên khoa";
            // 
            // pn_Left
            // 
            this.pn_Left.BackColor = System.Drawing.Color.White;
            this.pn_Left.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pn_Left.Controls.Add(this.txt_VietTat);
            this.pn_Left.Controls.Add(this.label6);
            this.pn_Left.Controls.Add(this.txt_MaChuyenKhoa);
            this.pn_Left.Controls.Add(this.btn_Them);
            this.pn_Left.Controls.Add(this.label5);
            this.pn_Left.Controls.Add(this.label4);
            this.pn_Left.Controls.Add(this.txt_TenChuyenKhoa);
            this.pn_Left.Controls.Add(this.label3);
            this.pn_Left.Controls.Add(this.label2);
            this.pn_Left.Controls.Add(this.button1);
            this.pn_Left.Controls.Add(this.pictureBox1);
            this.pn_Left.Controls.Add(this.label1);
            this.pn_Left.Dock = System.Windows.Forms.DockStyle.Left;
            this.pn_Left.Location = new System.Drawing.Point(0, 50);
            this.pn_Left.Name = "pn_Left";
            this.pn_Left.Size = new System.Drawing.Size(500, 903);
            this.pn_Left.TabIndex = 2;
            // 
            // txt_VietTat
            // 
            this.txt_VietTat.BackColor = System.Drawing.SystemColors.Window;
            this.txt_VietTat.BorderColor = System.Drawing.SystemColors.Desktop;
            this.txt_VietTat.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txt_VietTat.BorderRadius = 5;
            this.txt_VietTat.BorderSize = 1;
            this.txt_VietTat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_VietTat.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txt_VietTat.Location = new System.Drawing.Point(91, 169);
            this.txt_VietTat.Margin = new System.Windows.Forms.Padding(4);
            this.txt_VietTat.Multiline = false;
            this.txt_VietTat.Name = "txt_VietTat";
            this.txt_VietTat.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txt_VietTat.PasswordChar = false;
            this.txt_VietTat.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_VietTat.PlaceholderText = "";
            this.txt_VietTat.Size = new System.Drawing.Size(279, 35);
            this.txt_VietTat.TabIndex = 13;
            this.txt_VietTat.UnderlinedStyle = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(14, 169);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 23);
            this.label6.TabIndex = 12;
            this.label6.Text = "Viết tắt:";
            // 
            // txt_MaChuyenKhoa
            // 
            this.txt_MaChuyenKhoa.BackColor = System.Drawing.SystemColors.Window;
            this.txt_MaChuyenKhoa.BorderColor = System.Drawing.SystemColors.Desktop;
            this.txt_MaChuyenKhoa.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txt_MaChuyenKhoa.BorderRadius = 5;
            this.txt_MaChuyenKhoa.BorderSize = 1;
            this.txt_MaChuyenKhoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_MaChuyenKhoa.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txt_MaChuyenKhoa.Location = new System.Drawing.Point(91, 82);
            this.txt_MaChuyenKhoa.Margin = new System.Windows.Forms.Padding(4);
            this.txt_MaChuyenKhoa.Multiline = false;
            this.txt_MaChuyenKhoa.Name = "txt_MaChuyenKhoa";
            this.txt_MaChuyenKhoa.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txt_MaChuyenKhoa.PasswordChar = false;
            this.txt_MaChuyenKhoa.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_MaChuyenKhoa.PlaceholderText = "";
            this.txt_MaChuyenKhoa.Size = new System.Drawing.Size(279, 35);
            this.txt_MaChuyenKhoa.TabIndex = 11;
            this.txt_MaChuyenKhoa.UnderlinedStyle = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(83, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(38, 29);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pn_Right
            // 
            this.pn_Right.Controls.Add(this.dtgv_ChuyenKhoa);
            this.pn_Right.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_Right.Location = new System.Drawing.Point(500, 50);
            this.pn_Right.Name = "pn_Right";
            this.pn_Right.Size = new System.Drawing.Size(878, 903);
            this.pn_Right.TabIndex = 3;
            // 
            // dtgv_ChuyenKhoa
            // 
            this.dtgv_ChuyenKhoa.BackgroundColor = System.Drawing.Color.White;
            this.dtgv_ChuyenKhoa.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgv_ChuyenKhoa.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgv_ChuyenKhoa.ColumnHeadersHeight = 29;
            this.dtgv_ChuyenKhoa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaChuyenKhoa,
            this.TenChuyenKhoa,
            this.VietTat});
            this.dtgv_ChuyenKhoa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgv_ChuyenKhoa.Location = new System.Drawing.Point(0, 0);
            this.dtgv_ChuyenKhoa.Name = "dtgv_ChuyenKhoa";
            this.dtgv_ChuyenKhoa.ReadOnly = true;
            this.dtgv_ChuyenKhoa.RowHeadersWidth = 51;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.dtgv_ChuyenKhoa.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgv_ChuyenKhoa.RowTemplate.Height = 29;
            this.dtgv_ChuyenKhoa.Size = new System.Drawing.Size(878, 903);
            this.dtgv_ChuyenKhoa.TabIndex = 0;
            this.dtgv_ChuyenKhoa.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_ChuyenKhoa_CellClick);
            // 
            // MaChuyenKhoa
            // 
            this.MaChuyenKhoa.HeaderText = "Mã";
            this.MaChuyenKhoa.MinimumWidth = 6;
            this.MaChuyenKhoa.Name = "MaChuyenKhoa";
            this.MaChuyenKhoa.ReadOnly = true;
            this.MaChuyenKhoa.Width = 125;
            // 
            // TenChuyenKhoa
            // 
            this.TenChuyenKhoa.HeaderText = "Tên";
            this.TenChuyenKhoa.MinimumWidth = 6;
            this.TenChuyenKhoa.Name = "TenChuyenKhoa";
            this.TenChuyenKhoa.ReadOnly = true;
            this.TenChuyenKhoa.Width = 400;
            // 
            // VietTat
            // 
            this.VietTat.HeaderText = "Viết tắt";
            this.VietTat.MinimumWidth = 6;
            this.VietTat.Name = "VietTat";
            this.VietTat.ReadOnly = true;
            this.VietTat.Width = 250;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.pn_Right);
            this.panel4.Controls.Add(this.pn_Left);
            this.panel4.Controls.Add(this.toolStrip1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1378, 953);
            this.panel4.TabIndex = 3;
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
            this.toolStrip1.TabIndex = 1;
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
            // FrmChuyenKhoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1378, 953);
            this.Controls.Add(this.panel4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmChuyenKhoa";
            this.Text = "FrmChuyenKhoa";
            this.Load += new System.EventHandler(this.FrmChuyenKhoa_Load);
            this.pn_Left.ResumeLayout(false);
            this.pn_Left.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pn_Right.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_ChuyenKhoa)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Button btn_Them;
        private Label label5;
        private Label label4;
        private Demo.Controls.TextBox_NTT txt_TenChuyenKhoa;
        private Label label3;
        private Label label2;
        private Button button1;
        private Label label1;
        private Panel pn_Left;
        private PictureBox pictureBox1;
        private Panel pn_Right;
        private DataGridView dtgv_ChuyenKhoa;
        private Panel panel4;
        private ToolStrip toolStrip1;
        private ToolStripButton toolStripBtn_Luu;
        private ToolStripButton toolStripBtn_Xoa;
        private ToolStripButton toolStripBtn_Refresh;
        private ToolStripButton toolStripBtn_Thoat;
        private Demo.Controls.TextBox_NTT txt_VietTat;
        private Label label6;
        private Demo.Controls.TextBox_NTT txt_MaChuyenKhoa;
        private DataGridViewTextBoxColumn MaChuyenKhoa;
        private DataGridViewTextBoxColumn TenChuyenKhoa;
        private DataGridViewTextBoxColumn VietTat;
    }
}