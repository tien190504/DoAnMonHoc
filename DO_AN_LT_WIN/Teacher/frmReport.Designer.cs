namespace DO_AN_LT_WIN.Teacher
{
    partial class frmReport
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
            this.txtMaMonHoc = new System.Windows.Forms.TextBox();
            this.rpvDiem = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // txtMaMonHoc
            // 
            this.txtMaMonHoc.Enabled = false;
            this.txtMaMonHoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtMaMonHoc.Location = new System.Drawing.Point(1, 2);
            this.txtMaMonHoc.Name = "txtMaMonHoc";
            this.txtMaMonHoc.Size = new System.Drawing.Size(1308, 34);
            this.txtMaMonHoc.TabIndex = 0;
            this.txtMaMonHoc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // rpvDiem
            // 
            this.rpvDiem.Location = new System.Drawing.Point(1, 42);
            this.rpvDiem.Name = "rpvDiem";
            this.rpvDiem.ServerReport.BearerToken = null;
            this.rpvDiem.Size = new System.Drawing.Size(1308, 439);
            this.rpvDiem.TabIndex = 1;
            // 
            // frmReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1309, 482);
            this.Controls.Add(this.rpvDiem);
            this.Controls.Add(this.txtMaMonHoc);
            this.Name = "frmReport";
            this.Text = "frmReport";
            this.Load += new System.EventHandler(this.frmReport_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMaMonHoc;
        private Microsoft.Reporting.WinForms.ReportViewer rpvDiem;
    }
}