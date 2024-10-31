namespace DO_AN_LT_WIN.Admin.Chinh
{
    partial class frm_quantrivien
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btn_qlsv = new System.Windows.Forms.Button();
            this.btn_qlgv = new System.Windows.Forms.Button();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.btn_chung = new System.Windows.Forms.Button();
            this.btn_dangxuat = new System.Windows.Forms.Button();
            this.p_user = new System.Windows.Forms.Panel();
            this.p_chung = new System.Windows.Forms.FlowLayoutPanel();
            this.btnMonHoc = new System.Windows.Forms.Button();
            this.btnChuong = new System.Windows.Forms.Button();
            this.btnKyThi = new System.Windows.Forms.Button();
            this.panelContainer.SuspendLayout();
            this.p_chung.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_qlsv
            // 
            this.btn_qlsv.BackColor = System.Drawing.Color.Blue;
            this.btn_qlsv.ForeColor = System.Drawing.Color.Transparent;
            this.btn_qlsv.Location = new System.Drawing.Point(6, 44);
            this.btn_qlsv.Name = "btn_qlsv";
            this.btn_qlsv.Size = new System.Drawing.Size(164, 35);
            this.btn_qlsv.TabIndex = 0;
            this.btn_qlsv.Text = "Quản Lý Sinh Viên";
            this.btn_qlsv.UseVisualStyleBackColor = false;
            this.btn_qlsv.Click += new System.EventHandler(this.btnQuanLySinhVien_Click);
            // 
            // btn_qlgv
            // 
            this.btn_qlgv.BackColor = System.Drawing.Color.Blue;
            this.btn_qlgv.ForeColor = System.Drawing.Color.Transparent;
            this.btn_qlgv.Location = new System.Drawing.Point(6, 85);
            this.btn_qlgv.Name = "btn_qlgv";
            this.btn_qlgv.Size = new System.Drawing.Size(164, 35);
            this.btn_qlgv.TabIndex = 0;
            this.btn_qlgv.Text = "Quản Lý Giảng Viên";
            this.btn_qlgv.UseVisualStyleBackColor = false;
            this.btn_qlgv.Click += new System.EventHandler(this.btnQuanLyGiaoVien_Click);
            // 
            // panelContainer
            // 
            this.panelContainer.Controls.Add(this.btn_chung);
            this.panelContainer.Controls.Add(this.btn_dangxuat);
            this.panelContainer.Controls.Add(this.btn_qlgv);
            this.panelContainer.Controls.Add(this.btn_qlsv);
            this.panelContainer.Location = new System.Drawing.Point(12, 12);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(170, 648);
            this.panelContainer.TabIndex = 2;
            // 
            // btn_chung
            // 
            this.btn_chung.BackColor = System.Drawing.Color.Blue;
            this.btn_chung.ForeColor = System.Drawing.Color.White;
            this.btn_chung.Location = new System.Drawing.Point(3, 3);
            this.btn_chung.Name = "btn_chung";
            this.btn_chung.Size = new System.Drawing.Size(164, 35);
            this.btn_chung.TabIndex = 1;
            this.btn_chung.Text = "Chung";
            this.btn_chung.UseVisualStyleBackColor = false;
            this.btn_chung.Click += new System.EventHandler(this.btn_chung_Click);
            // 
            // btn_dangxuat
            // 
            this.btn_dangxuat.BackColor = System.Drawing.Color.Blue;
            this.btn_dangxuat.ForeColor = System.Drawing.Color.Transparent;
            this.btn_dangxuat.Location = new System.Drawing.Point(6, 610);
            this.btn_dangxuat.Name = "btn_dangxuat";
            this.btn_dangxuat.Size = new System.Drawing.Size(164, 35);
            this.btn_dangxuat.TabIndex = 0;
            this.btn_dangxuat.Text = "Đăng Xuất";
            this.btn_dangxuat.UseVisualStyleBackColor = false;
            this.btn_dangxuat.Click += new System.EventHandler(this.btn_dangxuat_Click);
            // 
            // p_user
            // 
            this.p_user.Location = new System.Drawing.Point(188, 56);
            this.p_user.Name = "p_user";
            this.p_user.Size = new System.Drawing.Size(1159, 604);
            this.p_user.TabIndex = 3;
            // 
            // p_chung
            // 
            this.p_chung.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.p_chung.Controls.Add(this.btnMonHoc);
            this.p_chung.Controls.Add(this.btnChuong);
            this.p_chung.Controls.Add(this.btnKyThi);
            this.p_chung.Location = new System.Drawing.Point(188, 12);
            this.p_chung.Name = "p_chung";
            this.p_chung.Size = new System.Drawing.Size(420, 38);
            this.p_chung.TabIndex = 3;
            // 
            // btnMonHoc
            // 
            this.btnMonHoc.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnMonHoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnMonHoc.ForeColor = System.Drawing.Color.Transparent;
            this.btnMonHoc.Location = new System.Drawing.Point(3, 3);
            this.btnMonHoc.Name = "btnMonHoc";
            this.btnMonHoc.Size = new System.Drawing.Size(134, 35);
            this.btnMonHoc.TabIndex = 3;
            this.btnMonHoc.Text = "Môn học";
            this.btnMonHoc.UseVisualStyleBackColor = false;
            this.btnMonHoc.Click += new System.EventHandler(this.btnMonHoc_Click);
            // 
            // btnChuong
            // 
            this.btnChuong.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnChuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnChuong.ForeColor = System.Drawing.Color.Transparent;
            this.btnChuong.Location = new System.Drawing.Point(143, 3);
            this.btnChuong.Name = "btnChuong";
            this.btnChuong.Size = new System.Drawing.Size(134, 35);
            this.btnChuong.TabIndex = 2;
            this.btnChuong.Text = "Chương";
            this.btnChuong.UseVisualStyleBackColor = false;
            this.btnChuong.Click += new System.EventHandler(this.btnChuong_Click);
            // 
            // btnKyThi
            // 
            this.btnKyThi.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnKyThi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnKyThi.ForeColor = System.Drawing.Color.White;
            this.btnKyThi.Location = new System.Drawing.Point(283, 3);
            this.btnKyThi.Name = "btnKyThi";
            this.btnKyThi.Size = new System.Drawing.Size(134, 35);
            this.btnKyThi.TabIndex = 4;
            this.btnKyThi.Text = "Kỳ thi";
            this.btnKyThi.UseVisualStyleBackColor = false;
            this.btnKyThi.Click += new System.EventHandler(this.btnKyThi_Click);
            // 
            // frm_quantrivien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1359, 672);
            this.Controls.Add(this.p_chung);
            this.Controls.Add(this.p_user);
            this.Controls.Add(this.panelContainer);
            this.Name = "frm_quantrivien";
            this.Text = "Quản Trị Viên";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_quantrivien_FormClosing);
            //this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frm_quantrivien_FormClosed);
            this.Load += new System.EventHandler(this.frm_quantrivien_Load);
            this.panelContainer.ResumeLayout(false);
            this.p_chung.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btn_qlsv;
        private System.Windows.Forms.Button btn_qlgv;
        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.Button btn_chung;
        private System.Windows.Forms.Panel p_user;
        private System.Windows.Forms.Button btn_dangxuat;
        private System.Windows.Forms.FlowLayoutPanel p_chung;
        private System.Windows.Forms.Button btnMonHoc;
        private System.Windows.Forms.Button btnChuong;
        private System.Windows.Forms.Button btnKyThi;
    }
}

