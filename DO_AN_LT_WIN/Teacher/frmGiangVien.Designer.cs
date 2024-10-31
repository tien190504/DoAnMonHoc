namespace DO_AN_LT_WIN.Teacher
{
    partial class frmGiangVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGiangVien));
            this.btnTraDiem = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_QLCauHoi = new System.Windows.Forms.Button();
            this.btn_dangxuat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnTraDiem
            // 
            this.btnTraDiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTraDiem.Location = new System.Drawing.Point(3, 57);
            this.btnTraDiem.Name = "btnTraDiem";
            this.btnTraDiem.Size = new System.Drawing.Size(169, 40);
            this.btnTraDiem.TabIndex = 0;
            this.btnTraDiem.Text = "Tra cứu điểm";
            this.btnTraDiem.UseVisualStyleBackColor = true;
            this.btnTraDiem.Click += new System.EventHandler(this.btnTraDiem_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(178, 57);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(966, 479);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(403, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(383, 42);
            this.label1.TabIndex = 2;
            this.label1.Text = "Quyền hạn giảng viên";
            // 
            // btn_QLCauHoi
            // 
            this.btn_QLCauHoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_QLCauHoi.Location = new System.Drawing.Point(3, 103);
            this.btn_QLCauHoi.Name = "btn_QLCauHoi";
            this.btn_QLCauHoi.Size = new System.Drawing.Size(169, 40);
            this.btn_QLCauHoi.TabIndex = 4;
            this.btn_QLCauHoi.Text = "Quản lý câu hỏi";
            this.btn_QLCauHoi.UseVisualStyleBackColor = true;
            this.btn_QLCauHoi.Click += new System.EventHandler(this.btnQuanlycauhoi_Click);
            // 
            // btn_dangxuat
            // 
            this.btn_dangxuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dangxuat.Location = new System.Drawing.Point(3, 486);
            this.btn_dangxuat.Name = "btn_dangxuat";
            this.btn_dangxuat.Size = new System.Drawing.Size(169, 40);
            this.btn_dangxuat.TabIndex = 4;
            this.btn_dangxuat.Text = "Đăng xuất";
            this.btn_dangxuat.UseVisualStyleBackColor = true;
            this.btn_dangxuat.Click += new System.EventHandler(this.btn_dangxuat_Click);
            // 
            // frmGiangVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1156, 548);
            this.Controls.Add(this.btn_dangxuat);
            this.Controls.Add(this.btn_QLCauHoi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnTraDiem);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmGiangVien";
            this.Text = "Main";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmGiangVien_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTraDiem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_QLCauHoi;
        private System.Windows.Forms.Button btn_dangxuat;
    }
}

