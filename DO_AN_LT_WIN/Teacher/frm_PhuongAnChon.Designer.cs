namespace DO_AN_LT_WIN.Teacher
{
    partial class frm_PhuongAnChon
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
            this.dgv_PhuongAn = new System.Windows.Forms.DataGridView();
            this.btn_Them = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_noidungpa = new System.Windows.Forms.TextBox();
            this.txt_pa = new System.Windows.Forms.TextBox();
            this.btn_sua = new System.Windows.Forms.Button();
            this.lbl_stt = new System.Windows.Forms.Label();
            this.txt_stt = new System.Windows.Forms.TextBox();
            this.lbl_macauhoi = new System.Windows.Forms.Label();
            this.txt_macauhoi = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.clm_stt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_macauhoi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_noidungpa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_paChon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_PhuongAn)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_PhuongAn
            // 
            this.dgv_PhuongAn.AllowUserToAddRows = false;
            this.dgv_PhuongAn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_PhuongAn.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clm_stt,
            this.clm_macauhoi,
            this.clm_noidungpa,
            this.clm_paChon});
            this.dgv_PhuongAn.Location = new System.Drawing.Point(1, 239);
            this.dgv_PhuongAn.Name = "dgv_PhuongAn";
            this.dgv_PhuongAn.ReadOnly = true;
            this.dgv_PhuongAn.RowHeadersWidth = 51;
            this.dgv_PhuongAn.RowTemplate.Height = 24;
            this.dgv_PhuongAn.Size = new System.Drawing.Size(824, 374);
            this.dgv_PhuongAn.TabIndex = 0;
            this.dgv_PhuongAn.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_PhuongAn_CellClick);
            // 
            // btn_Them
            // 
            this.btn_Them.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_Them.Location = new System.Drawing.Point(398, 184);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(110, 31);
            this.btn_Them.TabIndex = 1;
            this.btn_Them.Text = "Thêm ";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(12, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nội dung phương án";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(12, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Phương án chọn";
            // 
            // txt_noidungpa
            // 
            this.txt_noidungpa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_noidungpa.Location = new System.Drawing.Point(239, 100);
            this.txt_noidungpa.Name = "txt_noidungpa";
            this.txt_noidungpa.Size = new System.Drawing.Size(397, 30);
            this.txt_noidungpa.TabIndex = 4;
            // 
            // txt_pa
            // 
            this.txt_pa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_pa.Location = new System.Drawing.Point(239, 139);
            this.txt_pa.Name = "txt_pa";
            this.txt_pa.Size = new System.Drawing.Size(290, 30);
            this.txt_pa.TabIndex = 5;
            // 
            // btn_sua
            // 
            this.btn_sua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_sua.Location = new System.Drawing.Point(514, 184);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(109, 31);
            this.btn_sua.TabIndex = 6;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = true;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // lbl_stt
            // 
            this.lbl_stt.AutoSize = true;
            this.lbl_stt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_stt.Location = new System.Drawing.Point(12, 31);
            this.lbl_stt.Name = "lbl_stt";
            this.lbl_stt.Size = new System.Drawing.Size(52, 25);
            this.lbl_stt.TabIndex = 7;
            this.lbl_stt.Text = "STT";
            // 
            // txt_stt
            // 
            this.txt_stt.Enabled = false;
            this.txt_stt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_stt.Location = new System.Drawing.Point(239, 28);
            this.txt_stt.Name = "txt_stt";
            this.txt_stt.ReadOnly = true;
            this.txt_stt.Size = new System.Drawing.Size(196, 30);
            this.txt_stt.TabIndex = 8;
            // 
            // lbl_macauhoi
            // 
            this.lbl_macauhoi.AutoSize = true;
            this.lbl_macauhoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_macauhoi.Location = new System.Drawing.Point(12, 66);
            this.lbl_macauhoi.Name = "lbl_macauhoi";
            this.lbl_macauhoi.Size = new System.Drawing.Size(108, 25);
            this.lbl_macauhoi.TabIndex = 9;
            this.lbl_macauhoi.Text = "Mã câu hỏi";
            // 
            // txt_macauhoi
            // 
            this.txt_macauhoi.Enabled = false;
            this.txt_macauhoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_macauhoi.Location = new System.Drawing.Point(239, 63);
            this.txt_macauhoi.Name = "txt_macauhoi";
            this.txt_macauhoi.ReadOnly = true;
            this.txt_macauhoi.Size = new System.Drawing.Size(196, 30);
            this.txt_macauhoi.TabIndex = 10;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_noidungpa);
            this.groupBox1.Controls.Add(this.txt_macauhoi);
            this.groupBox1.Controls.Add(this.btn_Them);
            this.groupBox1.Controls.Add(this.lbl_macauhoi);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_stt);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lbl_stt);
            this.groupBox1.Controls.Add(this.txt_pa);
            this.groupBox1.Controls.Add(this.btn_sua);
            this.groupBox1.Location = new System.Drawing.Point(98, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(642, 221);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin";
            // 
            // clm_stt
            // 
            this.clm_stt.HeaderText = "STT";
            this.clm_stt.MinimumWidth = 6;
            this.clm_stt.Name = "clm_stt";
            this.clm_stt.ReadOnly = true;
            this.clm_stt.Width = 50;
            // 
            // clm_macauhoi
            // 
            this.clm_macauhoi.FillWeight = 50F;
            this.clm_macauhoi.HeaderText = "Mã câu hỏi";
            this.clm_macauhoi.MinimumWidth = 6;
            this.clm_macauhoi.Name = "clm_macauhoi";
            this.clm_macauhoi.ReadOnly = true;
            this.clm_macauhoi.Width = 240;
            // 
            // clm_noidungpa
            // 
            this.clm_noidungpa.FillWeight = 150F;
            this.clm_noidungpa.HeaderText = "Nội dung phương án";
            this.clm_noidungpa.MinimumWidth = 6;
            this.clm_noidungpa.Name = "clm_noidungpa";
            this.clm_noidungpa.ReadOnly = true;
            this.clm_noidungpa.Width = 240;
            // 
            // clm_paChon
            // 
            this.clm_paChon.HeaderText = "Phương án chọn";
            this.clm_paChon.MinimumWidth = 6;
            this.clm_paChon.Name = "clm_paChon";
            this.clm_paChon.ReadOnly = true;
            this.clm_paChon.Width = 240;
            // 
            // frm_PhuongAnChon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 625);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgv_PhuongAn);
            this.Name = "frm_PhuongAnChon";
            this.Text = "frm_PhuongAnChon";
            this.Load += new System.EventHandler(this.frm_PhuongAnChon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_PhuongAn)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_PhuongAn;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_noidungpa;
        private System.Windows.Forms.TextBox txt_pa;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Label lbl_stt;
        private System.Windows.Forms.TextBox txt_stt;
        private System.Windows.Forms.Label lbl_macauhoi;
        private System.Windows.Forms.TextBox txt_macauhoi;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_stt;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_macauhoi;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_noidungpa;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_paChon;
    }
}