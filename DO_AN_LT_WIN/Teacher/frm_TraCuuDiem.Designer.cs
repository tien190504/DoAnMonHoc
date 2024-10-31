namespace DO_AN_LT_WIN.Teacher
{
    partial class frm_TraCuuDiem
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
            this.cb_Mon = new System.Windows.Forms.ComboBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.cb_KyThi = new System.Windows.Forms.ComboBox();
            this.btnHuy = new System.Windows.Forms.Button();
            this.dgv_tracuu = new System.Windows.Forms.DataGridView();
            this.clm_maBaiThi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_masv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_batdau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_ketthuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_socaudung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_diem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtReport = new System.Windows.Forms.Button();
            this.btnTraCuu = new System.Windows.Forms.Button();
            this.txtHoTenSV = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaSV = new System.Windows.Forms.TextBox();
            this.txtDiem = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tracuu)).BeginInit();
            this.SuspendLayout();
            // 
            // cb_Mon
            // 
            this.cb_Mon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Mon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cb_Mon.FormattingEnabled = true;
            this.cb_Mon.Location = new System.Drawing.Point(16, 29);
            this.cb_Mon.Name = "cb_Mon";
            this.cb_Mon.Size = new System.Drawing.Size(285, 33);
            this.cb_Mon.TabIndex = 0;
            // 
            // cb_KyThi
            // 
            this.cb_KyThi.FormattingEnabled = true;
            this.cb_KyThi.Location = new System.Drawing.Point(1, -1);
            this.cb_KyThi.Name = "cb_KyThi";
            this.cb_KyThi.Size = new System.Drawing.Size(230, 24);
            this.cb_KyThi.TabIndex = 1;
            this.cb_KyThi.Visible = false;
            // 
            // btnHuy
            // 
            this.btnHuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnHuy.Location = new System.Drawing.Point(613, 126);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(104, 39);
            this.btnHuy.TabIndex = 2;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // dgv_tracuu
            // 
            this.dgv_tracuu.AllowUserToAddRows = false;
            this.dgv_tracuu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_tracuu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_tracuu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clm_maBaiThi,
            this.clm_masv,
            this.clm_batdau,
            this.clm_ketthuc,
            this.clm_socaudung,
            this.clm_diem});
            this.dgv_tracuu.Location = new System.Drawing.Point(1, 171);
            this.dgv_tracuu.Name = "dgv_tracuu";
            this.dgv_tracuu.ReadOnly = true;
            this.dgv_tracuu.RowHeadersWidth = 51;
            this.dgv_tracuu.RowTemplate.Height = 24;
            this.dgv_tracuu.Size = new System.Drawing.Size(855, 336);
            this.dgv_tracuu.TabIndex = 3;
            this.dgv_tracuu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_tracuu_CellClick);
            // 
            // clm_maBaiThi
            // 
            this.clm_maBaiThi.HeaderText = "Mã bài thi";
            this.clm_maBaiThi.MinimumWidth = 6;
            this.clm_maBaiThi.Name = "clm_maBaiThi";
            this.clm_maBaiThi.ReadOnly = true;
            // 
            // clm_masv
            // 
            this.clm_masv.HeaderText = "Mã sinh viên";
            this.clm_masv.MinimumWidth = 6;
            this.clm_masv.Name = "clm_masv";
            this.clm_masv.ReadOnly = true;
            // 
            // clm_batdau
            // 
            this.clm_batdau.FillWeight = 150F;
            this.clm_batdau.HeaderText = "Thời gian bắt đầu";
            this.clm_batdau.MinimumWidth = 6;
            this.clm_batdau.Name = "clm_batdau";
            this.clm_batdau.ReadOnly = true;
            // 
            // clm_ketthuc
            // 
            this.clm_ketthuc.FillWeight = 150F;
            this.clm_ketthuc.HeaderText = "Thời gian kết thúc";
            this.clm_ketthuc.MinimumWidth = 6;
            this.clm_ketthuc.Name = "clm_ketthuc";
            this.clm_ketthuc.ReadOnly = true;
            // 
            // clm_socaudung
            // 
            this.clm_socaudung.FillWeight = 50F;
            this.clm_socaudung.HeaderText = "Số câu đúng";
            this.clm_socaudung.MinimumWidth = 6;
            this.clm_socaudung.Name = "clm_socaudung";
            this.clm_socaudung.ReadOnly = true;
            // 
            // clm_diem
            // 
            this.clm_diem.FillWeight = 50F;
            this.clm_diem.HeaderText = "Điểm";
            this.clm_diem.MinimumWidth = 6;
            this.clm_diem.Name = "clm_diem";
            this.clm_diem.ReadOnly = true;
            // 
            // txtReport
            // 
            this.txtReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtReport.Location = new System.Drawing.Point(723, 126);
            this.txtReport.Name = "txtReport";
            this.txtReport.Size = new System.Drawing.Size(123, 39);
            this.txtReport.TabIndex = 2;
            this.txtReport.Text = "Report";
            this.txtReport.UseVisualStyleBackColor = true;
            this.txtReport.Click += new System.EventHandler(this.txtReport_Click);
            // 
            // btnTraCuu
            // 
            this.btnTraCuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnTraCuu.Location = new System.Drawing.Point(307, 25);
            this.btnTraCuu.Name = "btnTraCuu";
            this.btnTraCuu.Size = new System.Drawing.Size(112, 39);
            this.btnTraCuu.TabIndex = 2;
            this.btnTraCuu.Text = "Tra cứu";
            this.btnTraCuu.UseVisualStyleBackColor = true;
            this.btnTraCuu.Click += new System.EventHandler(this.btn_TraCuu_Click);
            // 
            // txtHoTenSV
            // 
            this.txtHoTenSV.Enabled = false;
            this.txtHoTenSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtHoTenSV.Location = new System.Drawing.Point(313, 79);
            this.txtHoTenSV.Name = "txtHoTenSV";
            this.txtHoTenSV.Size = new System.Drawing.Size(201, 30);
            this.txtHoTenSV.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(11, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Sinh viên";
            // 
            // txtMaSV
            // 
            this.txtMaSV.Enabled = false;
            this.txtMaSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtMaSV.Location = new System.Drawing.Point(106, 79);
            this.txtMaSV.Name = "txtMaSV";
            this.txtMaSV.Size = new System.Drawing.Size(201, 30);
            this.txtMaSV.TabIndex = 4;
            this.txtMaSV.TextChanged += new System.EventHandler(this.txtMaSV_TextChanged);
            // 
            // txtDiem
            // 
            this.txtDiem.Enabled = false;
            this.txtDiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtDiem.Location = new System.Drawing.Point(524, 79);
            this.txtDiem.Name = "txtDiem";
            this.txtDiem.Size = new System.Drawing.Size(63, 30);
            this.txtDiem.TabIndex = 4;
            this.txtDiem.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtDiem.TextChanged += new System.EventHandler(this.txtMaSV_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(593, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Đ";
            // 
            // frm_TraCuuDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 512);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDiem);
            this.Controls.Add(this.txtMaSV);
            this.Controls.Add(this.txtHoTenSV);
            this.Controls.Add(this.dgv_tracuu);
            this.Controls.Add(this.txtReport);
            this.Controls.Add(this.btnTraCuu);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.cb_KyThi);
            this.Controls.Add(this.cb_Mon);
            this.Name = "frm_TraCuuDiem";
            this.Text = "Tra cứu điểm sinh viên";
            this.Load += new System.EventHandler(this.frm_TraCuuDiem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tracuu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_Mon;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ComboBox cb_KyThi;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.DataGridView dgv_tracuu;
        private System.Windows.Forms.Button txtReport;
        private System.Windows.Forms.Button btnTraCuu;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_maBaiThi;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_masv;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_batdau;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_ketthuc;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_socaudung;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_diem;
        private System.Windows.Forms.TextBox txtHoTenSV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaSV;
        private System.Windows.Forms.TextBox txtDiem;
        private System.Windows.Forms.Label label2;
    }
}