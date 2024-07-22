namespace Demo
{
    partial class FrmSaoLuuPhucHoi
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
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.btn_RestoreFull = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dtgv_Restore = new System.Windows.Forms.DataGridView();
            this.FileName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BackupFilePath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pn_Right = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBackupFull = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_Restore)).BeginInit();
            this.pn_Right.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.Location = new System.Drawing.Point(645, 316);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(94, 29);
            this.btn_Refresh.TabIndex = 7;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.UseVisualStyleBackColor = true;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // btn_RestoreFull
            // 
            this.btn_RestoreFull.Location = new System.Drawing.Point(325, 267);
            this.btn_RestoreFull.Name = "btn_RestoreFull";
            this.btn_RestoreFull.Size = new System.Drawing.Size(165, 63);
            this.btn_RestoreFull.TabIndex = 5;
            this.btn_RestoreFull.Text = "Restore Full";
            this.btn_RestoreFull.UseVisualStyleBackColor = true;
            this.btn_RestoreFull.Click += new System.EventHandler(this.RestoreFull_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Showcard Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(350, 214);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 29);
            this.label2.TabIndex = 11;
            this.label2.Text = "Restore";
            // 
            // dtgv_Restore
            // 
            this.dtgv_Restore.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgv_Restore.BackgroundColor = System.Drawing.Color.White;
            this.dtgv_Restore.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgv_Restore.ColumnHeadersHeight = 29;
            this.dtgv_Restore.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FileName,
            this.BackupFilePath});
            this.dtgv_Restore.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dtgv_Restore.Location = new System.Drawing.Point(0, 351);
            this.dtgv_Restore.MultiSelect = false;
            this.dtgv_Restore.Name = "dtgv_Restore";
            this.dtgv_Restore.ReadOnly = true;
            this.dtgv_Restore.RowHeadersWidth = 51;
            this.dtgv_Restore.Size = new System.Drawing.Size(780, 400);
            this.dtgv_Restore.TabIndex = 12;
            this.dtgv_Restore.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_Restore_CellClick);
            // 
            // FileName
            // 
            this.FileName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.FileName.HeaderText = "File Name";
            this.FileName.MinimumWidth = 6;
            this.FileName.Name = "FileName";
            this.FileName.ReadOnly = true;
            this.FileName.Width = 400;
            // 
            // BackupFilePath
            // 
            this.BackupFilePath.HeaderText = "File Path";
            this.BackupFilePath.MinimumWidth = 6;
            this.BackupFilePath.Name = "BackupFilePath";
            this.BackupFilePath.ReadOnly = true;
            this.BackupFilePath.Width = 400;
            // 
            // pn_Right
            // 
            this.pn_Right.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pn_Right.Controls.Add(this.label1);
            this.pn_Right.Controls.Add(this.btnBackupFull);
            this.pn_Right.Controls.Add(this.btn_RestoreFull);
            this.pn_Right.Controls.Add(this.btn_Refresh);
            this.pn_Right.Controls.Add(this.dtgv_Restore);
            this.pn_Right.Controls.Add(this.label2);
            this.pn_Right.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_Right.Location = new System.Drawing.Point(0, 0);
            this.pn_Right.Name = "pn_Right";
            this.pn_Right.Size = new System.Drawing.Size(782, 753);
            this.pn_Right.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(350, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 29);
            this.label1.TabIndex = 16;
            this.label1.Text = "Backup";
            // 
            // btnBackupFull
            // 
            this.btnBackupFull.Location = new System.Drawing.Point(325, 100);
            this.btnBackupFull.Name = "btnBackupFull";
            this.btnBackupFull.Size = new System.Drawing.Size(165, 51);
            this.btnBackupFull.TabIndex = 13;
            this.btnBackupFull.Text = "Backup Full";
            this.btnBackupFull.UseVisualStyleBackColor = true;
            this.btnBackupFull.Click += new System.EventHandler(this.btnBackupFull_Click);
            // 
            // FrmSaoLuuPhucHoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 753);
            this.Controls.Add(this.pn_Right);
            this.Name = "FrmSaoLuuPhucHoi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmSaoLuuPhucHoi";
            this.Load += new System.EventHandler(this.FrmSaoLuuPhucHoi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_Restore)).EndInit();
            this.pn_Right.ResumeLayout(false);
            this.pn_Right.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Button btn_Refresh;
        private Button btn_RestoreFull;
        private Label label2;
        private DataGridView dtgv_Restore;
        private Panel pn_Right;
        private Label label1;
        private Button btnBackupFull;
        private DataGridViewTextBoxColumn FileName;
        private DataGridViewTextBoxColumn BackupFilePath;
    }
}