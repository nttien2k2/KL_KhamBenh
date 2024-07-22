namespace GUI
{
    partial class FrmPhieuChiDinh
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
            this.ReprotViewer_PhieuChiDinh = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // ReprotViewer_PhieuChiDinh
            // 
            this.ReprotViewer_PhieuChiDinh.Location = new System.Drawing.Point(0, 0);
            this.ReprotViewer_PhieuChiDinh.Name = "ReportViewer";
            this.ReprotViewer_PhieuChiDinh.ServerReport.BearerToken = null;
            this.ReprotViewer_PhieuChiDinh.Size = new System.Drawing.Size(396, 246);
            this.ReprotViewer_PhieuChiDinh.TabIndex = 0;
            // 
            // FrmPhieuChiDinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "FrmPhieuChiDinh";
            this.Text = "FrmPhieuChiDinh";
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer ReprotViewer_PhieuChiDinh;
    }
}