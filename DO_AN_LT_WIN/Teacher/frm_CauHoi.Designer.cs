namespace DO_AN_LT_WIN.Teacher
{
    partial class frm_CauHoi
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
            this.dgv_cauhoi = new System.Windows.Forms.DataGridView();
            this.btn_Them = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.lbl_macauhoi = new System.Windows.Forms.Label();
            this.lbl_phuongandung = new System.Windows.Forms.Label();
            this.lbl_noidungcauhoi = new System.Windows.Forms.Label();
            this.txt_macauhoi = new System.Windows.Forms.TextBox();
            this.txt_noidungcauhoi = new System.Windows.Forms.TextBox();
            this.txt_phuongandung = new System.Windows.Forms.TextBox();
            this.btn_xemPA = new System.Windows.Forms.Button();
            this.clm_MaCauHoi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_NoiDung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_PhuongAnDung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cauhoi)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_cauhoi
            // 
            this.dgv_cauhoi.AllowUserToAddRows = false;
            this.dgv_cauhoi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_cauhoi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_cauhoi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clm_MaCauHoi,
            this.clm_NoiDung,
            this.clm_PhuongAnDung});
            this.dgv_cauhoi.Location = new System.Drawing.Point(0, 294);
            this.dgv_cauhoi.Name = "dgv_cauhoi";
            this.dgv_cauhoi.ReadOnly = true;
            this.dgv_cauhoi.RowHeadersWidth = 51;
            this.dgv_cauhoi.RowTemplate.Height = 24;
            this.dgv_cauhoi.Size = new System.Drawing.Size(1016, 306);
            this.dgv_cauhoi.TabIndex = 2;
            this.dgv_cauhoi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_cauhoi_CellClick);
            // 
            // btn_Them
            // 
            this.btn_Them.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_Them.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_Them.Location = new System.Drawing.Point(754, 249);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(101, 39);
            this.btn_Them.TabIndex = 3;
            this.btn_Them.Text = "Thêm ";
            this.btn_Them.UseVisualStyleBackColor = false;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_sua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_sua.Location = new System.Drawing.Point(873, 249);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(108, 39);
            this.btn_sua.TabIndex = 4;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = false;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // lbl_macauhoi
            // 
            this.lbl_macauhoi.AutoSize = true;
            this.lbl_macauhoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_macauhoi.Location = new System.Drawing.Point(32, 35);
            this.lbl_macauhoi.Name = "lbl_macauhoi";
            this.lbl_macauhoi.Size = new System.Drawing.Size(108, 25);
            this.lbl_macauhoi.TabIndex = 5;
            this.lbl_macauhoi.Text = "Mã câu hỏi";
            // 
            // lbl_phuongandung
            // 
            this.lbl_phuongandung.AutoSize = true;
            this.lbl_phuongandung.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_phuongandung.Location = new System.Drawing.Point(32, 147);
            this.lbl_phuongandung.Name = "lbl_phuongandung";
            this.lbl_phuongandung.Size = new System.Drawing.Size(156, 25);
            this.lbl_phuongandung.TabIndex = 6;
            this.lbl_phuongandung.Text = "Phương án đúng";
            // 
            // lbl_noidungcauhoi
            // 
            this.lbl_noidungcauhoi.AutoSize = true;
            this.lbl_noidungcauhoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_noidungcauhoi.Location = new System.Drawing.Point(32, 89);
            this.lbl_noidungcauhoi.Name = "lbl_noidungcauhoi";
            this.lbl_noidungcauhoi.Size = new System.Drawing.Size(158, 25);
            this.lbl_noidungcauhoi.TabIndex = 6;
            this.lbl_noidungcauhoi.Text = "Nội dung câu hỏi";
            // 
            // txt_macauhoi
            // 
            this.txt_macauhoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_macauhoi.Location = new System.Drawing.Point(241, 36);
            this.txt_macauhoi.Name = "txt_macauhoi";
            this.txt_macauhoi.Size = new System.Drawing.Size(457, 30);
            this.txt_macauhoi.TabIndex = 7;
            // 
            // txt_noidungcauhoi
            // 
            this.txt_noidungcauhoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_noidungcauhoi.Location = new System.Drawing.Point(241, 84);
            this.txt_noidungcauhoi.Name = "txt_noidungcauhoi";
            this.txt_noidungcauhoi.Size = new System.Drawing.Size(457, 30);
            this.txt_noidungcauhoi.TabIndex = 8;
            // 
            // txt_phuongandung
            // 
            this.txt_phuongandung.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_phuongandung.Location = new System.Drawing.Point(241, 142);
            this.txt_phuongandung.Name = "txt_phuongandung";
            this.txt_phuongandung.Size = new System.Drawing.Size(144, 30);
            this.txt_phuongandung.TabIndex = 9;
            // 
            // btn_xemPA
            // 
            this.btn_xemPA.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_xemPA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_xemPA.Location = new System.Drawing.Point(561, 166);
            this.btn_xemPA.Name = "btn_xemPA";
            this.btn_xemPA.Size = new System.Drawing.Size(210, 44);
            this.btn_xemPA.TabIndex = 11;
            this.btn_xemPA.Text = "Xem phương án";
            this.btn_xemPA.UseVisualStyleBackColor = false;
            this.btn_xemPA.Click += new System.EventHandler(this.btn_xemPA_Click);
            // 
            // clm_MaCauHoi
            // 
            this.clm_MaCauHoi.FillWeight = 50F;
            this.clm_MaCauHoi.HeaderText = "Mã câu hỏi";
            this.clm_MaCauHoi.MinimumWidth = 6;
            this.clm_MaCauHoi.Name = "clm_MaCauHoi";
            this.clm_MaCauHoi.ReadOnly = true;
            // 
            // clm_NoiDung
            // 
            this.clm_NoiDung.FillWeight = 200F;
            this.clm_NoiDung.HeaderText = "Nội dung câu hỏi";
            this.clm_NoiDung.MinimumWidth = 6;
            this.clm_NoiDung.Name = "clm_NoiDung";
            this.clm_NoiDung.ReadOnly = true;
            // 
            // clm_PhuongAnDung
            // 
            this.clm_PhuongAnDung.FillWeight = 50F;
            this.clm_PhuongAnDung.HeaderText = "Phương án đúng";
            this.clm_PhuongAnDung.MinimumWidth = 6;
            this.clm_PhuongAnDung.Name = "clm_PhuongAnDung";
            this.clm_PhuongAnDung.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_noidungcauhoi);
            this.groupBox1.Controls.Add(this.btn_xemPA);
            this.groupBox1.Controls.Add(this.lbl_macauhoi);
            this.groupBox1.Controls.Add(this.txt_phuongandung);
            this.groupBox1.Controls.Add(this.lbl_phuongandung);
            this.groupBox1.Controls.Add(this.lbl_noidungcauhoi);
            this.groupBox1.Controls.Add(this.txt_macauhoi);
            this.groupBox1.Location = new System.Drawing.Point(123, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(777, 216);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin";
            // 
            // frm_CauHoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 601);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.dgv_cauhoi);
            this.Name = "frm_CauHoi";
            this.Text = "frmCauHoi";
            this.Load += new System.EventHandler(this.frmCauHoi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cauhoi)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_cauhoi;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Label lbl_macauhoi;
        private System.Windows.Forms.Label lbl_phuongandung;
        private System.Windows.Forms.Label lbl_noidungcauhoi;
        private System.Windows.Forms.TextBox txt_macauhoi;
        private System.Windows.Forms.TextBox txt_noidungcauhoi;
        private System.Windows.Forms.TextBox txt_phuongandung;
        private System.Windows.Forms.Button btn_xemPA;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_MaCauHoi;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_NoiDung;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_PhuongAnDung;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}