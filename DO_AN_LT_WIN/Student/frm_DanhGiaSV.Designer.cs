namespace DO_AN_LT_WIN.Student
{
    partial class frm_DanhGiaSV
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_danhgia = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_luudanhgia = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nội dung đánh giá";
            // 
            // txt_danhgia
            // 
            this.txt_danhgia.Location = new System.Drawing.Point(6, 67);
            this.txt_danhgia.Multiline = true;
            this.txt_danhgia.Name = "txt_danhgia";
            this.txt_danhgia.Size = new System.Drawing.Size(460, 234);
            this.txt_danhgia.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_danhgia);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(121, 79);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(472, 318);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin đánh giá";
            // 
            // btn_luudanhgia
            // 
            this.btn_luudanhgia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_luudanhgia.Location = new System.Drawing.Point(461, 425);
            this.btn_luudanhgia.Name = "btn_luudanhgia";
            this.btn_luudanhgia.Size = new System.Drawing.Size(126, 43);
            this.btn_luudanhgia.TabIndex = 5;
            this.btn_luudanhgia.Text = "Lưu đánh giá";
            this.btn_luudanhgia.UseVisualStyleBackColor = false;
            this.btn_luudanhgia.Click += new System.EventHandler(this.btn_luudanhgia_Click);
            // 
            // frm_DanhGiaSV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 511);
            this.Controls.Add(this.btn_luudanhgia);
            this.Controls.Add(this.groupBox1);
            this.Name = "frm_DanhGiaSV";
            this.Text = "Đánh giá của sinh viên";
            //this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frm_DanhGiaSV_FormClosed);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_danhgia;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_luudanhgia;
    }
}